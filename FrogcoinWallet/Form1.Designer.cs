namespace FrogcoinWallet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SendingToAddress = new System.Windows.Forms.TextBox();
            this.SendFrogcoin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendingAmount = new System.Windows.Forms.TextBox();
            this.RegenerateAddress = new System.Windows.Forms.Button();
            this.recievingAddressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiningButton = new System.Windows.Forms.Button();
            this.hashingPowerLabel = new System.Windows.Forms.Label();
            this.QRButton = new System.Windows.Forms.Button();
            this.ConfirmedLabel = new System.Windows.Forms.Label();
            this.UnconfirmedLabel = new System.Windows.Forms.Label();
            this.ImmatureLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoresInput = new System.Windows.Forms.TextBox();
            this.SyncedLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Transaction6 = new System.Windows.Forms.Panel();
            this.TransactionConfirmations6 = new System.Windows.Forms.Label();
            this.TransactionIcon6 = new System.Windows.Forms.PictureBox();
            this.TransactionAmount6 = new System.Windows.Forms.Label();
            this.Transaction5 = new System.Windows.Forms.Panel();
            this.TransactionConfirmations5 = new System.Windows.Forms.Label();
            this.TransactionIcon5 = new System.Windows.Forms.PictureBox();
            this.TransactionAmount5 = new System.Windows.Forms.Label();
            this.Transaction4 = new System.Windows.Forms.Panel();
            this.TransactionConfirmations4 = new System.Windows.Forms.Label();
            this.TransactionIcon4 = new System.Windows.Forms.PictureBox();
            this.TransactionAmount4 = new System.Windows.Forms.Label();
            this.Transaction3 = new System.Windows.Forms.Panel();
            this.TransactionConfirmations3 = new System.Windows.Forms.Label();
            this.TransactionIcon3 = new System.Windows.Forms.PictureBox();
            this.TransactionAmount3 = new System.Windows.Forms.Label();
            this.Transaction2 = new System.Windows.Forms.Panel();
            this.TransactionConfirmations2 = new System.Windows.Forms.Label();
            this.TransactionIcon2 = new System.Windows.Forms.PictureBox();
            this.TransactionAmount2 = new System.Windows.Forms.Label();
            this.Transaction1 = new System.Windows.Forms.Panel();
            this.TransactionConfirmations1 = new System.Windows.Forms.Label();
            this.TransactionIcon1 = new System.Windows.Forms.PictureBox();
            this.TransactionAmount1 = new System.Windows.Forms.Label();
            this.QRBox = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RPCCmdInput = new System.Windows.Forms.TextBox();
            this.SendRPCButton = new System.Windows.Forms.Button();
            this.RPCOutput = new System.Windows.Forms.RichTextBox();
            this.ConnectionsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Transaction6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon6)).BeginInit();
            this.Transaction5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon5)).BeginInit();
            this.Transaction4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon4)).BeginInit();
            this.Transaction3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon3)).BeginInit();
            this.Transaction2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon2)).BeginInit();
            this.Transaction1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendingToAddress
            // 
            this.SendingToAddress.Location = new System.Drawing.Point(7, 42);
            this.SendingToAddress.Name = "SendingToAddress";
            this.SendingToAddress.Size = new System.Drawing.Size(300, 22);
            this.SendingToAddress.TabIndex = 1;
            // 
            // SendFrogcoin
            // 
            this.SendFrogcoin.Location = new System.Drawing.Point(429, 42);
            this.SendFrogcoin.Name = "SendFrogcoin";
            this.SendFrogcoin.Size = new System.Drawing.Size(95, 23);
            this.SendFrogcoin.TabIndex = 2;
            this.SendFrogcoin.Text = "Send";
            this.SendFrogcoin.UseVisualStyleBackColor = true;
            this.SendFrogcoin.Click += new System.EventHandler(this.SendFrogcoin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SendingAmount);
            this.groupBox1.Controls.Add(this.RegenerateAddress);
            this.groupBox1.Controls.Add(this.recievingAddressBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SendFrogcoin);
            this.groupBox1.Controls.Add(this.SendingToAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move Frogs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Send To";
            // 
            // SendingAmount
            // 
            this.SendingAmount.Location = new System.Drawing.Point(313, 42);
            this.SendingAmount.Name = "SendingAmount";
            this.SendingAmount.Size = new System.Drawing.Size(110, 22);
            this.SendingAmount.TabIndex = 6;
            // 
            // RegenerateAddress
            // 
            this.RegenerateAddress.Location = new System.Drawing.Point(9, 99);
            this.RegenerateAddress.Name = "RegenerateAddress";
            this.RegenerateAddress.Size = new System.Drawing.Size(515, 29);
            this.RegenerateAddress.TabIndex = 5;
            this.RegenerateAddress.Text = "Regenerate Recieving Address";
            this.RegenerateAddress.UseVisualStyleBackColor = true;
            this.RegenerateAddress.Click += new System.EventHandler(this.RegenerateAddress_Click);
            // 
            // recievingAddressBox
            // 
            this.recievingAddressBox.Location = new System.Drawing.Point(143, 71);
            this.recievingAddressBox.Name = "recievingAddressBox";
            this.recievingAddressBox.ReadOnly = true;
            this.recievingAddressBox.Size = new System.Drawing.Size(381, 22);
            this.recievingAddressBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recieving Address:";
            // 
            // MiningButton
            // 
            this.MiningButton.Location = new System.Drawing.Point(166, 21);
            this.MiningButton.Name = "MiningButton";
            this.MiningButton.Size = new System.Drawing.Size(352, 29);
            this.MiningButton.TabIndex = 4;
            this.MiningButton.Text = "Start Catching";
            this.MiningButton.UseVisualStyleBackColor = true;
            this.MiningButton.Click += new System.EventHandler(this.MiningButton_Click);
            // 
            // hashingPowerLabel
            // 
            this.hashingPowerLabel.AutoSize = true;
            this.hashingPowerLabel.Location = new System.Drawing.Point(7, 49);
            this.hashingPowerLabel.Name = "hashingPowerLabel";
            this.hashingPowerLabel.Size = new System.Drawing.Size(119, 17);
            this.hashingPowerLabel.TabIndex = 5;
            this.hashingPowerLabel.Text = "Hashing Power: 0";
            // 
            // QRButton
            // 
            this.QRButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QRButton.Location = new System.Drawing.Point(548, 16);
            this.QRButton.Name = "QRButton";
            this.QRButton.Size = new System.Drawing.Size(240, 23);
            this.QRButton.TabIndex = 8;
            this.QRButton.Text = "Generate QR Address";
            this.QRButton.UseVisualStyleBackColor = true;
            this.QRButton.Click += new System.EventHandler(this.QRButton_Click);
            // 
            // ConfirmedLabel
            // 
            this.ConfirmedLabel.AutoSize = true;
            this.ConfirmedLabel.Location = new System.Drawing.Point(7, 15);
            this.ConfirmedLabel.Name = "ConfirmedLabel";
            this.ConfirmedLabel.Size = new System.Drawing.Size(93, 17);
            this.ConfirmedLabel.TabIndex = 0;
            this.ConfirmedLabel.Text = "Frogs: 0 FRG";
            // 
            // UnconfirmedLabel
            // 
            this.UnconfirmedLabel.AutoSize = true;
            this.UnconfirmedLabel.Location = new System.Drawing.Point(7, 32);
            this.UnconfirmedLabel.Name = "UnconfirmedLabel";
            this.UnconfirmedLabel.Size = new System.Drawing.Size(130, 17);
            this.UnconfirmedLabel.TabIndex = 1;
            this.UnconfirmedLabel.Text = "Amphibians: 0 FRG";
            // 
            // ImmatureLabel
            // 
            this.ImmatureLabel.AutoSize = true;
            this.ImmatureLabel.Location = new System.Drawing.Point(7, 49);
            this.ImmatureLabel.Name = "ImmatureLabel";
            this.ImmatureLabel.Size = new System.Drawing.Size(116, 17);
            this.ImmatureLabel.TabIndex = 2;
            this.ImmatureLabel.Text = "Tadpoles: 0 FRG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConfirmedLabel);
            this.groupBox2.Controls.Add(this.ImmatureLabel);
            this.groupBox2.Controls.Add(this.UnconfirmedLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 69);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pond";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CoresInput);
            this.groupBox3.Controls.Add(this.MiningButton);
            this.groupBox3.Controls.Add(this.hashingPowerLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 75);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Catch Frogs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cores:";
            // 
            // CoresInput
            // 
            this.CoresInput.Location = new System.Drawing.Point(60, 24);
            this.CoresInput.Name = "CoresInput";
            this.CoresInput.Size = new System.Drawing.Size(100, 22);
            this.CoresInput.TabIndex = 7;
            this.CoresInput.Text = "1";
            this.CoresInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CoresInput.TextChanged += new System.EventHandler(this.CoresInput_Changed);
            // 
            // SyncedLabel
            // 
            this.SyncedLabel.AutoSize = true;
            this.SyncedLabel.Location = new System.Drawing.Point(12, 404);
            this.SyncedLabel.Name = "SyncedLabel";
            this.SyncedLabel.Size = new System.Drawing.Size(0, 17);
            this.SyncedLabel.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.Transaction6);
            this.groupBox4.Controls.Add(this.Transaction5);
            this.groupBox4.Controls.Add(this.Transaction4);
            this.groupBox4.Controls.Add(this.Transaction3);
            this.groupBox4.Controls.Add(this.Transaction2);
            this.groupBox4.Controls.Add(this.Transaction1);
            this.groupBox4.Location = new System.Drawing.Point(794, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 444);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recent Transactions";
            // 
            // Transaction6
            // 
            this.Transaction6.Controls.Add(this.TransactionConfirmations6);
            this.Transaction6.Controls.Add(this.TransactionIcon6);
            this.Transaction6.Controls.Add(this.TransactionAmount6);
            this.Transaction6.Location = new System.Drawing.Point(7, 361);
            this.Transaction6.Name = "Transaction6";
            this.Transaction6.Size = new System.Drawing.Size(208, 62);
            this.Transaction6.TabIndex = 4;
            // 
            // TransactionConfirmations6
            // 
            this.TransactionConfirmations6.AutoSize = true;
            this.TransactionConfirmations6.Location = new System.Drawing.Point(60, 36);
            this.TransactionConfirmations6.Name = "TransactionConfirmations6";
            this.TransactionConfirmations6.Size = new System.Drawing.Size(106, 17);
            this.TransactionConfirmations6.TabIndex = 7;
            this.TransactionConfirmations6.Text = "0 Confirmations";
            // 
            // TransactionIcon6
            // 
            this.TransactionIcon6.Image = global::FrogcoinWallet.Properties.Resources.swamp;
            this.TransactionIcon6.Location = new System.Drawing.Point(3, 3);
            this.TransactionIcon6.Name = "TransactionIcon6";
            this.TransactionIcon6.Size = new System.Drawing.Size(50, 50);
            this.TransactionIcon6.TabIndex = 0;
            this.TransactionIcon6.TabStop = false;
            // 
            // TransactionAmount6
            // 
            this.TransactionAmount6.AutoSize = true;
            this.TransactionAmount6.Location = new System.Drawing.Point(60, 3);
            this.TransactionAmount6.Name = "TransactionAmount6";
            this.TransactionAmount6.Size = new System.Drawing.Size(40, 17);
            this.TransactionAmount6.TabIndex = 1;
            this.TransactionAmount6.Text = "+100";
            // 
            // Transaction5
            // 
            this.Transaction5.Controls.Add(this.TransactionConfirmations5);
            this.Transaction5.Controls.Add(this.TransactionIcon5);
            this.Transaction5.Controls.Add(this.TransactionAmount5);
            this.Transaction5.Location = new System.Drawing.Point(7, 293);
            this.Transaction5.Name = "Transaction5";
            this.Transaction5.Size = new System.Drawing.Size(208, 62);
            this.Transaction5.TabIndex = 5;
            // 
            // TransactionConfirmations5
            // 
            this.TransactionConfirmations5.AutoSize = true;
            this.TransactionConfirmations5.Location = new System.Drawing.Point(59, 36);
            this.TransactionConfirmations5.Name = "TransactionConfirmations5";
            this.TransactionConfirmations5.Size = new System.Drawing.Size(106, 17);
            this.TransactionConfirmations5.TabIndex = 6;
            this.TransactionConfirmations5.Text = "0 Confirmations";
            // 
            // TransactionIcon5
            // 
            this.TransactionIcon5.Image = ((System.Drawing.Image)(resources.GetObject("TransactionIcon5.Image")));
            this.TransactionIcon5.Location = new System.Drawing.Point(3, 3);
            this.TransactionIcon5.Name = "TransactionIcon5";
            this.TransactionIcon5.Size = new System.Drawing.Size(50, 50);
            this.TransactionIcon5.TabIndex = 0;
            this.TransactionIcon5.TabStop = false;
            // 
            // TransactionAmount5
            // 
            this.TransactionAmount5.AutoSize = true;
            this.TransactionAmount5.Location = new System.Drawing.Point(60, 3);
            this.TransactionAmount5.Name = "TransactionAmount5";
            this.TransactionAmount5.Size = new System.Drawing.Size(40, 17);
            this.TransactionAmount5.TabIndex = 1;
            this.TransactionAmount5.Text = "+100";
            // 
            // Transaction4
            // 
            this.Transaction4.Controls.Add(this.TransactionConfirmations4);
            this.Transaction4.Controls.Add(this.TransactionIcon4);
            this.Transaction4.Controls.Add(this.TransactionAmount4);
            this.Transaction4.Location = new System.Drawing.Point(6, 225);
            this.Transaction4.Name = "Transaction4";
            this.Transaction4.Size = new System.Drawing.Size(208, 62);
            this.Transaction4.TabIndex = 4;
            // 
            // TransactionConfirmations4
            // 
            this.TransactionConfirmations4.AutoSize = true;
            this.TransactionConfirmations4.Location = new System.Drawing.Point(61, 36);
            this.TransactionConfirmations4.Name = "TransactionConfirmations4";
            this.TransactionConfirmations4.Size = new System.Drawing.Size(106, 17);
            this.TransactionConfirmations4.TabIndex = 5;
            this.TransactionConfirmations4.Text = "0 Confirmations";
            // 
            // TransactionIcon4
            // 
            this.TransactionIcon4.Image = global::FrogcoinWallet.Properties.Resources.catching;
            this.TransactionIcon4.Location = new System.Drawing.Point(3, 3);
            this.TransactionIcon4.Name = "TransactionIcon4";
            this.TransactionIcon4.Size = new System.Drawing.Size(50, 50);
            this.TransactionIcon4.TabIndex = 0;
            this.TransactionIcon4.TabStop = false;
            // 
            // TransactionAmount4
            // 
            this.TransactionAmount4.AutoSize = true;
            this.TransactionAmount4.Location = new System.Drawing.Point(60, 3);
            this.TransactionAmount4.Name = "TransactionAmount4";
            this.TransactionAmount4.Size = new System.Drawing.Size(40, 17);
            this.TransactionAmount4.TabIndex = 1;
            this.TransactionAmount4.Text = "+100";
            // 
            // Transaction3
            // 
            this.Transaction3.Controls.Add(this.TransactionConfirmations3);
            this.Transaction3.Controls.Add(this.TransactionIcon3);
            this.Transaction3.Controls.Add(this.TransactionAmount3);
            this.Transaction3.Location = new System.Drawing.Point(7, 157);
            this.Transaction3.Name = "Transaction3";
            this.Transaction3.Size = new System.Drawing.Size(208, 62);
            this.Transaction3.TabIndex = 4;
            // 
            // TransactionConfirmations3
            // 
            this.TransactionConfirmations3.AutoSize = true;
            this.TransactionConfirmations3.Location = new System.Drawing.Point(60, 36);
            this.TransactionConfirmations3.Name = "TransactionConfirmations3";
            this.TransactionConfirmations3.Size = new System.Drawing.Size(106, 17);
            this.TransactionConfirmations3.TabIndex = 4;
            this.TransactionConfirmations3.Text = "0 Confirmations";
            // 
            // TransactionIcon3
            // 
            this.TransactionIcon3.Image = global::FrogcoinWallet.Properties.Resources.swamp;
            this.TransactionIcon3.Location = new System.Drawing.Point(3, 3);
            this.TransactionIcon3.Name = "TransactionIcon3";
            this.TransactionIcon3.Size = new System.Drawing.Size(50, 50);
            this.TransactionIcon3.TabIndex = 0;
            this.TransactionIcon3.TabStop = false;
            // 
            // TransactionAmount3
            // 
            this.TransactionAmount3.AutoSize = true;
            this.TransactionAmount3.Location = new System.Drawing.Point(60, 3);
            this.TransactionAmount3.Name = "TransactionAmount3";
            this.TransactionAmount3.Size = new System.Drawing.Size(40, 17);
            this.TransactionAmount3.TabIndex = 1;
            this.TransactionAmount3.Text = "+100";
            // 
            // Transaction2
            // 
            this.Transaction2.Controls.Add(this.TransactionConfirmations2);
            this.Transaction2.Controls.Add(this.TransactionIcon2);
            this.Transaction2.Controls.Add(this.TransactionAmount2);
            this.Transaction2.Location = new System.Drawing.Point(7, 89);
            this.Transaction2.Name = "Transaction2";
            this.Transaction2.Size = new System.Drawing.Size(208, 62);
            this.Transaction2.TabIndex = 4;
            // 
            // TransactionConfirmations2
            // 
            this.TransactionConfirmations2.AutoSize = true;
            this.TransactionConfirmations2.Location = new System.Drawing.Point(60, 36);
            this.TransactionConfirmations2.Name = "TransactionConfirmations2";
            this.TransactionConfirmations2.Size = new System.Drawing.Size(106, 17);
            this.TransactionConfirmations2.TabIndex = 3;
            this.TransactionConfirmations2.Text = "0 Confirmations";
            // 
            // TransactionIcon2
            // 
            this.TransactionIcon2.Image = ((System.Drawing.Image)(resources.GetObject("TransactionIcon2.Image")));
            this.TransactionIcon2.Location = new System.Drawing.Point(3, 3);
            this.TransactionIcon2.Name = "TransactionIcon2";
            this.TransactionIcon2.Size = new System.Drawing.Size(50, 50);
            this.TransactionIcon2.TabIndex = 0;
            this.TransactionIcon2.TabStop = false;
            // 
            // TransactionAmount2
            // 
            this.TransactionAmount2.AutoSize = true;
            this.TransactionAmount2.Location = new System.Drawing.Point(60, 3);
            this.TransactionAmount2.Name = "TransactionAmount2";
            this.TransactionAmount2.Size = new System.Drawing.Size(40, 17);
            this.TransactionAmount2.TabIndex = 1;
            this.TransactionAmount2.Text = "+100";
            // 
            // Transaction1
            // 
            this.Transaction1.Controls.Add(this.TransactionConfirmations1);
            this.Transaction1.Controls.Add(this.TransactionIcon1);
            this.Transaction1.Controls.Add(this.TransactionAmount1);
            this.Transaction1.Location = new System.Drawing.Point(7, 21);
            this.Transaction1.Name = "Transaction1";
            this.Transaction1.Size = new System.Drawing.Size(208, 62);
            this.Transaction1.TabIndex = 3;
            // 
            // TransactionConfirmations1
            // 
            this.TransactionConfirmations1.AutoSize = true;
            this.TransactionConfirmations1.Location = new System.Drawing.Point(59, 36);
            this.TransactionConfirmations1.Name = "TransactionConfirmations1";
            this.TransactionConfirmations1.Size = new System.Drawing.Size(106, 17);
            this.TransactionConfirmations1.TabIndex = 2;
            this.TransactionConfirmations1.Text = "0 Confirmations";
            // 
            // TransactionIcon1
            // 
            this.TransactionIcon1.Image = global::FrogcoinWallet.Properties.Resources.catching;
            this.TransactionIcon1.Location = new System.Drawing.Point(4, 3);
            this.TransactionIcon1.Name = "TransactionIcon1";
            this.TransactionIcon1.Size = new System.Drawing.Size(50, 50);
            this.TransactionIcon1.TabIndex = 0;
            this.TransactionIcon1.TabStop = false;
            // 
            // TransactionAmount1
            // 
            this.TransactionAmount1.AutoSize = true;
            this.TransactionAmount1.Location = new System.Drawing.Point(60, 3);
            this.TransactionAmount1.Name = "TransactionAmount1";
            this.TransactionAmount1.Size = new System.Drawing.Size(40, 17);
            this.TransactionAmount1.TabIndex = 1;
            this.TransactionAmount1.Text = "+100";
            // 
            // QRBox
            // 
            this.QRBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QRBox.Location = new System.Drawing.Point(548, 45);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(240, 240);
            this.QRBox.TabIndex = 7;
            this.QRBox.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.RPCOutput);
            this.groupBox5.Controls.Add(this.SendRPCButton);
            this.groupBox5.Controls.Add(this.RPCCmdInput);
            this.groupBox5.Location = new System.Drawing.Point(0, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(788, 116);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Debug";
            // 
            // RPCCmdInput
            // 
            this.RPCCmdInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RPCCmdInput.Location = new System.Drawing.Point(6, 18);
            this.RPCCmdInput.Name = "RPCCmdInput";
            this.RPCCmdInput.Size = new System.Drawing.Size(647, 22);
            this.RPCCmdInput.TabIndex = 0;
            // 
            // SendRPCButton
            // 
            this.SendRPCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendRPCButton.Location = new System.Drawing.Point(657, 18);
            this.SendRPCButton.Name = "SendRPCButton";
            this.SendRPCButton.Size = new System.Drawing.Size(125, 23);
            this.SendRPCButton.TabIndex = 2;
            this.SendRPCButton.Text = "Send RPC";
            this.SendRPCButton.UseVisualStyleBackColor = true;
            this.SendRPCButton.Click += new System.EventHandler(this.SendRPCButton_Click);
            // 
            // RPCOutput
            // 
            this.RPCOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RPCOutput.Location = new System.Drawing.Point(6, 51);
            this.RPCOutput.Name = "RPCOutput";
            this.RPCOutput.ReadOnly = true;
            this.RPCOutput.Size = new System.Drawing.Size(776, 59);
            this.RPCOutput.TabIndex = 3;
            this.RPCOutput.Text = "";
            // 
            // ConnectionsLabel
            // 
            this.ConnectionsLabel.AutoSize = true;
            this.ConnectionsLabel.Location = new System.Drawing.Point(3, 427);
            this.ConnectionsLabel.Name = "ConnectionsLabel";
            this.ConnectionsLabel.Size = new System.Drawing.Size(88, 17);
            this.ConnectionsLabel.TabIndex = 11;
            this.ConnectionsLabel.Text = "0 Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.ConnectionsLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.SyncedLabel);
            this.Controls.Add(this.QRButton);
            this.Controls.Add(this.QRBox);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Frogcoin Wallet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.Transaction6.ResumeLayout(false);
            this.Transaction6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon6)).EndInit();
            this.Transaction5.ResumeLayout(false);
            this.Transaction5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon5)).EndInit();
            this.Transaction4.ResumeLayout(false);
            this.Transaction4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon4)).EndInit();
            this.Transaction3.ResumeLayout(false);
            this.Transaction3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon3)).EndInit();
            this.Transaction2.ResumeLayout(false);
            this.Transaction2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon2)).EndInit();
            this.Transaction1.ResumeLayout(false);
            this.Transaction1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SendingToAddress;
        private System.Windows.Forms.Button SendFrogcoin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegenerateAddress;
        private System.Windows.Forms.TextBox recievingAddressBox;
        private System.Windows.Forms.Button MiningButton;
        private System.Windows.Forms.Label hashingPowerLabel;
        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.Button QRButton;
        private System.Windows.Forms.TextBox SendingAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConfirmedLabel;
        private System.Windows.Forms.Label UnconfirmedLabel;
        private System.Windows.Forms.Label ImmatureLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CoresInput;
        private System.Windows.Forms.Label SyncedLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TransactionAmount1;
        private System.Windows.Forms.PictureBox TransactionIcon1;
        private System.Windows.Forms.Panel Transaction6;
        private System.Windows.Forms.Label TransactionConfirmations6;
        private System.Windows.Forms.PictureBox TransactionIcon6;
        private System.Windows.Forms.Label TransactionAmount6;
        private System.Windows.Forms.Panel Transaction5;
        private System.Windows.Forms.Label TransactionConfirmations5;
        private System.Windows.Forms.PictureBox TransactionIcon5;
        private System.Windows.Forms.Label TransactionAmount5;
        private System.Windows.Forms.Panel Transaction4;
        private System.Windows.Forms.Label TransactionConfirmations4;
        private System.Windows.Forms.PictureBox TransactionIcon4;
        private System.Windows.Forms.Label TransactionAmount4;
        private System.Windows.Forms.Panel Transaction3;
        private System.Windows.Forms.Label TransactionConfirmations3;
        private System.Windows.Forms.PictureBox TransactionIcon3;
        private System.Windows.Forms.Label TransactionAmount3;
        private System.Windows.Forms.Panel Transaction2;
        private System.Windows.Forms.Label TransactionConfirmations2;
        private System.Windows.Forms.PictureBox TransactionIcon2;
        private System.Windows.Forms.Label TransactionAmount2;
        private System.Windows.Forms.Panel Transaction1;
        private System.Windows.Forms.Label TransactionConfirmations1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox RPCOutput;
        private System.Windows.Forms.Button SendRPCButton;
        private System.Windows.Forms.TextBox RPCCmdInput;
        private System.Windows.Forms.Label ConnectionsLabel;
    }
}

