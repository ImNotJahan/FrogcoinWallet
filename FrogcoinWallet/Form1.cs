using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Zen.Barcode;
using System.Linq;
using System.IO;
using System.Text;
using FrogcoinWallet.Properties;

namespace FrogcoinWallet
{
    public partial class Form1 : Form
    {
        private const int IMMATURE_SEARCH_DEPTH = 40;
        private const int UNCONFIRMED_SEARCH_DEPTH = 40;

        private Label[] transactionAmounts;
        private Label[] transactionConfirmations;
        private PictureBox[] transactionIcons;

        string basePath;
        string configPath;
        bool isMining = false;

        public Form1()
        {
            basePath = AppContext.BaseDirectory;

            // Check if config file exists
            configPath = Environment.ExpandEnvironmentVariables(@"%appdata%\Frogcoin\frogcoin.conf");
            string dirPath = Environment.ExpandEnvironmentVariables(@"%appdata%\Frogcoin\");
            if (!File.Exists(configPath))
            {
                if (!Directory.Exists(dirPath)) StartDaemon().WaitForExit(); // This way the directory is created by frogcoind

                using (FileStream fs = File.Create(configPath))
                {
                    byte[] author = new UTF8Encoding(true).GetBytes("rpcuser=frogcoinrpc\nrpcpassword=" + Guid.NewGuid() + "\naddnode=108.220.106.111");
                    fs.Write(author, 0, author.Length);
                }
            }

            // Make sure daemon is running
            if (RunCommand("a") == "error: couldn't connect to server\r\n")
            {
                StartDaemon();

                while (RunCommand("a") == "error: couldn't connect to server\r\n") { }
            }

            InitializeComponent();

            // Network stuff
            ConnectionsLabel.Text = "Connections: " + RunCommand("getconnectioncount");
            //CheckIfSynced();

            // Balance stuff
            DisplayWalletBalance();

            // Moving stuff
            recievingAddressBox.Text = GetPublicAddress();

            // Mining stuff
            MiningInfoObject miningInfo = StringToJSON<MiningInfoObject>(RunCommand("getmininginfo"));
            if (miningInfo.Generate == true)
            {
                isMining = true;

                MiningButton.Text = "Stop Catching";
                hashingPowerLabel.Text = "Hashing Power: " + miningInfo.HashesPerSec;
                CoresInput.ReadOnly = true;
            }

            lastCoresAmount = miningInfo.GenProcLimit.ToString();
            CoresInput.Text = lastCoresAmount;

            // Repeating stuff
            DoEvery((a, b) => DisplayWalletBalance(), 10000); // Every ten seconds
            DoEvery((a, b) => RefreshHashingPower(), 10000); // Every ten seconds
            DoEvery((a, b) => ConnectionsLabel.Text = "Connections: " + RunCommand("getconnectioncount"), 1000 * 60); // Every minute
            DoEvery((a, b) => DisplayTransactions(), 10000); // Every ten seconds

            // Transaction Stuff
            transactionAmounts = new Label[] { TransactionAmount1, TransactionAmount2, TransactionAmount3, TransactionAmount4, TransactionAmount5, TransactionAmount6 };
            transactionConfirmations = new Label[] { TransactionConfirmations1, TransactionConfirmations2, TransactionConfirmations3,
                TransactionConfirmations4, TransactionConfirmations5, TransactionConfirmations6 };
            transactionIcons = new PictureBox[] { TransactionIcon1, TransactionIcon2, TransactionIcon3, TransactionIcon4, TransactionIcon5, TransactionIcon6 };

            DisplayTransactions();
        }

        private void DoEvery(System.Timers.ElapsedEventHandler action, int milliseconds)
        {
            DoEvery(action, milliseconds, true);
        }

        private void DoEvery(System.Timers.ElapsedEventHandler action, int milliseconds, bool autoReset)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += action;
            timer.AutoReset = autoReset;
            timer.Interval = milliseconds;
            timer.Start();
        }

        private void CheckIfSynced()
        {
            List<NodeInfo> nodes = StringToJSON<List<NodeInfo>>(RunCommand("getaddednodeinfo true"));
        }

        private static double RoundToNearest(double amount, int nth)
        {
            return Math.Round(amount * nth) / nth;
        }

        private static double DefaultDisplayRound(string amount)
        {
            return RoundToNearest(Convert.ToDouble(amount), 100);
        }

        private static double DefaultDisplayRound(double amount)
        {
            return RoundToNearest(amount, 100);
        }

        private void DisplayTransactions()
        {
            List<TransactionObject> transactions = StringToJSON<List<TransactionObject>>(RunCommand("listtransactions * 6"));

            for(int k = 0; k < 6; k++)
            {
                if(k > transactions.Count)
                {
                    transactionIcons[k].Visible = false;
                    transactionConfirmations[k].Visible = false;
                    transactionAmounts[k].Visible = false;
                }
                else
                {
                    TransactionObject transaction = transactions[transactions.Count - 1 - k]; // The list goes old -> new, so this makes it new -> old

                    switch (transaction.Category)
                    {
                        case "generated":
                        case "immature":
                            transactionIcons[k].Image = (System.Drawing.Image)Resources.ResourceManager.GetObject("catching");
                            break;

                        case "send":
                            transactionIcons[k].Image = (System.Drawing.Image)Resources.ResourceManager.GetObject("hopping");
                            break;

                        case "receive":
                            transactionIcons[k].Image = (System.Drawing.Image)Resources.ResourceManager.GetObject("swamp");
                            break;
                    }

                    transactionAmounts[k].Text = (transaction.Amount > 0 ? "+" : "") + transaction.Amount + " FRG";
                    transactionConfirmations[k].Text = new DateTime(1970, 1, 1).AddSeconds(transaction.TimeReceived).ToLocalTime().ToString("yy/MM/dd HH:mm:ss");
                }
            }
        }

        private double GetImmatureBalance(int depth)
        {
            double balance = 0;

            List<TransactionObject> transactions = StringToJSON<List<TransactionObject>>(RunCommand("listtransactions * " + depth));

            foreach(TransactionObject transaction in transactions)
            {
                if (transaction.Category == "immature") balance += transaction.Amount;
            }

            return balance;
        }

        private double GetUnconfirmedBalance(int depth)
        {
            double balance = 0;

            List<TransactionObject> transactions = StringToJSON<List<TransactionObject>>(RunCommand("listtransactions * " + depth));

            foreach (TransactionObject transaction in transactions)
            {
                if (transaction.Category == "receive" && transaction.Confirmations < 6) balance += transaction.Amount;
            }

            return balance;
        }

        private void DisplayWalletBalance()
        {
            ConfirmedLabel.Text = "Frogs: " + DefaultDisplayRound(RunCommand("getbalance")) + " FRG";
            UnconfirmedLabel.Text = "Amphibians: " + DefaultDisplayRound(GetUnconfirmedBalance(UNCONFIRMED_SEARCH_DEPTH)) + " FRG";
            ImmatureLabel.Text = "Tadpoles: " + DefaultDisplayRound(GetImmatureBalance(IMMATURE_SEARCH_DEPTH)) + " FRG";
        }

        private static T StringToJSON<T>(string text)
        {
            return new JavaScriptSerializer().Deserialize<T>(text);
        }


        private void MiningButton_Click(object sender, EventArgs e)
        {
            if (!isMining)
            {
                RunCommand("setgenerate true " + CoresInput.Text);

                MiningButton.Text = "Stop Catching";
                CoresInput.ReadOnly = true;

                isMining = true;
            }
            else
            {
                RunCommand("setgenerate false");

                MiningButton.Text = "Start Catching";
                CoresInput.ReadOnly = false;

                isMining = false;
            }
        }

        private string RunCommand(string command)
        {
            string fullCommand = basePath + "\\frogcoind.exe " + command;

            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/C " + fullCommand,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            Process process = Process.Start(startInfo);

            string output = process.StandardOutput.ReadToEnd();
            Debug.WriteLine(output);

            string err = process.StandardError.ReadToEnd();
            Debug.WriteLine(err);

            process.WaitForExit();

            if (output == "") output = err;

            return output;
        }

        private Process StartDaemon()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/C " + basePath + "\\frogcoind.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            return Process.Start(startInfo);
        }

        private void RefreshHashingPower()
        {
            hashingPowerLabel.Text = "Hashing Power: " + RunCommand("gethashespersec");
        }

        private void RegenerateAddress_Click(object sender, EventArgs e)
        {
            recievingAddressBox.Text = RunCommand("getnewaddress");
        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            QRBox.Image = BarcodeDrawFactory.CodeQr.Draw("frogcoin:" + recievingAddressBox.Text, 60, 4);
            QRButton.Width = QRBox.Image.Width;
        }

        private void SendFrogcoin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to send " + SendingAmount.Text + " Frogcoins to " + SendingToAddress.Text + "?", 
                "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                RunCommand("sendtoaddress " + SendingToAddress.Text + " " + SendingAmount.Text);
                DisplayWalletBalance();
            }
        }

        private string lastCoresAmount = "1";
        private void CoresInput_Changed(object sender, EventArgs e)
        {
            if (CoresInput.Text.All(char.IsDigit)) lastCoresAmount = CoresInput.Text;
            else CoresInput.Text = lastCoresAmount;
        }

        private void SendRPCButton_Click(object sender, EventArgs e)
        {
            RPCOutput.Text = RunCommand(RPCCmdInput.Text);
        }

        private string GetPublicAddress()
        {
            return StringToJSON<List<AddressObject>>(RunCommand("listreceivedbyaddress 0 true"))[0].Address;
        }

        private void wordGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Preferences().ShowDialog();
        }

        private void viewPrivateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyDisplay privateKeyDisplay = new CopyDisplay();
            privateKeyDisplay.Text = "Private Key";
            privateKeyDisplay.TextBox.Text = RunCommand("dumpprivkey " + GetPublicAddress());
            privateKeyDisplay.ShowDialog();
        }

        private void editFrogcoinconfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", configPath);
        }
    }

    public class MiningInfoObject
    {
        public int Blocks { get; set; }
        public int CurrentBlockSize { get; set; }
        public int CurrentBlockTX { get; set; }
        public double Difficulty { get; set; }
        public string Errors { get; set; }
        public bool Generate { get; set; }
        public int GenProcLimit { get; set; }
        public int HashesPerSec { get; set; }
        public int NetworkHashPS { get; set; }
        public int PooledTX { get; set; }
        public bool Testnet { get; set; }
    }

    public class AddressObject
    {
        public string Address { get; set; }
        public string Account { get; set; }
        public double Amount { get; set; }
        public int Confirmations { get; set; }
        public List<String> TXIds { get; set; }
    }

    public class TransactionObject
    {
        public string Account { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }
        public int Confirmations { get; set; }
        public bool Generated { get; set; }
        public string BlockHash { get; set; }
        public int BlockTndex { get; set; }
        public long BlockTime { get; set; }
        public string TXId { get; set; }
        public string NormTXId { get; set; }
        public long Time { get; set; }
        public long TimeReceived { get; set; }
    }

    public class PeerInfo // Unused
    {
        public string Addr { get; set; }
        public string Services { get; set; }
        public int LastSend { get; set; }
        public int LastRecv { get; set; }
        public int BytesSent { get; set; }
        public int BytesRecv { get; set; }
        public int BlocksRequested { get; set; }
        public int ConnTime { get; set; } // Connection time
        public int Version { get; set; }
        public string SubVer { get; set; }
        public bool Inbound { get; set; }
        public int StartingHeight { get; set; }
        public int BanScore { get; set; }
        public bool SyncNode { get; set; }
    }

    public class NodeInfo // Unused
    {
        public string AddedNode { get; set; }
        public bool Connected { get; set; }
        public List<NodeAddressInfo> Addresses { get; set; }
    }

    public class NodeAddressInfo // Required by NodeInfo but unused
    {
        public string Address { get; set; }
        public string Connected { get; set; }
    }
}
