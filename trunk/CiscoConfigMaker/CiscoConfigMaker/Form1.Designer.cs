namespace CiscoConfigMaker
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbHostname = new System.Windows.Forms.CheckBox();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbSecret = new System.Windows.Forms.TextBox();
            this.cbSecret = new System.Windows.Forms.CheckBox();
            this.gbStartupConfig = new System.Windows.Forms.GroupBox();
            this.cbWriteStartup = new System.Windows.Forms.CheckBox();
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbWriteIface2 = new System.Windows.Forms.CheckBox();
            this.cbWriteIface1 = new System.Windows.Forms.CheckBox();
            this.gbIface2 = new System.Windows.Forms.GroupBox();
            this.cbDHCPHelperAddress2 = new System.Windows.Forms.CheckBox();
            this.tbDHCPHelperAddress2 = new System.Windows.Forms.TextBox();
            this.cbIFace2ClockRate = new System.Windows.Forms.CheckBox();
            this.tbIFace2ClockRate = new System.Windows.Forms.TextBox();
            this.cbIface2Name = new System.Windows.Forms.CheckBox();
            this.tbIface2Name = new System.Windows.Forms.TextBox();
            this.cbIface2Shut = new System.Windows.Forms.CheckBox();
            this.cbIface2IP = new System.Windows.Forms.CheckBox();
            this.tbIface2Netmask = new System.Windows.Forms.TextBox();
            this.tbIface2IP = new System.Windows.Forms.TextBox();
            this.gbIface1 = new System.Windows.Forms.GroupBox();
            this.cbDHCPHelperAddress1 = new System.Windows.Forms.CheckBox();
            this.tbDHCPHelperAddress1 = new System.Windows.Forms.TextBox();
            this.cbIFace1ClockRate = new System.Windows.Forms.CheckBox();
            this.tbIFace1ClockRate = new System.Windows.Forms.TextBox();
            this.cbIface1Name = new System.Windows.Forms.CheckBox();
            this.tbIface1Name = new System.Windows.Forms.TextBox();
            this.cbIface1Shut = new System.Windows.Forms.CheckBox();
            this.cbIface1IP = new System.Windows.Forms.CheckBox();
            this.tbIface1Netmask = new System.Windows.Forms.TextBox();
            this.tbIface1IP = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbWriteVlan = new System.Windows.Forms.CheckBox();
            this.gbAssignVlan = new System.Windows.Forms.GroupBox();
            this.tbInterfaceName7 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface7 = new System.Windows.Forms.CheckBox();
            this.tbVlanName7 = new System.Windows.Forms.TextBox();
            this.tbVlanID7 = new System.Windows.Forms.TextBox();
            this.cbVlan7 = new System.Windows.Forms.CheckBox();
            this.tbInterfaceName6 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface6 = new System.Windows.Forms.CheckBox();
            this.tbVlanName6 = new System.Windows.Forms.TextBox();
            this.tbVlanID6 = new System.Windows.Forms.TextBox();
            this.cbVlan6 = new System.Windows.Forms.CheckBox();
            this.tbInterfaceName5 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface5 = new System.Windows.Forms.CheckBox();
            this.tbVlanName5 = new System.Windows.Forms.TextBox();
            this.tbVlanID5 = new System.Windows.Forms.TextBox();
            this.cbVlan5 = new System.Windows.Forms.CheckBox();
            this.tbInterfaceName4 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface4 = new System.Windows.Forms.CheckBox();
            this.tbVlanName4 = new System.Windows.Forms.TextBox();
            this.tbVlanID4 = new System.Windows.Forms.TextBox();
            this.cbVlan4 = new System.Windows.Forms.CheckBox();
            this.tbInterfaceName3 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface3 = new System.Windows.Forms.CheckBox();
            this.tbVlanName3 = new System.Windows.Forms.TextBox();
            this.tbVlanID3 = new System.Windows.Forms.TextBox();
            this.cbVlan3 = new System.Windows.Forms.CheckBox();
            this.tbInterfaceName2 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface2 = new System.Windows.Forms.CheckBox();
            this.tbVlanName2 = new System.Windows.Forms.TextBox();
            this.tbVlanID2 = new System.Windows.Forms.TextBox();
            this.cbVlan2 = new System.Windows.Forms.CheckBox();
            this.tbInterfaceName1 = new System.Windows.Forms.TextBox();
            this.cbAssignToInterface1 = new System.Windows.Forms.CheckBox();
            this.tbVlanName1 = new System.Windows.Forms.TextBox();
            this.tbVlanID1 = new System.Windows.Forms.TextBox();
            this.cbVlan1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbWriteSwitchCommands = new System.Windows.Forms.CheckBox();
            this.gbTrunking = new System.Windows.Forms.GroupBox();
            this.lblTrunkInterface = new System.Windows.Forms.Label();
            this.tbTrunkInterface = new System.Windows.Forms.TextBox();
            this.tbTrunkingNativeVlan = new System.Windows.Forms.TextBox();
            this.cbTrunking = new System.Windows.Forms.CheckBox();
            this.gbManagementInterface = new System.Windows.Forms.GroupBox();
            this.tbManagementNetmask = new System.Windows.Forms.TextBox();
            this.tbManagementIP = new System.Windows.Forms.TextBox();
            this.tbManagementVlanName = new System.Windows.Forms.TextBox();
            this.tbManagementVlanID = new System.Windows.Forms.TextBox();
            this.cbManagementVlan = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbWriteEIGRP = new System.Windows.Forms.CheckBox();
            this.gbEIGRP = new System.Windows.Forms.GroupBox();
            this.cbEIGRPNetwork2 = new System.Windows.Forms.CheckBox();
            this.tbEIGRPNetworkID2 = new System.Windows.Forms.TextBox();
            this.cbEIGRPNetwork1 = new System.Windows.Forms.CheckBox();
            this.tbEIGRPNetworkID1 = new System.Windows.Forms.TextBox();
            this.cbEIGRPID = new System.Windows.Forms.CheckBox();
            this.tbEIGRPAreaID = new System.Windows.Forms.TextBox();
            this.cbWriteOSPF = new System.Windows.Forms.CheckBox();
            this.gbOSPF = new System.Windows.Forms.GroupBox();
            this.cbOSPFNetworkID2 = new System.Windows.Forms.CheckBox();
            this.tbOSPFNetworkID2 = new System.Windows.Forms.TextBox();
            this.tbOSPFInvMask2 = new System.Windows.Forms.TextBox();
            this.cbOSPFNetworkID1 = new System.Windows.Forms.CheckBox();
            this.tbOSPFNetworkID1 = new System.Windows.Forms.TextBox();
            this.cbOSPFID = new System.Windows.Forms.CheckBox();
            this.tbOSPFInvMask1 = new System.Windows.Forms.TextBox();
            this.tbOSPFAreaID = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbDHCPConfig = new System.Windows.Forms.GroupBox();
            this.tbDHCPDefaultRouter = new System.Windows.Forms.TextBox();
            this.cbDHCPDefaultRouter = new System.Windows.Forms.CheckBox();
            this.tbDHCPDnsServer = new System.Windows.Forms.TextBox();
            this.cbDHCPDnsServer = new System.Windows.Forms.CheckBox();
            this.tbDHCPNetworkNetmask = new System.Windows.Forms.TextBox();
            this.tbDHCPPool = new System.Windows.Forms.TextBox();
            this.tbDHCPNetworkIP = new System.Windows.Forms.TextBox();
            this.cbDHCPPool = new System.Windows.Forms.CheckBox();
            this.gbExcludedIPs = new System.Windows.Forms.GroupBox();
            this.tbExcludeRangeStop2 = new System.Windows.Forms.TextBox();
            this.tbExcludeRangeStart2 = new System.Windows.Forms.TextBox();
            this.cbExcludeRange2 = new System.Windows.Forms.CheckBox();
            this.tbExcludeRangeStop1 = new System.Windows.Forms.TextBox();
            this.tbExcludeRangeStart1 = new System.Windows.Forms.TextBox();
            this.cbExcludeRange1 = new System.Windows.Forms.CheckBox();
            this.cbWriteDHCP = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.gbNATMapping = new System.Windows.Forms.GroupBox();
            this.tbOutsideNATPublic = new System.Windows.Forms.TextBox();
            this.tbOutsideNATPrivate = new System.Windows.Forms.TextBox();
            this.cbOutsideNAT = new System.Windows.Forms.CheckBox();
            this.tbInsideNATPublic = new System.Windows.Forms.TextBox();
            this.tbInsideNATPrivate = new System.Windows.Forms.TextBox();
            this.cbInsideNAT = new System.Windows.Forms.CheckBox();
            this.cbWriteNAT = new System.Windows.Forms.CheckBox();
            this.gbNatInOut = new System.Windows.Forms.GroupBox();
            this.tbNATOutsideInt = new System.Windows.Forms.TextBox();
            this.cbNATOutsideInt = new System.Windows.Forms.CheckBox();
            this.tbNATInsideInt = new System.Windows.Forms.TextBox();
            this.cbNATInsideInt = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.gbStandardACL = new System.Windows.Forms.GroupBox();
            this.tbStandardACL8 = new System.Windows.Forms.TextBox();
            this.cbStandardACL8 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL6 = new System.Windows.Forms.TextBox();
            this.cbStandardACL6 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL7 = new System.Windows.Forms.TextBox();
            this.cbStandardACL7 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL5 = new System.Windows.Forms.TextBox();
            this.cbStandardACL5 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL4 = new System.Windows.Forms.TextBox();
            this.cbStandardACL4 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL2 = new System.Windows.Forms.TextBox();
            this.cbStandardACL2 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL3 = new System.Windows.Forms.TextBox();
            this.cbStandardACL3 = new System.Windows.Forms.CheckBox();
            this.tbStandardACL1 = new System.Windows.Forms.TextBox();
            this.cbStandardACL1 = new System.Windows.Forms.CheckBox();
            this.tbStandardACLApplyInOut = new System.Windows.Forms.TextBox();
            this.cbStandardACLApply = new System.Windows.Forms.CheckBox();
            this.tbStandardACLApply = new System.Windows.Forms.TextBox();
            this.tbStandardACLName = new System.Windows.Forms.TextBox();
            this.cbStandardACL = new System.Windows.Forms.CheckBox();
            this.cbWriteStandardACL = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbExtendedACL4 = new System.Windows.Forms.TextBox();
            this.cbExtendedACL4 = new System.Windows.Forms.CheckBox();
            this.tbExtendedACL3 = new System.Windows.Forms.TextBox();
            this.cbExtendedACL3 = new System.Windows.Forms.CheckBox();
            this.tbExtendedACL2 = new System.Windows.Forms.TextBox();
            this.cbExtendedACL2 = new System.Windows.Forms.CheckBox();
            this.tbExtendedACL1 = new System.Windows.Forms.TextBox();
            this.cbExtendedACL1 = new System.Windows.Forms.CheckBox();
            this.tbExtendedACLApplyInOut = new System.Windows.Forms.TextBox();
            this.cbExtendedACLApply = new System.Windows.Forms.CheckBox();
            this.tbExtendedACLApply = new System.Windows.Forms.TextBox();
            this.tbExtendedACLName = new System.Windows.Forms.TextBox();
            this.cbExtendedACL = new System.Windows.Forms.CheckBox();
            this.cbWriteExtendedACL = new System.Windows.Forms.CheckBox();
            this.gbStartupConfig.SuspendLayout();
            this.tabBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbIface2.SuspendLayout();
            this.gbIface1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbAssignVlan.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbTrunking.SuspendLayout();
            this.gbManagementInterface.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbEIGRP.SuspendLayout();
            this.gbOSPF.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbDHCPConfig.SuspendLayout();
            this.gbExcludedIPs.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.gbNATMapping.SuspendLayout();
            this.gbNatInOut.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.gbStandardACL.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(267, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(195, 122);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Make Cisco Go Now";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbHostname
            // 
            this.tbHostname.Location = new System.Drawing.Point(86, 19);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(107, 20);
            this.tbHostname.TabIndex = 5;
            this.tbHostname.Text = "hostname";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(86, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(107, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "cisco";
            // 
            // cbHostname
            // 
            this.cbHostname.AutoSize = true;
            this.cbHostname.Location = new System.Drawing.Point(6, 19);
            this.cbHostname.Name = "cbHostname";
            this.cbHostname.Size = new System.Drawing.Size(74, 17);
            this.cbHostname.TabIndex = 7;
            this.cbHostname.Text = "Hostname";
            this.cbHostname.UseVisualStyleBackColor = true;
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Location = new System.Drawing.Point(6, 71);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(72, 17);
            this.cbPassword.TabIndex = 8;
            this.cbPassword.Text = "Password";
            this.cbPassword.UseVisualStyleBackColor = true;
            // 
            // tbSecret
            // 
            this.tbSecret.Location = new System.Drawing.Point(86, 45);
            this.tbSecret.Name = "tbSecret";
            this.tbSecret.Size = new System.Drawing.Size(107, 20);
            this.tbSecret.TabIndex = 11;
            this.tbSecret.Text = "class";
            // 
            // cbSecret
            // 
            this.cbSecret.AutoSize = true;
            this.cbSecret.Location = new System.Drawing.Point(6, 45);
            this.cbSecret.Name = "cbSecret";
            this.cbSecret.Size = new System.Drawing.Size(57, 17);
            this.cbSecret.TabIndex = 12;
            this.cbSecret.Text = "Secret";
            this.cbSecret.UseVisualStyleBackColor = true;
            // 
            // gbStartupConfig
            // 
            this.gbStartupConfig.Controls.Add(this.cbSecret);
            this.gbStartupConfig.Controls.Add(this.tbSecret);
            this.gbStartupConfig.Controls.Add(this.cbPassword);
            this.gbStartupConfig.Controls.Add(this.cbHostname);
            this.gbStartupConfig.Controls.Add(this.tbPassword);
            this.gbStartupConfig.Controls.Add(this.tbHostname);
            this.gbStartupConfig.Location = new System.Drawing.Point(6, 35);
            this.gbStartupConfig.Name = "gbStartupConfig";
            this.gbStartupConfig.Size = new System.Drawing.Size(214, 99);
            this.gbStartupConfig.TabIndex = 5;
            this.gbStartupConfig.TabStop = false;
            this.gbStartupConfig.Text = "Startup";
            // 
            // cbWriteStartup
            // 
            this.cbWriteStartup.AutoSize = true;
            this.cbWriteStartup.Location = new System.Drawing.Point(12, 12);
            this.cbWriteStartup.Name = "cbWriteStartup";
            this.cbWriteStartup.Size = new System.Drawing.Size(88, 17);
            this.cbWriteStartup.TabIndex = 9;
            this.cbWriteStartup.Text = "Write Startup";
            this.cbWriteStartup.UseVisualStyleBackColor = true;
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabPage1);
            this.tabBox.Controls.Add(this.tabPage2);
            this.tabBox.Controls.Add(this.tabPage3);
            this.tabBox.Controls.Add(this.tabPage4);
            this.tabBox.Controls.Add(this.tabPage5);
            this.tabBox.Controls.Add(this.tabPage6);
            this.tabBox.Controls.Add(this.tabPage7);
            this.tabBox.Controls.Add(this.tabPage8);
            this.tabBox.Location = new System.Drawing.Point(6, 140);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(456, 288);
            this.tabBox.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbWriteIface2);
            this.tabPage1.Controls.Add(this.cbWriteIface1);
            this.tabPage1.Controls.Add(this.gbIface2);
            this.tabPage1.Controls.Add(this.gbIface1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interfaces";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbWriteIface2
            // 
            this.cbWriteIface2.AutoSize = true;
            this.cbWriteIface2.Location = new System.Drawing.Point(228, 6);
            this.cbWriteIface2.Name = "cbWriteIface2";
            this.cbWriteIface2.Size = new System.Drawing.Size(105, 17);
            this.cbWriteIface2.TabIndex = 18;
            this.cbWriteIface2.Text = "Write Interface 2";
            this.cbWriteIface2.UseVisualStyleBackColor = true;
            // 
            // cbWriteIface1
            // 
            this.cbWriteIface1.AutoSize = true;
            this.cbWriteIface1.Location = new System.Drawing.Point(8, 6);
            this.cbWriteIface1.Name = "cbWriteIface1";
            this.cbWriteIface1.Size = new System.Drawing.Size(105, 17);
            this.cbWriteIface1.TabIndex = 17;
            this.cbWriteIface1.Text = "Write Interface 1";
            this.cbWriteIface1.UseVisualStyleBackColor = true;
            // 
            // gbIface2
            // 
            this.gbIface2.Controls.Add(this.cbDHCPHelperAddress2);
            this.gbIface2.Controls.Add(this.tbDHCPHelperAddress2);
            this.gbIface2.Controls.Add(this.cbIFace2ClockRate);
            this.gbIface2.Controls.Add(this.tbIFace2ClockRate);
            this.gbIface2.Controls.Add(this.cbIface2Name);
            this.gbIface2.Controls.Add(this.tbIface2Name);
            this.gbIface2.Controls.Add(this.cbIface2Shut);
            this.gbIface2.Controls.Add(this.cbIface2IP);
            this.gbIface2.Controls.Add(this.tbIface2Netmask);
            this.gbIface2.Controls.Add(this.tbIface2IP);
            this.gbIface2.Location = new System.Drawing.Point(228, 29);
            this.gbIface2.Name = "gbIface2";
            this.gbIface2.Size = new System.Drawing.Size(214, 170);
            this.gbIface2.TabIndex = 16;
            this.gbIface2.TabStop = false;
            this.gbIface2.Text = "Interface 2";
            // 
            // cbDHCPHelperAddress2
            // 
            this.cbDHCPHelperAddress2.AutoSize = true;
            this.cbDHCPHelperAddress2.Location = new System.Drawing.Point(6, 132);
            this.cbDHCPHelperAddress2.Name = "cbDHCPHelperAddress2";
            this.cbDHCPHelperAddress2.Size = new System.Drawing.Size(82, 17);
            this.cbDHCPHelperAddress2.TabIndex = 17;
            this.cbDHCPHelperAddress2.Text = "Helper Addr";
            this.cbDHCPHelperAddress2.UseVisualStyleBackColor = true;
            // 
            // tbDHCPHelperAddress2
            // 
            this.tbDHCPHelperAddress2.Location = new System.Drawing.Point(86, 132);
            this.tbDHCPHelperAddress2.Name = "tbDHCPHelperAddress2";
            this.tbDHCPHelperAddress2.Size = new System.Drawing.Size(107, 20);
            this.tbDHCPHelperAddress2.TabIndex = 16;
            this.tbDHCPHelperAddress2.Text = "For DHCP";
            // 
            // cbIFace2ClockRate
            // 
            this.cbIFace2ClockRate.AutoSize = true;
            this.cbIFace2ClockRate.Location = new System.Drawing.Point(6, 109);
            this.cbIFace2ClockRate.Name = "cbIFace2ClockRate";
            this.cbIFace2ClockRate.Size = new System.Drawing.Size(79, 17);
            this.cbIFace2ClockRate.TabIndex = 15;
            this.cbIFace2ClockRate.Text = "Clock Rate";
            this.cbIFace2ClockRate.UseVisualStyleBackColor = true;
            // 
            // tbIFace2ClockRate
            // 
            this.tbIFace2ClockRate.Location = new System.Drawing.Point(86, 109);
            this.tbIFace2ClockRate.Name = "tbIFace2ClockRate";
            this.tbIFace2ClockRate.Size = new System.Drawing.Size(107, 20);
            this.tbIFace2ClockRate.TabIndex = 14;
            this.tbIFace2ClockRate.Text = "64000";
            // 
            // cbIface2Name
            // 
            this.cbIface2Name.AutoSize = true;
            this.cbIface2Name.Location = new System.Drawing.Point(6, 14);
            this.cbIface2Name.Name = "cbIface2Name";
            this.cbIface2Name.Size = new System.Drawing.Size(54, 17);
            this.cbIface2Name.TabIndex = 11;
            this.cbIface2Name.Text = "Name";
            this.cbIface2Name.UseVisualStyleBackColor = true;
            // 
            // tbIface2Name
            // 
            this.tbIface2Name.Location = new System.Drawing.Point(86, 14);
            this.tbIface2Name.Name = "tbIface2Name";
            this.tbIface2Name.Size = new System.Drawing.Size(107, 20);
            this.tbIface2Name.TabIndex = 10;
            this.tbIface2Name.Text = "fa0/0";
            // 
            // cbIface2Shut
            // 
            this.cbIface2Shut.AutoSize = true;
            this.cbIface2Shut.Location = new System.Drawing.Point(6, 86);
            this.cbIface2Shut.Name = "cbIface2Shut";
            this.cbIface2Shut.Size = new System.Drawing.Size(104, 17);
            this.cbIface2Shut.TabIndex = 9;
            this.cbIface2Shut.Text = "Starts Shutdown";
            this.cbIface2Shut.UseVisualStyleBackColor = true;
            // 
            // cbIface2IP
            // 
            this.cbIface2IP.AutoSize = true;
            this.cbIface2IP.Location = new System.Drawing.Point(6, 37);
            this.cbIface2IP.Name = "cbIface2IP";
            this.cbIface2IP.Size = new System.Drawing.Size(36, 17);
            this.cbIface2IP.TabIndex = 7;
            this.cbIface2IP.Text = "IP";
            this.cbIface2IP.UseVisualStyleBackColor = true;
            // 
            // tbIface2Netmask
            // 
            this.tbIface2Netmask.Location = new System.Drawing.Point(86, 63);
            this.tbIface2Netmask.Name = "tbIface2Netmask";
            this.tbIface2Netmask.Size = new System.Drawing.Size(107, 20);
            this.tbIface2Netmask.TabIndex = 6;
            this.tbIface2Netmask.Text = "255.255.255.255";
            // 
            // tbIface2IP
            // 
            this.tbIface2IP.Location = new System.Drawing.Point(86, 37);
            this.tbIface2IP.Name = "tbIface2IP";
            this.tbIface2IP.Size = new System.Drawing.Size(107, 20);
            this.tbIface2IP.TabIndex = 5;
            this.tbIface2IP.Text = "0.0.0.0";
            // 
            // gbIface1
            // 
            this.gbIface1.Controls.Add(this.cbDHCPHelperAddress1);
            this.gbIface1.Controls.Add(this.tbDHCPHelperAddress1);
            this.gbIface1.Controls.Add(this.cbIFace1ClockRate);
            this.gbIface1.Controls.Add(this.tbIFace1ClockRate);
            this.gbIface1.Controls.Add(this.cbIface1Name);
            this.gbIface1.Controls.Add(this.tbIface1Name);
            this.gbIface1.Controls.Add(this.cbIface1Shut);
            this.gbIface1.Controls.Add(this.cbIface1IP);
            this.gbIface1.Controls.Add(this.tbIface1Netmask);
            this.gbIface1.Controls.Add(this.tbIface1IP);
            this.gbIface1.Location = new System.Drawing.Point(8, 29);
            this.gbIface1.Name = "gbIface1";
            this.gbIface1.Size = new System.Drawing.Size(214, 170);
            this.gbIface1.TabIndex = 15;
            this.gbIface1.TabStop = false;
            this.gbIface1.Text = "Interface 1";
            // 
            // cbDHCPHelperAddress1
            // 
            this.cbDHCPHelperAddress1.AutoSize = true;
            this.cbDHCPHelperAddress1.Location = new System.Drawing.Point(6, 132);
            this.cbDHCPHelperAddress1.Name = "cbDHCPHelperAddress1";
            this.cbDHCPHelperAddress1.Size = new System.Drawing.Size(82, 17);
            this.cbDHCPHelperAddress1.TabIndex = 15;
            this.cbDHCPHelperAddress1.Text = "Helper Addr";
            this.cbDHCPHelperAddress1.UseVisualStyleBackColor = true;
            // 
            // tbDHCPHelperAddress1
            // 
            this.tbDHCPHelperAddress1.Location = new System.Drawing.Point(86, 132);
            this.tbDHCPHelperAddress1.Name = "tbDHCPHelperAddress1";
            this.tbDHCPHelperAddress1.Size = new System.Drawing.Size(107, 20);
            this.tbDHCPHelperAddress1.TabIndex = 14;
            this.tbDHCPHelperAddress1.Text = "For DHCP";
            // 
            // cbIFace1ClockRate
            // 
            this.cbIFace1ClockRate.AutoSize = true;
            this.cbIFace1ClockRate.Location = new System.Drawing.Point(6, 109);
            this.cbIFace1ClockRate.Name = "cbIFace1ClockRate";
            this.cbIFace1ClockRate.Size = new System.Drawing.Size(79, 17);
            this.cbIFace1ClockRate.TabIndex = 13;
            this.cbIFace1ClockRate.Text = "Clock Rate";
            this.cbIFace1ClockRate.UseVisualStyleBackColor = true;
            // 
            // tbIFace1ClockRate
            // 
            this.tbIFace1ClockRate.Location = new System.Drawing.Point(86, 109);
            this.tbIFace1ClockRate.Name = "tbIFace1ClockRate";
            this.tbIFace1ClockRate.Size = new System.Drawing.Size(107, 20);
            this.tbIFace1ClockRate.TabIndex = 12;
            this.tbIFace1ClockRate.Text = "64000";
            // 
            // cbIface1Name
            // 
            this.cbIface1Name.AutoSize = true;
            this.cbIface1Name.Location = new System.Drawing.Point(6, 14);
            this.cbIface1Name.Name = "cbIface1Name";
            this.cbIface1Name.Size = new System.Drawing.Size(54, 17);
            this.cbIface1Name.TabIndex = 11;
            this.cbIface1Name.Text = "Name";
            this.cbIface1Name.UseVisualStyleBackColor = true;
            // 
            // tbIface1Name
            // 
            this.tbIface1Name.Location = new System.Drawing.Point(86, 14);
            this.tbIface1Name.Name = "tbIface1Name";
            this.tbIface1Name.Size = new System.Drawing.Size(107, 20);
            this.tbIface1Name.TabIndex = 10;
            this.tbIface1Name.Text = "fa0/0";
            // 
            // cbIface1Shut
            // 
            this.cbIface1Shut.AutoSize = true;
            this.cbIface1Shut.Location = new System.Drawing.Point(6, 86);
            this.cbIface1Shut.Name = "cbIface1Shut";
            this.cbIface1Shut.Size = new System.Drawing.Size(104, 17);
            this.cbIface1Shut.TabIndex = 9;
            this.cbIface1Shut.Text = "Starts Shutdown";
            this.cbIface1Shut.UseVisualStyleBackColor = true;
            // 
            // cbIface1IP
            // 
            this.cbIface1IP.AutoSize = true;
            this.cbIface1IP.Location = new System.Drawing.Point(6, 37);
            this.cbIface1IP.Name = "cbIface1IP";
            this.cbIface1IP.Size = new System.Drawing.Size(36, 17);
            this.cbIface1IP.TabIndex = 7;
            this.cbIface1IP.Text = "IP";
            this.cbIface1IP.UseVisualStyleBackColor = true;
            // 
            // tbIface1Netmask
            // 
            this.tbIface1Netmask.Location = new System.Drawing.Point(86, 63);
            this.tbIface1Netmask.Name = "tbIface1Netmask";
            this.tbIface1Netmask.Size = new System.Drawing.Size(107, 20);
            this.tbIface1Netmask.TabIndex = 6;
            this.tbIface1Netmask.Text = "255.255.255.255";
            // 
            // tbIface1IP
            // 
            this.tbIface1IP.Location = new System.Drawing.Point(86, 37);
            this.tbIface1IP.Name = "tbIface1IP";
            this.tbIface1IP.Size = new System.Drawing.Size(107, 20);
            this.tbIface1IP.TabIndex = 5;
            this.tbIface1IP.Text = "0.0.0.0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbWriteVlan);
            this.tabPage2.Controls.Add(this.gbAssignVlan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vlans";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbWriteVlan
            // 
            this.cbWriteVlan.AutoSize = true;
            this.cbWriteVlan.Location = new System.Drawing.Point(9, 6);
            this.cbWriteVlan.Name = "cbWriteVlan";
            this.cbWriteVlan.Size = new System.Drawing.Size(80, 17);
            this.cbWriteVlan.TabIndex = 18;
            this.cbWriteVlan.Text = "Write Vlans";
            this.cbWriteVlan.UseVisualStyleBackColor = true;
            // 
            // gbAssignVlan
            // 
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName7);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface7);
            this.gbAssignVlan.Controls.Add(this.tbVlanName7);
            this.gbAssignVlan.Controls.Add(this.tbVlanID7);
            this.gbAssignVlan.Controls.Add(this.cbVlan7);
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName6);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface6);
            this.gbAssignVlan.Controls.Add(this.tbVlanName6);
            this.gbAssignVlan.Controls.Add(this.tbVlanID6);
            this.gbAssignVlan.Controls.Add(this.cbVlan6);
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName5);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface5);
            this.gbAssignVlan.Controls.Add(this.tbVlanName5);
            this.gbAssignVlan.Controls.Add(this.tbVlanID5);
            this.gbAssignVlan.Controls.Add(this.cbVlan5);
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName4);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface4);
            this.gbAssignVlan.Controls.Add(this.tbVlanName4);
            this.gbAssignVlan.Controls.Add(this.tbVlanID4);
            this.gbAssignVlan.Controls.Add(this.cbVlan4);
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName3);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface3);
            this.gbAssignVlan.Controls.Add(this.tbVlanName3);
            this.gbAssignVlan.Controls.Add(this.tbVlanID3);
            this.gbAssignVlan.Controls.Add(this.cbVlan3);
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName2);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface2);
            this.gbAssignVlan.Controls.Add(this.tbVlanName2);
            this.gbAssignVlan.Controls.Add(this.tbVlanID2);
            this.gbAssignVlan.Controls.Add(this.cbVlan2);
            this.gbAssignVlan.Controls.Add(this.tbInterfaceName1);
            this.gbAssignVlan.Controls.Add(this.cbAssignToInterface1);
            this.gbAssignVlan.Controls.Add(this.tbVlanName1);
            this.gbAssignVlan.Controls.Add(this.tbVlanID1);
            this.gbAssignVlan.Controls.Add(this.cbVlan1);
            this.gbAssignVlan.Location = new System.Drawing.Point(3, 26);
            this.gbAssignVlan.Name = "gbAssignVlan";
            this.gbAssignVlan.Size = new System.Drawing.Size(439, 188);
            this.gbAssignVlan.TabIndex = 0;
            this.gbAssignVlan.TabStop = false;
            this.gbAssignVlan.Text = "Assign";
            // 
            // tbInterfaceName7
            // 
            this.tbInterfaceName7.Location = new System.Drawing.Point(308, 155);
            this.tbInterfaceName7.Name = "tbInterfaceName7";
            this.tbInterfaceName7.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName7.TabIndex = 42;
            this.tbInterfaceName7.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface7
            // 
            this.cbAssignToInterface7.AutoSize = true;
            this.cbAssignToInterface7.Location = new System.Drawing.Point(229, 157);
            this.cbAssignToInterface7.Name = "cbAssignToInterface7";
            this.cbAssignToInterface7.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface7.TabIndex = 41;
            this.cbAssignToInterface7.Text = "Assign To";
            this.cbAssignToInterface7.UseVisualStyleBackColor = true;
            // 
            // tbVlanName7
            // 
            this.tbVlanName7.Location = new System.Drawing.Point(108, 155);
            this.tbVlanName7.Name = "tbVlanName7";
            this.tbVlanName7.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName7.TabIndex = 40;
            this.tbVlanName7.Text = "name";
            // 
            // tbVlanID7
            // 
            this.tbVlanID7.Location = new System.Drawing.Point(58, 155);
            this.tbVlanID7.Name = "tbVlanID7";
            this.tbVlanID7.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID7.TabIndex = 39;
            this.tbVlanID7.Text = "70";
            // 
            // cbVlan7
            // 
            this.cbVlan7.AutoSize = true;
            this.cbVlan7.Location = new System.Drawing.Point(5, 157);
            this.cbVlan7.Name = "cbVlan7";
            this.cbVlan7.Size = new System.Drawing.Size(47, 17);
            this.cbVlan7.TabIndex = 38;
            this.cbVlan7.Text = "Vlan";
            this.cbVlan7.UseVisualStyleBackColor = true;
            // 
            // tbInterfaceName6
            // 
            this.tbInterfaceName6.Location = new System.Drawing.Point(308, 132);
            this.tbInterfaceName6.Name = "tbInterfaceName6";
            this.tbInterfaceName6.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName6.TabIndex = 37;
            this.tbInterfaceName6.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface6
            // 
            this.cbAssignToInterface6.AutoSize = true;
            this.cbAssignToInterface6.Location = new System.Drawing.Point(229, 134);
            this.cbAssignToInterface6.Name = "cbAssignToInterface6";
            this.cbAssignToInterface6.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface6.TabIndex = 36;
            this.cbAssignToInterface6.Text = "Assign To";
            this.cbAssignToInterface6.UseVisualStyleBackColor = true;
            // 
            // tbVlanName6
            // 
            this.tbVlanName6.Location = new System.Drawing.Point(108, 132);
            this.tbVlanName6.Name = "tbVlanName6";
            this.tbVlanName6.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName6.TabIndex = 35;
            this.tbVlanName6.Text = "name";
            // 
            // tbVlanID6
            // 
            this.tbVlanID6.Location = new System.Drawing.Point(58, 132);
            this.tbVlanID6.Name = "tbVlanID6";
            this.tbVlanID6.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID6.TabIndex = 34;
            this.tbVlanID6.Text = "60";
            // 
            // cbVlan6
            // 
            this.cbVlan6.AutoSize = true;
            this.cbVlan6.Location = new System.Drawing.Point(5, 134);
            this.cbVlan6.Name = "cbVlan6";
            this.cbVlan6.Size = new System.Drawing.Size(47, 17);
            this.cbVlan6.TabIndex = 33;
            this.cbVlan6.Text = "Vlan";
            this.cbVlan6.UseVisualStyleBackColor = true;
            // 
            // tbInterfaceName5
            // 
            this.tbInterfaceName5.Location = new System.Drawing.Point(309, 109);
            this.tbInterfaceName5.Name = "tbInterfaceName5";
            this.tbInterfaceName5.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName5.TabIndex = 32;
            this.tbInterfaceName5.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface5
            // 
            this.cbAssignToInterface5.AutoSize = true;
            this.cbAssignToInterface5.Location = new System.Drawing.Point(230, 111);
            this.cbAssignToInterface5.Name = "cbAssignToInterface5";
            this.cbAssignToInterface5.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface5.TabIndex = 31;
            this.cbAssignToInterface5.Text = "Assign To";
            this.cbAssignToInterface5.UseVisualStyleBackColor = true;
            // 
            // tbVlanName5
            // 
            this.tbVlanName5.Location = new System.Drawing.Point(109, 109);
            this.tbVlanName5.Name = "tbVlanName5";
            this.tbVlanName5.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName5.TabIndex = 30;
            this.tbVlanName5.Text = "name";
            // 
            // tbVlanID5
            // 
            this.tbVlanID5.Location = new System.Drawing.Point(59, 109);
            this.tbVlanID5.Name = "tbVlanID5";
            this.tbVlanID5.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID5.TabIndex = 29;
            this.tbVlanID5.Text = "50";
            // 
            // cbVlan5
            // 
            this.cbVlan5.AutoSize = true;
            this.cbVlan5.Location = new System.Drawing.Point(6, 111);
            this.cbVlan5.Name = "cbVlan5";
            this.cbVlan5.Size = new System.Drawing.Size(47, 17);
            this.cbVlan5.TabIndex = 28;
            this.cbVlan5.Text = "Vlan";
            this.cbVlan5.UseVisualStyleBackColor = true;
            // 
            // tbInterfaceName4
            // 
            this.tbInterfaceName4.Location = new System.Drawing.Point(309, 86);
            this.tbInterfaceName4.Name = "tbInterfaceName4";
            this.tbInterfaceName4.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName4.TabIndex = 27;
            this.tbInterfaceName4.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface4
            // 
            this.cbAssignToInterface4.AutoSize = true;
            this.cbAssignToInterface4.Location = new System.Drawing.Point(230, 88);
            this.cbAssignToInterface4.Name = "cbAssignToInterface4";
            this.cbAssignToInterface4.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface4.TabIndex = 26;
            this.cbAssignToInterface4.Text = "Assign To";
            this.cbAssignToInterface4.UseVisualStyleBackColor = true;
            // 
            // tbVlanName4
            // 
            this.tbVlanName4.Location = new System.Drawing.Point(109, 86);
            this.tbVlanName4.Name = "tbVlanName4";
            this.tbVlanName4.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName4.TabIndex = 25;
            this.tbVlanName4.Text = "name";
            // 
            // tbVlanID4
            // 
            this.tbVlanID4.Location = new System.Drawing.Point(59, 86);
            this.tbVlanID4.Name = "tbVlanID4";
            this.tbVlanID4.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID4.TabIndex = 24;
            this.tbVlanID4.Text = "40";
            // 
            // cbVlan4
            // 
            this.cbVlan4.AutoSize = true;
            this.cbVlan4.Location = new System.Drawing.Point(6, 88);
            this.cbVlan4.Name = "cbVlan4";
            this.cbVlan4.Size = new System.Drawing.Size(47, 17);
            this.cbVlan4.TabIndex = 23;
            this.cbVlan4.Text = "Vlan";
            this.cbVlan4.UseVisualStyleBackColor = true;
            // 
            // tbInterfaceName3
            // 
            this.tbInterfaceName3.Location = new System.Drawing.Point(309, 63);
            this.tbInterfaceName3.Name = "tbInterfaceName3";
            this.tbInterfaceName3.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName3.TabIndex = 22;
            this.tbInterfaceName3.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface3
            // 
            this.cbAssignToInterface3.AutoSize = true;
            this.cbAssignToInterface3.Location = new System.Drawing.Point(230, 65);
            this.cbAssignToInterface3.Name = "cbAssignToInterface3";
            this.cbAssignToInterface3.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface3.TabIndex = 21;
            this.cbAssignToInterface3.Text = "Assign To";
            this.cbAssignToInterface3.UseVisualStyleBackColor = true;
            // 
            // tbVlanName3
            // 
            this.tbVlanName3.Location = new System.Drawing.Point(109, 63);
            this.tbVlanName3.Name = "tbVlanName3";
            this.tbVlanName3.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName3.TabIndex = 20;
            this.tbVlanName3.Text = "name";
            // 
            // tbVlanID3
            // 
            this.tbVlanID3.Location = new System.Drawing.Point(59, 63);
            this.tbVlanID3.Name = "tbVlanID3";
            this.tbVlanID3.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID3.TabIndex = 19;
            this.tbVlanID3.Text = "30";
            // 
            // cbVlan3
            // 
            this.cbVlan3.AutoSize = true;
            this.cbVlan3.Location = new System.Drawing.Point(6, 65);
            this.cbVlan3.Name = "cbVlan3";
            this.cbVlan3.Size = new System.Drawing.Size(47, 17);
            this.cbVlan3.TabIndex = 18;
            this.cbVlan3.Text = "Vlan";
            this.cbVlan3.UseVisualStyleBackColor = true;
            // 
            // tbInterfaceName2
            // 
            this.tbInterfaceName2.Location = new System.Drawing.Point(309, 40);
            this.tbInterfaceName2.Name = "tbInterfaceName2";
            this.tbInterfaceName2.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName2.TabIndex = 17;
            this.tbInterfaceName2.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface2
            // 
            this.cbAssignToInterface2.AutoSize = true;
            this.cbAssignToInterface2.Location = new System.Drawing.Point(230, 42);
            this.cbAssignToInterface2.Name = "cbAssignToInterface2";
            this.cbAssignToInterface2.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface2.TabIndex = 16;
            this.cbAssignToInterface2.Text = "Assign To";
            this.cbAssignToInterface2.UseVisualStyleBackColor = true;
            // 
            // tbVlanName2
            // 
            this.tbVlanName2.Location = new System.Drawing.Point(109, 40);
            this.tbVlanName2.Name = "tbVlanName2";
            this.tbVlanName2.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName2.TabIndex = 15;
            this.tbVlanName2.Text = "name";
            // 
            // tbVlanID2
            // 
            this.tbVlanID2.Location = new System.Drawing.Point(59, 40);
            this.tbVlanID2.Name = "tbVlanID2";
            this.tbVlanID2.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID2.TabIndex = 14;
            this.tbVlanID2.Text = "20";
            // 
            // cbVlan2
            // 
            this.cbVlan2.AutoSize = true;
            this.cbVlan2.Location = new System.Drawing.Point(6, 42);
            this.cbVlan2.Name = "cbVlan2";
            this.cbVlan2.Size = new System.Drawing.Size(47, 17);
            this.cbVlan2.TabIndex = 13;
            this.cbVlan2.Text = "Vlan";
            this.cbVlan2.UseVisualStyleBackColor = true;
            // 
            // tbInterfaceName1
            // 
            this.tbInterfaceName1.Location = new System.Drawing.Point(309, 17);
            this.tbInterfaceName1.Name = "tbInterfaceName1";
            this.tbInterfaceName1.Size = new System.Drawing.Size(124, 20);
            this.tbInterfaceName1.TabIndex = 12;
            this.tbInterfaceName1.Text = "range fa0/1-24";
            // 
            // cbAssignToInterface1
            // 
            this.cbAssignToInterface1.AutoSize = true;
            this.cbAssignToInterface1.Location = new System.Drawing.Point(230, 19);
            this.cbAssignToInterface1.Name = "cbAssignToInterface1";
            this.cbAssignToInterface1.Size = new System.Drawing.Size(73, 17);
            this.cbAssignToInterface1.TabIndex = 11;
            this.cbAssignToInterface1.Text = "Assign To";
            this.cbAssignToInterface1.UseVisualStyleBackColor = true;
            // 
            // tbVlanName1
            // 
            this.tbVlanName1.Location = new System.Drawing.Point(109, 17);
            this.tbVlanName1.Name = "tbVlanName1";
            this.tbVlanName1.Size = new System.Drawing.Size(115, 20);
            this.tbVlanName1.TabIndex = 10;
            this.tbVlanName1.Text = "name";
            // 
            // tbVlanID1
            // 
            this.tbVlanID1.Location = new System.Drawing.Point(59, 17);
            this.tbVlanID1.Name = "tbVlanID1";
            this.tbVlanID1.Size = new System.Drawing.Size(44, 20);
            this.tbVlanID1.TabIndex = 9;
            this.tbVlanID1.Text = "10";
            // 
            // cbVlan1
            // 
            this.cbVlan1.AutoSize = true;
            this.cbVlan1.Location = new System.Drawing.Point(6, 19);
            this.cbVlan1.Name = "cbVlan1";
            this.cbVlan1.Size = new System.Drawing.Size(47, 17);
            this.cbVlan1.TabIndex = 8;
            this.cbVlan1.Text = "Vlan";
            this.cbVlan1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbWriteSwitchCommands);
            this.tabPage3.Controls.Add(this.gbTrunking);
            this.tabPage3.Controls.Add(this.gbManagementInterface);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(448, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Switch Commands";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbWriteSwitchCommands
            // 
            this.cbWriteSwitchCommands.AutoSize = true;
            this.cbWriteSwitchCommands.Location = new System.Drawing.Point(3, 3);
            this.cbWriteSwitchCommands.Name = "cbWriteSwitchCommands";
            this.cbWriteSwitchCommands.Size = new System.Drawing.Size(141, 17);
            this.cbWriteSwitchCommands.TabIndex = 47;
            this.cbWriteSwitchCommands.Text = "Write Switch Commands";
            this.cbWriteSwitchCommands.UseVisualStyleBackColor = true;
            // 
            // gbTrunking
            // 
            this.gbTrunking.Controls.Add(this.lblTrunkInterface);
            this.gbTrunking.Controls.Add(this.tbTrunkInterface);
            this.gbTrunking.Controls.Add(this.tbTrunkingNativeVlan);
            this.gbTrunking.Controls.Add(this.cbTrunking);
            this.gbTrunking.Location = new System.Drawing.Point(3, 79);
            this.gbTrunking.Name = "gbTrunking";
            this.gbTrunking.Size = new System.Drawing.Size(439, 47);
            this.gbTrunking.TabIndex = 46;
            this.gbTrunking.TabStop = false;
            this.gbTrunking.Text = "Trunking";
            // 
            // lblTrunkInterface
            // 
            this.lblTrunkInterface.AutoSize = true;
            this.lblTrunkInterface.Location = new System.Drawing.Point(127, 19);
            this.lblTrunkInterface.Name = "lblTrunkInterface";
            this.lblTrunkInterface.Size = new System.Drawing.Size(80, 13);
            this.lblTrunkInterface.TabIndex = 46;
            this.lblTrunkInterface.Text = "Trunk Interface";
            // 
            // tbTrunkInterface
            // 
            this.tbTrunkInterface.Location = new System.Drawing.Point(230, 16);
            this.tbTrunkInterface.Name = "tbTrunkInterface";
            this.tbTrunkInterface.Size = new System.Drawing.Size(186, 20);
            this.tbTrunkInterface.TabIndex = 44;
            this.tbTrunkInterface.Text = "f0/24";
            // 
            // tbTrunkingNativeVlan
            // 
            this.tbTrunkingNativeVlan.Location = new System.Drawing.Point(59, 17);
            this.tbTrunkingNativeVlan.Name = "tbTrunkingNativeVlan";
            this.tbTrunkingNativeVlan.Size = new System.Drawing.Size(44, 20);
            this.tbTrunkingNativeVlan.TabIndex = 42;
            this.tbTrunkingNativeVlan.Text = "99";
            // 
            // cbTrunking
            // 
            this.cbTrunking.AutoSize = true;
            this.cbTrunking.Location = new System.Drawing.Point(6, 19);
            this.cbTrunking.Name = "cbTrunking";
            this.cbTrunking.Size = new System.Drawing.Size(54, 17);
            this.cbTrunking.TabIndex = 41;
            this.cbTrunking.Text = "Trunk";
            this.cbTrunking.UseVisualStyleBackColor = true;
            // 
            // gbManagementInterface
            // 
            this.gbManagementInterface.Controls.Add(this.tbManagementNetmask);
            this.gbManagementInterface.Controls.Add(this.tbManagementIP);
            this.gbManagementInterface.Controls.Add(this.tbManagementVlanName);
            this.gbManagementInterface.Controls.Add(this.tbManagementVlanID);
            this.gbManagementInterface.Controls.Add(this.cbManagementVlan);
            this.gbManagementInterface.Location = new System.Drawing.Point(3, 26);
            this.gbManagementInterface.Name = "gbManagementInterface";
            this.gbManagementInterface.Size = new System.Drawing.Size(439, 47);
            this.gbManagementInterface.TabIndex = 0;
            this.gbManagementInterface.TabStop = false;
            this.gbManagementInterface.Text = "Management Interface";
            // 
            // tbManagementNetmask
            // 
            this.tbManagementNetmask.Location = new System.Drawing.Point(326, 17);
            this.tbManagementNetmask.Name = "tbManagementNetmask";
            this.tbManagementNetmask.Size = new System.Drawing.Size(90, 20);
            this.tbManagementNetmask.TabIndex = 45;
            this.tbManagementNetmask.Text = "255.255.255.255";
            // 
            // tbManagementIP
            // 
            this.tbManagementIP.Location = new System.Drawing.Point(230, 16);
            this.tbManagementIP.Name = "tbManagementIP";
            this.tbManagementIP.Size = new System.Drawing.Size(90, 20);
            this.tbManagementIP.TabIndex = 44;
            this.tbManagementIP.Text = "0.0.0.0";
            // 
            // tbManagementVlanName
            // 
            this.tbManagementVlanName.Location = new System.Drawing.Point(109, 17);
            this.tbManagementVlanName.Name = "tbManagementVlanName";
            this.tbManagementVlanName.Size = new System.Drawing.Size(115, 20);
            this.tbManagementVlanName.TabIndex = 43;
            this.tbManagementVlanName.Text = "management";
            // 
            // tbManagementVlanID
            // 
            this.tbManagementVlanID.Location = new System.Drawing.Point(59, 17);
            this.tbManagementVlanID.Name = "tbManagementVlanID";
            this.tbManagementVlanID.Size = new System.Drawing.Size(44, 20);
            this.tbManagementVlanID.TabIndex = 42;
            this.tbManagementVlanID.Text = "99";
            // 
            // cbManagementVlan
            // 
            this.cbManagementVlan.AutoSize = true;
            this.cbManagementVlan.Location = new System.Drawing.Point(6, 19);
            this.cbManagementVlan.Name = "cbManagementVlan";
            this.cbManagementVlan.Size = new System.Drawing.Size(47, 17);
            this.cbManagementVlan.TabIndex = 41;
            this.cbManagementVlan.Text = "Vlan";
            this.cbManagementVlan.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbWriteEIGRP);
            this.tabPage4.Controls.Add(this.gbEIGRP);
            this.tabPage4.Controls.Add(this.cbWriteOSPF);
            this.tabPage4.Controls.Add(this.gbOSPF);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(448, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Routing Protocols";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbWriteEIGRP
            // 
            this.cbWriteEIGRP.AutoSize = true;
            this.cbWriteEIGRP.Location = new System.Drawing.Point(13, 131);
            this.cbWriteEIGRP.Name = "cbWriteEIGRP";
            this.cbWriteEIGRP.Size = new System.Drawing.Size(87, 17);
            this.cbWriteEIGRP.TabIndex = 19;
            this.cbWriteEIGRP.Text = "Write EIGRP";
            this.cbWriteEIGRP.UseVisualStyleBackColor = true;
            // 
            // gbEIGRP
            // 
            this.gbEIGRP.Controls.Add(this.cbEIGRPNetwork2);
            this.gbEIGRP.Controls.Add(this.tbEIGRPNetworkID2);
            this.gbEIGRP.Controls.Add(this.cbEIGRPNetwork1);
            this.gbEIGRP.Controls.Add(this.tbEIGRPNetworkID1);
            this.gbEIGRP.Controls.Add(this.cbEIGRPID);
            this.gbEIGRP.Controls.Add(this.tbEIGRPAreaID);
            this.gbEIGRP.Location = new System.Drawing.Point(7, 154);
            this.gbEIGRP.Name = "gbEIGRP";
            this.gbEIGRP.Size = new System.Drawing.Size(214, 99);
            this.gbEIGRP.TabIndex = 18;
            this.gbEIGRP.TabStop = false;
            this.gbEIGRP.Text = "EIGRP";
            // 
            // cbEIGRPNetwork2
            // 
            this.cbEIGRPNetwork2.AutoSize = true;
            this.cbEIGRPNetwork2.Location = new System.Drawing.Point(6, 68);
            this.cbEIGRPNetwork2.Name = "cbEIGRPNetwork2";
            this.cbEIGRPNetwork2.Size = new System.Drawing.Size(64, 17);
            this.cbEIGRPNetwork2.TabIndex = 15;
            this.cbEIGRPNetwork2.Text = "network";
            this.cbEIGRPNetwork2.UseVisualStyleBackColor = true;
            // 
            // tbEIGRPNetworkID2
            // 
            this.tbEIGRPNetworkID2.Location = new System.Drawing.Point(86, 68);
            this.tbEIGRPNetworkID2.Name = "tbEIGRPNetworkID2";
            this.tbEIGRPNetworkID2.Size = new System.Drawing.Size(107, 20);
            this.tbEIGRPNetworkID2.TabIndex = 14;
            this.tbEIGRPNetworkID2.Text = "Network ID";
            // 
            // cbEIGRPNetwork1
            // 
            this.cbEIGRPNetwork1.AutoSize = true;
            this.cbEIGRPNetwork1.Location = new System.Drawing.Point(6, 45);
            this.cbEIGRPNetwork1.Name = "cbEIGRPNetwork1";
            this.cbEIGRPNetwork1.Size = new System.Drawing.Size(64, 17);
            this.cbEIGRPNetwork1.TabIndex = 12;
            this.cbEIGRPNetwork1.Text = "network";
            this.cbEIGRPNetwork1.UseVisualStyleBackColor = true;
            // 
            // tbEIGRPNetworkID1
            // 
            this.tbEIGRPNetworkID1.Location = new System.Drawing.Point(86, 45);
            this.tbEIGRPNetworkID1.Name = "tbEIGRPNetworkID1";
            this.tbEIGRPNetworkID1.Size = new System.Drawing.Size(107, 20);
            this.tbEIGRPNetworkID1.TabIndex = 11;
            this.tbEIGRPNetworkID1.Text = "Network ID";
            // 
            // cbEIGRPID
            // 
            this.cbEIGRPID.AutoSize = true;
            this.cbEIGRPID.Location = new System.Drawing.Point(6, 19);
            this.cbEIGRPID.Name = "cbEIGRPID";
            this.cbEIGRPID.Size = new System.Drawing.Size(62, 17);
            this.cbEIGRPID.TabIndex = 7;
            this.cbEIGRPID.Text = "Area ID";
            this.cbEIGRPID.UseVisualStyleBackColor = true;
            // 
            // tbEIGRPAreaID
            // 
            this.tbEIGRPAreaID.Location = new System.Drawing.Point(86, 19);
            this.tbEIGRPAreaID.Name = "tbEIGRPAreaID";
            this.tbEIGRPAreaID.Size = new System.Drawing.Size(107, 20);
            this.tbEIGRPAreaID.TabIndex = 5;
            this.tbEIGRPAreaID.Text = "0";
            // 
            // cbWriteOSPF
            // 
            this.cbWriteOSPF.AutoSize = true;
            this.cbWriteOSPF.Location = new System.Drawing.Point(13, 3);
            this.cbWriteOSPF.Name = "cbWriteOSPF";
            this.cbWriteOSPF.Size = new System.Drawing.Size(82, 17);
            this.cbWriteOSPF.TabIndex = 16;
            this.cbWriteOSPF.Text = "Write OSPF";
            this.cbWriteOSPF.UseVisualStyleBackColor = true;
            // 
            // gbOSPF
            // 
            this.gbOSPF.Controls.Add(this.cbOSPFNetworkID2);
            this.gbOSPF.Controls.Add(this.tbOSPFNetworkID2);
            this.gbOSPF.Controls.Add(this.tbOSPFInvMask2);
            this.gbOSPF.Controls.Add(this.cbOSPFNetworkID1);
            this.gbOSPF.Controls.Add(this.tbOSPFNetworkID1);
            this.gbOSPF.Controls.Add(this.cbOSPFID);
            this.gbOSPF.Controls.Add(this.tbOSPFInvMask1);
            this.gbOSPF.Controls.Add(this.tbOSPFAreaID);
            this.gbOSPF.Enabled = false;
            this.gbOSPF.Location = new System.Drawing.Point(13, 26);
            this.gbOSPF.Name = "gbOSPF";
            this.gbOSPF.Size = new System.Drawing.Size(384, 99);
            this.gbOSPF.TabIndex = 15;
            this.gbOSPF.TabStop = false;
            this.gbOSPF.Text = "OSPF";
            // 
            // cbOSPFNetworkID2
            // 
            this.cbOSPFNetworkID2.AutoSize = true;
            this.cbOSPFNetworkID2.Location = new System.Drawing.Point(188, 45);
            this.cbOSPFNetworkID2.Name = "cbOSPFNetworkID2";
            this.cbOSPFNetworkID2.Size = new System.Drawing.Size(64, 17);
            this.cbOSPFNetworkID2.TabIndex = 15;
            this.cbOSPFNetworkID2.Text = "network";
            this.cbOSPFNetworkID2.UseVisualStyleBackColor = true;
            // 
            // tbOSPFNetworkID2
            // 
            this.tbOSPFNetworkID2.Location = new System.Drawing.Point(268, 45);
            this.tbOSPFNetworkID2.Name = "tbOSPFNetworkID2";
            this.tbOSPFNetworkID2.Size = new System.Drawing.Size(107, 20);
            this.tbOSPFNetworkID2.TabIndex = 14;
            this.tbOSPFNetworkID2.Text = "Network ID";
            // 
            // tbOSPFInvMask2
            // 
            this.tbOSPFInvMask2.Location = new System.Drawing.Point(268, 71);
            this.tbOSPFInvMask2.Name = "tbOSPFInvMask2";
            this.tbOSPFInvMask2.Size = new System.Drawing.Size(107, 20);
            this.tbOSPFInvMask2.TabIndex = 13;
            this.tbOSPFInvMask2.Text = "Inverse Mask";
            // 
            // cbOSPFNetworkID1
            // 
            this.cbOSPFNetworkID1.AutoSize = true;
            this.cbOSPFNetworkID1.Location = new System.Drawing.Point(6, 45);
            this.cbOSPFNetworkID1.Name = "cbOSPFNetworkID1";
            this.cbOSPFNetworkID1.Size = new System.Drawing.Size(64, 17);
            this.cbOSPFNetworkID1.TabIndex = 12;
            this.cbOSPFNetworkID1.Text = "network";
            this.cbOSPFNetworkID1.UseVisualStyleBackColor = true;
            // 
            // tbOSPFNetworkID1
            // 
            this.tbOSPFNetworkID1.Location = new System.Drawing.Point(74, 45);
            this.tbOSPFNetworkID1.Name = "tbOSPFNetworkID1";
            this.tbOSPFNetworkID1.Size = new System.Drawing.Size(107, 20);
            this.tbOSPFNetworkID1.TabIndex = 11;
            this.tbOSPFNetworkID1.Text = "Network ID";
            // 
            // cbOSPFID
            // 
            this.cbOSPFID.AutoSize = true;
            this.cbOSPFID.Location = new System.Drawing.Point(6, 19);
            this.cbOSPFID.Name = "cbOSPFID";
            this.cbOSPFID.Size = new System.Drawing.Size(62, 17);
            this.cbOSPFID.TabIndex = 7;
            this.cbOSPFID.Text = "Area ID";
            this.cbOSPFID.UseVisualStyleBackColor = true;
            // 
            // tbOSPFInvMask1
            // 
            this.tbOSPFInvMask1.Location = new System.Drawing.Point(74, 71);
            this.tbOSPFInvMask1.Name = "tbOSPFInvMask1";
            this.tbOSPFInvMask1.Size = new System.Drawing.Size(107, 20);
            this.tbOSPFInvMask1.TabIndex = 6;
            this.tbOSPFInvMask1.Text = "Inverse Mask";
            // 
            // tbOSPFAreaID
            // 
            this.tbOSPFAreaID.Location = new System.Drawing.Point(74, 19);
            this.tbOSPFAreaID.Name = "tbOSPFAreaID";
            this.tbOSPFAreaID.Size = new System.Drawing.Size(107, 20);
            this.tbOSPFAreaID.TabIndex = 5;
            this.tbOSPFAreaID.Text = "0";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbDHCPConfig);
            this.tabPage5.Controls.Add(this.gbExcludedIPs);
            this.tabPage5.Controls.Add(this.cbWriteDHCP);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(448, 262);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DHCP";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbDHCPConfig
            // 
            this.gbDHCPConfig.Controls.Add(this.tbDHCPDefaultRouter);
            this.gbDHCPConfig.Controls.Add(this.cbDHCPDefaultRouter);
            this.gbDHCPConfig.Controls.Add(this.tbDHCPDnsServer);
            this.gbDHCPConfig.Controls.Add(this.cbDHCPDnsServer);
            this.gbDHCPConfig.Controls.Add(this.tbDHCPNetworkNetmask);
            this.gbDHCPConfig.Controls.Add(this.tbDHCPPool);
            this.gbDHCPConfig.Controls.Add(this.tbDHCPNetworkIP);
            this.gbDHCPConfig.Controls.Add(this.cbDHCPPool);
            this.gbDHCPConfig.Location = new System.Drawing.Point(12, 102);
            this.gbDHCPConfig.Name = "gbDHCPConfig";
            this.gbDHCPConfig.Size = new System.Drawing.Size(316, 140);
            this.gbDHCPConfig.TabIndex = 2;
            this.gbDHCPConfig.TabStop = false;
            this.gbDHCPConfig.Text = "DHCP Config";
            // 
            // tbDHCPDefaultRouter
            // 
            this.tbDHCPDefaultRouter.Location = new System.Drawing.Point(120, 91);
            this.tbDHCPDefaultRouter.Name = "tbDHCPDefaultRouter";
            this.tbDHCPDefaultRouter.Size = new System.Drawing.Size(90, 20);
            this.tbDHCPDefaultRouter.TabIndex = 60;
            this.tbDHCPDefaultRouter.Text = "IP Address";
            // 
            // cbDHCPDefaultRouter
            // 
            this.cbDHCPDefaultRouter.AutoSize = true;
            this.cbDHCPDefaultRouter.Location = new System.Drawing.Point(6, 93);
            this.cbDHCPDefaultRouter.Name = "cbDHCPDefaultRouter";
            this.cbDHCPDefaultRouter.Size = new System.Drawing.Size(95, 17);
            this.cbDHCPDefaultRouter.TabIndex = 59;
            this.cbDHCPDefaultRouter.Text = "Default Router";
            this.cbDHCPDefaultRouter.UseVisualStyleBackColor = true;
            // 
            // tbDHCPDnsServer
            // 
            this.tbDHCPDnsServer.Location = new System.Drawing.Point(120, 68);
            this.tbDHCPDnsServer.Name = "tbDHCPDnsServer";
            this.tbDHCPDnsServer.Size = new System.Drawing.Size(90, 20);
            this.tbDHCPDnsServer.TabIndex = 58;
            this.tbDHCPDnsServer.Text = "IP Address";
            // 
            // cbDHCPDnsServer
            // 
            this.cbDHCPDnsServer.AutoSize = true;
            this.cbDHCPDnsServer.Location = new System.Drawing.Point(6, 70);
            this.cbDHCPDnsServer.Name = "cbDHCPDnsServer";
            this.cbDHCPDnsServer.Size = new System.Drawing.Size(83, 17);
            this.cbDHCPDnsServer.TabIndex = 57;
            this.cbDHCPDnsServer.Text = "DNS Server";
            this.cbDHCPDnsServer.UseVisualStyleBackColor = true;
            // 
            // tbDHCPNetworkNetmask
            // 
            this.tbDHCPNetworkNetmask.Location = new System.Drawing.Point(216, 41);
            this.tbDHCPNetworkNetmask.Name = "tbDHCPNetworkNetmask";
            this.tbDHCPNetworkNetmask.Size = new System.Drawing.Size(90, 20);
            this.tbDHCPNetworkNetmask.TabIndex = 56;
            this.tbDHCPNetworkNetmask.Text = "Netmask";
            // 
            // tbDHCPPool
            // 
            this.tbDHCPPool.Location = new System.Drawing.Point(120, 17);
            this.tbDHCPPool.Name = "tbDHCPPool";
            this.tbDHCPPool.Size = new System.Drawing.Size(90, 20);
            this.tbDHCPPool.TabIndex = 52;
            this.tbDHCPPool.Text = "Pool Name";
            // 
            // tbDHCPNetworkIP
            // 
            this.tbDHCPNetworkIP.Location = new System.Drawing.Point(120, 41);
            this.tbDHCPNetworkIP.Name = "tbDHCPNetworkIP";
            this.tbDHCPNetworkIP.Size = new System.Drawing.Size(90, 20);
            this.tbDHCPNetworkIP.TabIndex = 55;
            this.tbDHCPNetworkIP.Text = "Network ID";
            // 
            // cbDHCPPool
            // 
            this.cbDHCPPool.AutoSize = true;
            this.cbDHCPPool.Location = new System.Drawing.Point(6, 19);
            this.cbDHCPPool.Name = "cbDHCPPool";
            this.cbDHCPPool.Size = new System.Drawing.Size(80, 17);
            this.cbDHCPPool.TabIndex = 51;
            this.cbDHCPPool.Text = "DHCP Pool";
            this.cbDHCPPool.UseVisualStyleBackColor = true;
            // 
            // gbExcludedIPs
            // 
            this.gbExcludedIPs.Controls.Add(this.tbExcludeRangeStop2);
            this.gbExcludedIPs.Controls.Add(this.tbExcludeRangeStart2);
            this.gbExcludedIPs.Controls.Add(this.cbExcludeRange2);
            this.gbExcludedIPs.Controls.Add(this.tbExcludeRangeStop1);
            this.gbExcludedIPs.Controls.Add(this.tbExcludeRangeStart1);
            this.gbExcludedIPs.Controls.Add(this.cbExcludeRange1);
            this.gbExcludedIPs.Location = new System.Drawing.Point(10, 26);
            this.gbExcludedIPs.Name = "gbExcludedIPs";
            this.gbExcludedIPs.Size = new System.Drawing.Size(318, 69);
            this.gbExcludedIPs.TabIndex = 1;
            this.gbExcludedIPs.TabStop = false;
            this.gbExcludedIPs.Text = "Excluded Ranges";
            // 
            // tbExcludeRangeStop2
            // 
            this.tbExcludeRangeStop2.Location = new System.Drawing.Point(218, 40);
            this.tbExcludeRangeStop2.Name = "tbExcludeRangeStop2";
            this.tbExcludeRangeStop2.Size = new System.Drawing.Size(90, 20);
            this.tbExcludeRangeStop2.TabIndex = 54;
            this.tbExcludeRangeStop2.Text = "Ending Address";
            // 
            // tbExcludeRangeStart2
            // 
            this.tbExcludeRangeStart2.Location = new System.Drawing.Point(122, 40);
            this.tbExcludeRangeStart2.Name = "tbExcludeRangeStart2";
            this.tbExcludeRangeStart2.Size = new System.Drawing.Size(90, 20);
            this.tbExcludeRangeStart2.TabIndex = 53;
            this.tbExcludeRangeStart2.Text = "Starting Address";
            // 
            // cbExcludeRange2
            // 
            this.cbExcludeRange2.AutoSize = true;
            this.cbExcludeRange2.Location = new System.Drawing.Point(6, 42);
            this.cbExcludeRange2.Name = "cbExcludeRange2";
            this.cbExcludeRange2.Size = new System.Drawing.Size(110, 17);
            this.cbExcludeRange2.TabIndex = 52;
            this.cbExcludeRange2.Text = "Excluded-address";
            this.cbExcludeRange2.UseVisualStyleBackColor = true;
            // 
            // tbExcludeRangeStop1
            // 
            this.tbExcludeRangeStop1.Location = new System.Drawing.Point(218, 17);
            this.tbExcludeRangeStop1.Name = "tbExcludeRangeStop1";
            this.tbExcludeRangeStop1.Size = new System.Drawing.Size(90, 20);
            this.tbExcludeRangeStop1.TabIndex = 51;
            this.tbExcludeRangeStop1.Text = "Ending Address";
            // 
            // tbExcludeRangeStart1
            // 
            this.tbExcludeRangeStart1.Location = new System.Drawing.Point(122, 17);
            this.tbExcludeRangeStart1.Name = "tbExcludeRangeStart1";
            this.tbExcludeRangeStart1.Size = new System.Drawing.Size(90, 20);
            this.tbExcludeRangeStart1.TabIndex = 50;
            this.tbExcludeRangeStart1.Text = "Starting Address";
            // 
            // cbExcludeRange1
            // 
            this.cbExcludeRange1.AutoSize = true;
            this.cbExcludeRange1.Location = new System.Drawing.Point(6, 19);
            this.cbExcludeRange1.Name = "cbExcludeRange1";
            this.cbExcludeRange1.Size = new System.Drawing.Size(110, 17);
            this.cbExcludeRange1.TabIndex = 49;
            this.cbExcludeRange1.Text = "Excluded-address";
            this.cbExcludeRange1.UseVisualStyleBackColor = true;
            // 
            // cbWriteDHCP
            // 
            this.cbWriteDHCP.AutoSize = true;
            this.cbWriteDHCP.Location = new System.Drawing.Point(6, 3);
            this.cbWriteDHCP.Name = "cbWriteDHCP";
            this.cbWriteDHCP.Size = new System.Drawing.Size(84, 17);
            this.cbWriteDHCP.TabIndex = 0;
            this.cbWriteDHCP.Text = "Write DHCP";
            this.cbWriteDHCP.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.gbNATMapping);
            this.tabPage6.Controls.Add(this.cbWriteNAT);
            this.tabPage6.Controls.Add(this.gbNatInOut);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(448, 262);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "NAT";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // gbNATMapping
            // 
            this.gbNATMapping.Controls.Add(this.tbOutsideNATPublic);
            this.gbNATMapping.Controls.Add(this.tbOutsideNATPrivate);
            this.gbNATMapping.Controls.Add(this.cbOutsideNAT);
            this.gbNATMapping.Controls.Add(this.tbInsideNATPublic);
            this.gbNATMapping.Controls.Add(this.tbInsideNATPrivate);
            this.gbNATMapping.Controls.Add(this.cbInsideNAT);
            this.gbNATMapping.Location = new System.Drawing.Point(6, 104);
            this.gbNATMapping.Name = "gbNATMapping";
            this.gbNATMapping.Size = new System.Drawing.Size(320, 72);
            this.gbNATMapping.TabIndex = 55;
            this.gbNATMapping.TabStop = false;
            this.gbNATMapping.Text = "NAT Mapping";
            // 
            // tbOutsideNATPublic
            // 
            this.tbOutsideNATPublic.Location = new System.Drawing.Point(218, 40);
            this.tbOutsideNATPublic.Name = "tbOutsideNATPublic";
            this.tbOutsideNATPublic.Size = new System.Drawing.Size(90, 20);
            this.tbOutsideNATPublic.TabIndex = 58;
            this.tbOutsideNATPublic.Text = "Mask To IP";
            // 
            // tbOutsideNATPrivate
            // 
            this.tbOutsideNATPrivate.Location = new System.Drawing.Point(122, 40);
            this.tbOutsideNATPrivate.Name = "tbOutsideNATPrivate";
            this.tbOutsideNATPrivate.Size = new System.Drawing.Size(90, 20);
            this.tbOutsideNATPrivate.TabIndex = 57;
            this.tbOutsideNATPrivate.Text = "Source IP";
            // 
            // cbOutsideNAT
            // 
            this.cbOutsideNAT.AutoSize = true;
            this.cbOutsideNAT.Location = new System.Drawing.Point(6, 42);
            this.cbOutsideNAT.Name = "cbOutsideNAT";
            this.cbOutsideNAT.Size = new System.Drawing.Size(93, 17);
            this.cbOutsideNAT.TabIndex = 56;
            this.cbOutsideNAT.Text = "Mask External";
            this.cbOutsideNAT.UseVisualStyleBackColor = true;
            // 
            // tbInsideNATPublic
            // 
            this.tbInsideNATPublic.Location = new System.Drawing.Point(218, 17);
            this.tbInsideNATPublic.Name = "tbInsideNATPublic";
            this.tbInsideNATPublic.Size = new System.Drawing.Size(90, 20);
            this.tbInsideNATPublic.TabIndex = 55;
            this.tbInsideNATPublic.Text = "Mask To IP";
            // 
            // tbInsideNATPrivate
            // 
            this.tbInsideNATPrivate.Location = new System.Drawing.Point(122, 17);
            this.tbInsideNATPrivate.Name = "tbInsideNATPrivate";
            this.tbInsideNATPrivate.Size = new System.Drawing.Size(90, 20);
            this.tbInsideNATPrivate.TabIndex = 52;
            this.tbInsideNATPrivate.Text = "Source IP";
            // 
            // cbInsideNAT
            // 
            this.cbInsideNAT.AutoSize = true;
            this.cbInsideNAT.Location = new System.Drawing.Point(6, 19);
            this.cbInsideNAT.Name = "cbInsideNAT";
            this.cbInsideNAT.Size = new System.Drawing.Size(90, 17);
            this.cbInsideNAT.TabIndex = 51;
            this.cbInsideNAT.Text = "Mask Internal";
            this.cbInsideNAT.UseVisualStyleBackColor = true;
            // 
            // cbWriteNAT
            // 
            this.cbWriteNAT.AutoSize = true;
            this.cbWriteNAT.Location = new System.Drawing.Point(6, 3);
            this.cbWriteNAT.Name = "cbWriteNAT";
            this.cbWriteNAT.Size = new System.Drawing.Size(76, 17);
            this.cbWriteNAT.TabIndex = 1;
            this.cbWriteNAT.Text = "Write NAT";
            this.cbWriteNAT.UseVisualStyleBackColor = true;
            // 
            // gbNatInOut
            // 
            this.gbNatInOut.Controls.Add(this.tbNATOutsideInt);
            this.gbNatInOut.Controls.Add(this.cbNATOutsideInt);
            this.gbNatInOut.Controls.Add(this.tbNATInsideInt);
            this.gbNatInOut.Controls.Add(this.cbNATInsideInt);
            this.gbNatInOut.Location = new System.Drawing.Point(6, 26);
            this.gbNatInOut.Name = "gbNatInOut";
            this.gbNatInOut.Size = new System.Drawing.Size(227, 72);
            this.gbNatInOut.TabIndex = 0;
            this.gbNatInOut.TabStop = false;
            this.gbNatInOut.Text = "NAT Interfaces";
            // 
            // tbNATOutsideInt
            // 
            this.tbNATOutsideInt.Location = new System.Drawing.Point(122, 43);
            this.tbNATOutsideInt.Name = "tbNATOutsideInt";
            this.tbNATOutsideInt.Size = new System.Drawing.Size(90, 20);
            this.tbNATOutsideInt.TabIndex = 54;
            this.tbNATOutsideInt.Text = "serial 0/0/0";
            // 
            // cbNATOutsideInt
            // 
            this.cbNATOutsideInt.AutoSize = true;
            this.cbNATOutsideInt.Location = new System.Drawing.Point(6, 45);
            this.cbNATOutsideInt.Name = "cbNATOutsideInt";
            this.cbNATOutsideInt.Size = new System.Drawing.Size(107, 17);
            this.cbNATOutsideInt.TabIndex = 53;
            this.cbNATOutsideInt.Text = "Outside Interface";
            this.cbNATOutsideInt.UseVisualStyleBackColor = true;
            // 
            // tbNATInsideInt
            // 
            this.tbNATInsideInt.Location = new System.Drawing.Point(122, 17);
            this.tbNATInsideInt.Name = "tbNATInsideInt";
            this.tbNATInsideInt.Size = new System.Drawing.Size(90, 20);
            this.tbNATInsideInt.TabIndex = 52;
            this.tbNATInsideInt.Text = "fa0/0";
            // 
            // cbNATInsideInt
            // 
            this.cbNATInsideInt.AutoSize = true;
            this.cbNATInsideInt.Location = new System.Drawing.Point(6, 19);
            this.cbNATInsideInt.Name = "cbNATInsideInt";
            this.cbNATInsideInt.Size = new System.Drawing.Size(99, 17);
            this.cbNATInsideInt.TabIndex = 51;
            this.cbNATInsideInt.Text = "Inside Interface";
            this.cbNATInsideInt.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.gbStandardACL);
            this.tabPage7.Controls.Add(this.cbWriteStandardACL);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(448, 262);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Standard ACL";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // gbStandardACL
            // 
            this.gbStandardACL.Controls.Add(this.tbStandardACL8);
            this.gbStandardACL.Controls.Add(this.cbStandardACL8);
            this.gbStandardACL.Controls.Add(this.tbStandardACL6);
            this.gbStandardACL.Controls.Add(this.cbStandardACL6);
            this.gbStandardACL.Controls.Add(this.tbStandardACL7);
            this.gbStandardACL.Controls.Add(this.cbStandardACL7);
            this.gbStandardACL.Controls.Add(this.tbStandardACL5);
            this.gbStandardACL.Controls.Add(this.cbStandardACL5);
            this.gbStandardACL.Controls.Add(this.tbStandardACL4);
            this.gbStandardACL.Controls.Add(this.cbStandardACL4);
            this.gbStandardACL.Controls.Add(this.tbStandardACL2);
            this.gbStandardACL.Controls.Add(this.cbStandardACL2);
            this.gbStandardACL.Controls.Add(this.tbStandardACL3);
            this.gbStandardACL.Controls.Add(this.cbStandardACL3);
            this.gbStandardACL.Controls.Add(this.tbStandardACL1);
            this.gbStandardACL.Controls.Add(this.cbStandardACL1);
            this.gbStandardACL.Controls.Add(this.tbStandardACLApplyInOut);
            this.gbStandardACL.Controls.Add(this.cbStandardACLApply);
            this.gbStandardACL.Controls.Add(this.tbStandardACLApply);
            this.gbStandardACL.Controls.Add(this.tbStandardACLName);
            this.gbStandardACL.Controls.Add(this.cbStandardACL);
            this.gbStandardACL.Location = new System.Drawing.Point(10, 26);
            this.gbStandardACL.Name = "gbStandardACL";
            this.gbStandardACL.Size = new System.Drawing.Size(435, 224);
            this.gbStandardACL.TabIndex = 3;
            this.gbStandardACL.TabStop = false;
            this.gbStandardACL.Text = "Standard ACL";
            // 
            // tbStandardACL8
            // 
            this.tbStandardACL8.Location = new System.Drawing.Point(302, 114);
            this.tbStandardACL8.Name = "tbStandardACL8";
            this.tbStandardACL8.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL8.TabIndex = 26;
            this.tbStandardACL8.Text = "permit any";
            // 
            // cbStandardACL8
            // 
            this.cbStandardACL8.AutoSize = true;
            this.cbStandardACL8.Location = new System.Drawing.Point(219, 117);
            this.cbStandardACL8.Name = "cbStandardACL8";
            this.cbStandardACL8.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL8.TabIndex = 25;
            this.cbStandardACL8.Text = "ACL 8";
            this.cbStandardACL8.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL6
            // 
            this.tbStandardACL6.Location = new System.Drawing.Point(302, 91);
            this.tbStandardACL6.Name = "tbStandardACL6";
            this.tbStandardACL6.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL6.TabIndex = 24;
            this.tbStandardACL6.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL6
            // 
            this.cbStandardACL6.AutoSize = true;
            this.cbStandardACL6.Location = new System.Drawing.Point(219, 94);
            this.cbStandardACL6.Name = "cbStandardACL6";
            this.cbStandardACL6.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL6.TabIndex = 23;
            this.cbStandardACL6.Text = "ACL 6";
            this.cbStandardACL6.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL7
            // 
            this.tbStandardACL7.Location = new System.Drawing.Point(97, 117);
            this.tbStandardACL7.Name = "tbStandardACL7";
            this.tbStandardACL7.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL7.TabIndex = 22;
            this.tbStandardACL7.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL7
            // 
            this.cbStandardACL7.AutoSize = true;
            this.cbStandardACL7.Location = new System.Drawing.Point(14, 120);
            this.cbStandardACL7.Name = "cbStandardACL7";
            this.cbStandardACL7.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL7.TabIndex = 21;
            this.cbStandardACL7.Text = "ACL 7";
            this.cbStandardACL7.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL5
            // 
            this.tbStandardACL5.Location = new System.Drawing.Point(97, 94);
            this.tbStandardACL5.Name = "tbStandardACL5";
            this.tbStandardACL5.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL5.TabIndex = 20;
            this.tbStandardACL5.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL5
            // 
            this.cbStandardACL5.AutoSize = true;
            this.cbStandardACL5.Location = new System.Drawing.Point(14, 97);
            this.cbStandardACL5.Name = "cbStandardACL5";
            this.cbStandardACL5.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL5.TabIndex = 19;
            this.cbStandardACL5.Text = "ACL 5";
            this.cbStandardACL5.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL4
            // 
            this.tbStandardACL4.Location = new System.Drawing.Point(302, 68);
            this.tbStandardACL4.Name = "tbStandardACL4";
            this.tbStandardACL4.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL4.TabIndex = 18;
            this.tbStandardACL4.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL4
            // 
            this.cbStandardACL4.AutoSize = true;
            this.cbStandardACL4.Location = new System.Drawing.Point(219, 71);
            this.cbStandardACL4.Name = "cbStandardACL4";
            this.cbStandardACL4.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL4.TabIndex = 17;
            this.cbStandardACL4.Text = "ACL 4";
            this.cbStandardACL4.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL2
            // 
            this.tbStandardACL2.Location = new System.Drawing.Point(302, 45);
            this.tbStandardACL2.Name = "tbStandardACL2";
            this.tbStandardACL2.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL2.TabIndex = 16;
            this.tbStandardACL2.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL2
            // 
            this.cbStandardACL2.AutoSize = true;
            this.cbStandardACL2.Location = new System.Drawing.Point(219, 48);
            this.cbStandardACL2.Name = "cbStandardACL2";
            this.cbStandardACL2.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL2.TabIndex = 15;
            this.cbStandardACL2.Text = "ACL 2";
            this.cbStandardACL2.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL3
            // 
            this.tbStandardACL3.Location = new System.Drawing.Point(97, 71);
            this.tbStandardACL3.Name = "tbStandardACL3";
            this.tbStandardACL3.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL3.TabIndex = 14;
            this.tbStandardACL3.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL3
            // 
            this.cbStandardACL3.AutoSize = true;
            this.cbStandardACL3.Location = new System.Drawing.Point(14, 74);
            this.cbStandardACL3.Name = "cbStandardACL3";
            this.cbStandardACL3.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL3.TabIndex = 13;
            this.cbStandardACL3.Text = "ACL 3";
            this.cbStandardACL3.UseVisualStyleBackColor = true;
            // 
            // tbStandardACL1
            // 
            this.tbStandardACL1.Location = new System.Drawing.Point(97, 48);
            this.tbStandardACL1.Name = "tbStandardACL1";
            this.tbStandardACL1.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACL1.TabIndex = 12;
            this.tbStandardACL1.Text = "deny IP INV_MASK";
            // 
            // cbStandardACL1
            // 
            this.cbStandardACL1.AutoSize = true;
            this.cbStandardACL1.Location = new System.Drawing.Point(14, 51);
            this.cbStandardACL1.Name = "cbStandardACL1";
            this.cbStandardACL1.Size = new System.Drawing.Size(55, 17);
            this.cbStandardACL1.TabIndex = 11;
            this.cbStandardACL1.Text = "ACL 1";
            this.cbStandardACL1.UseVisualStyleBackColor = true;
            // 
            // tbStandardACLApplyInOut
            // 
            this.tbStandardACLApplyInOut.Location = new System.Drawing.Point(233, 155);
            this.tbStandardACLApplyInOut.Name = "tbStandardACLApplyInOut";
            this.tbStandardACLApplyInOut.Size = new System.Drawing.Size(41, 20);
            this.tbStandardACLApplyInOut.TabIndex = 10;
            this.tbStandardACLApplyInOut.Text = "in | out";
            // 
            // cbStandardACLApply
            // 
            this.cbStandardACLApply.AutoSize = true;
            this.cbStandardACLApply.Location = new System.Drawing.Point(6, 157);
            this.cbStandardACLApply.Name = "cbStandardACLApply";
            this.cbStandardACLApply.Size = new System.Drawing.Size(108, 17);
            this.cbStandardACLApply.TabIndex = 9;
            this.cbStandardACLApply.Text = "Apply to interface";
            this.cbStandardACLApply.UseVisualStyleBackColor = true;
            // 
            // tbStandardACLApply
            // 
            this.tbStandardACLApply.Location = new System.Drawing.Point(120, 154);
            this.tbStandardACLApply.Name = "tbStandardACLApply";
            this.tbStandardACLApply.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACLApply.TabIndex = 8;
            this.tbStandardACLApply.Text = "serial 0/0/0";
            // 
            // tbStandardACLName
            // 
            this.tbStandardACLName.Location = new System.Drawing.Point(89, 16);
            this.tbStandardACLName.Name = "tbStandardACLName";
            this.tbStandardACLName.Size = new System.Drawing.Size(107, 20);
            this.tbStandardACLName.TabIndex = 7;
            this.tbStandardACLName.Text = "STND-1";
            // 
            // cbStandardACL
            // 
            this.cbStandardACL.AutoSize = true;
            this.cbStandardACL.Location = new System.Drawing.Point(6, 19);
            this.cbStandardACL.Name = "cbStandardACL";
            this.cbStandardACL.Size = new System.Drawing.Size(77, 17);
            this.cbStandardACL.TabIndex = 3;
            this.cbStandardACL.Text = "ACL Name";
            this.cbStandardACL.UseVisualStyleBackColor = true;
            // 
            // cbWriteStandardACL
            // 
            this.cbWriteStandardACL.AutoSize = true;
            this.cbWriteStandardACL.Location = new System.Drawing.Point(3, 3);
            this.cbWriteStandardACL.Name = "cbWriteStandardACL";
            this.cbWriteStandardACL.Size = new System.Drawing.Size(120, 17);
            this.cbWriteStandardACL.TabIndex = 2;
            this.cbWriteStandardACL.Text = "Write Standard ACL";
            this.cbWriteStandardACL.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox1);
            this.tabPage8.Controls.Add(this.cbWriteExtendedACL);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(448, 262);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Extended ACL";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbExtendedACL4);
            this.groupBox1.Controls.Add(this.cbExtendedACL4);
            this.groupBox1.Controls.Add(this.tbExtendedACL3);
            this.groupBox1.Controls.Add(this.cbExtendedACL3);
            this.groupBox1.Controls.Add(this.tbExtendedACL2);
            this.groupBox1.Controls.Add(this.cbExtendedACL2);
            this.groupBox1.Controls.Add(this.tbExtendedACL1);
            this.groupBox1.Controls.Add(this.cbExtendedACL1);
            this.groupBox1.Controls.Add(this.tbExtendedACLApplyInOut);
            this.groupBox1.Controls.Add(this.cbExtendedACLApply);
            this.groupBox1.Controls.Add(this.tbExtendedACLApply);
            this.groupBox1.Controls.Add(this.tbExtendedACLName);
            this.groupBox1.Controls.Add(this.cbExtendedACL);
            this.groupBox1.Location = new System.Drawing.Point(10, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extended ACL";
            // 
            // tbExtendedACL4
            // 
            this.tbExtendedACL4.Location = new System.Drawing.Point(97, 117);
            this.tbExtendedACL4.Name = "tbExtendedACL4";
            this.tbExtendedACL4.Size = new System.Drawing.Size(332, 20);
            this.tbExtendedACL4.TabIndex = 22;
            this.tbExtendedACL4.Text = "permit ip any any";
            // 
            // cbExtendedACL4
            // 
            this.cbExtendedACL4.AutoSize = true;
            this.cbExtendedACL4.Location = new System.Drawing.Point(14, 120);
            this.cbExtendedACL4.Name = "cbExtendedACL4";
            this.cbExtendedACL4.Size = new System.Drawing.Size(55, 17);
            this.cbExtendedACL4.TabIndex = 21;
            this.cbExtendedACL4.Text = "ACL 4";
            this.cbExtendedACL4.UseVisualStyleBackColor = true;
            // 
            // tbExtendedACL3
            // 
            this.tbExtendedACL3.Location = new System.Drawing.Point(97, 94);
            this.tbExtendedACL3.Name = "tbExtendedACL3";
            this.tbExtendedACL3.Size = new System.Drawing.Size(332, 20);
            this.tbExtendedACL3.TabIndex = 20;
            this.tbExtendedACL3.Text = "deny ip IP_Addr INV_Netmask host IP_Addr";
            // 
            // cbExtendedACL3
            // 
            this.cbExtendedACL3.AutoSize = true;
            this.cbExtendedACL3.Location = new System.Drawing.Point(14, 97);
            this.cbExtendedACL3.Name = "cbExtendedACL3";
            this.cbExtendedACL3.Size = new System.Drawing.Size(55, 17);
            this.cbExtendedACL3.TabIndex = 19;
            this.cbExtendedACL3.Text = "ACL 3";
            this.cbExtendedACL3.UseVisualStyleBackColor = true;
            // 
            // tbExtendedACL2
            // 
            this.tbExtendedACL2.Location = new System.Drawing.Point(97, 71);
            this.tbExtendedACL2.Name = "tbExtendedACL2";
            this.tbExtendedACL2.Size = new System.Drawing.Size(332, 20);
            this.tbExtendedACL2.TabIndex = 14;
            this.tbExtendedACL2.Text = "deny ip IP_Addr INV_Netmask host IP_Addr";
            // 
            // cbExtendedACL2
            // 
            this.cbExtendedACL2.AutoSize = true;
            this.cbExtendedACL2.Location = new System.Drawing.Point(14, 74);
            this.cbExtendedACL2.Name = "cbExtendedACL2";
            this.cbExtendedACL2.Size = new System.Drawing.Size(55, 17);
            this.cbExtendedACL2.TabIndex = 13;
            this.cbExtendedACL2.Text = "ACL 2";
            this.cbExtendedACL2.UseVisualStyleBackColor = true;
            // 
            // tbExtendedACL1
            // 
            this.tbExtendedACL1.Location = new System.Drawing.Point(97, 48);
            this.tbExtendedACL1.Name = "tbExtendedACL1";
            this.tbExtendedACL1.Size = new System.Drawing.Size(332, 20);
            this.tbExtendedACL1.TabIndex = 12;
            this.tbExtendedACL1.Text = "deny ip IP_Addr INV_Netmask host IP_Addr";
            // 
            // cbExtendedACL1
            // 
            this.cbExtendedACL1.AutoSize = true;
            this.cbExtendedACL1.Location = new System.Drawing.Point(14, 51);
            this.cbExtendedACL1.Name = "cbExtendedACL1";
            this.cbExtendedACL1.Size = new System.Drawing.Size(55, 17);
            this.cbExtendedACL1.TabIndex = 11;
            this.cbExtendedACL1.Text = "ACL 1";
            this.cbExtendedACL1.UseVisualStyleBackColor = true;
            // 
            // tbExtendedACLApplyInOut
            // 
            this.tbExtendedACLApplyInOut.Location = new System.Drawing.Point(233, 155);
            this.tbExtendedACLApplyInOut.Name = "tbExtendedACLApplyInOut";
            this.tbExtendedACLApplyInOut.Size = new System.Drawing.Size(41, 20);
            this.tbExtendedACLApplyInOut.TabIndex = 10;
            this.tbExtendedACLApplyInOut.Text = "in | out";
            // 
            // cbExtendedACLApply
            // 
            this.cbExtendedACLApply.AutoSize = true;
            this.cbExtendedACLApply.Location = new System.Drawing.Point(6, 157);
            this.cbExtendedACLApply.Name = "cbExtendedACLApply";
            this.cbExtendedACLApply.Size = new System.Drawing.Size(108, 17);
            this.cbExtendedACLApply.TabIndex = 9;
            this.cbExtendedACLApply.Text = "Apply to interface";
            this.cbExtendedACLApply.UseVisualStyleBackColor = true;
            // 
            // tbExtendedACLApply
            // 
            this.tbExtendedACLApply.Location = new System.Drawing.Point(120, 154);
            this.tbExtendedACLApply.Name = "tbExtendedACLApply";
            this.tbExtendedACLApply.Size = new System.Drawing.Size(107, 20);
            this.tbExtendedACLApply.TabIndex = 8;
            this.tbExtendedACLApply.Text = "serial 0/0/0";
            // 
            // tbExtendedACLName
            // 
            this.tbExtendedACLName.Location = new System.Drawing.Point(89, 16);
            this.tbExtendedACLName.Name = "tbExtendedACLName";
            this.tbExtendedACLName.Size = new System.Drawing.Size(107, 20);
            this.tbExtendedACLName.TabIndex = 7;
            this.tbExtendedACLName.Text = "STND-1";
            // 
            // cbExtendedACL
            // 
            this.cbExtendedACL.AutoSize = true;
            this.cbExtendedACL.Location = new System.Drawing.Point(6, 19);
            this.cbExtendedACL.Name = "cbExtendedACL";
            this.cbExtendedACL.Size = new System.Drawing.Size(77, 17);
            this.cbExtendedACL.TabIndex = 3;
            this.cbExtendedACL.Text = "ACL Name";
            this.cbExtendedACL.UseVisualStyleBackColor = true;
            // 
            // cbWriteExtendedACL
            // 
            this.cbWriteExtendedACL.AutoSize = true;
            this.cbWriteExtendedACL.Location = new System.Drawing.Point(3, 3);
            this.cbWriteExtendedACL.Name = "cbWriteExtendedACL";
            this.cbWriteExtendedACL.Size = new System.Drawing.Size(122, 17);
            this.cbWriteExtendedACL.TabIndex = 4;
            this.cbWriteExtendedACL.Text = "Write Extended ACL";
            this.cbWriteExtendedACL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 435);
            this.Controls.Add(this.tabBox);
            this.Controls.Add(this.cbWriteStartup);
            this.Controls.Add(this.gbStartupConfig);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Cisco Script Builder";
            this.gbStartupConfig.ResumeLayout(false);
            this.gbStartupConfig.PerformLayout();
            this.tabBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbIface2.ResumeLayout(false);
            this.gbIface2.PerformLayout();
            this.gbIface1.ResumeLayout(false);
            this.gbIface1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbAssignVlan.ResumeLayout(false);
            this.gbAssignVlan.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gbTrunking.ResumeLayout(false);
            this.gbTrunking.PerformLayout();
            this.gbManagementInterface.ResumeLayout(false);
            this.gbManagementInterface.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbEIGRP.ResumeLayout(false);
            this.gbEIGRP.PerformLayout();
            this.gbOSPF.ResumeLayout(false);
            this.gbOSPF.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.gbDHCPConfig.ResumeLayout(false);
            this.gbDHCPConfig.PerformLayout();
            this.gbExcludedIPs.ResumeLayout(false);
            this.gbExcludedIPs.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.gbNATMapping.ResumeLayout(false);
            this.gbNATMapping.PerformLayout();
            this.gbNatInOut.ResumeLayout(false);
            this.gbNatInOut.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.gbStandardACL.ResumeLayout(false);
            this.gbStandardACL.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbHostname;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.TextBox tbSecret;
        private System.Windows.Forms.CheckBox cbSecret;
        private System.Windows.Forms.GroupBox gbStartupConfig;
        private System.Windows.Forms.CheckBox cbWriteStartup;
        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbWriteIface2;
        private System.Windows.Forms.CheckBox cbWriteIface1;
        private System.Windows.Forms.GroupBox gbIface2;
        private System.Windows.Forms.CheckBox cbIFace2ClockRate;
        private System.Windows.Forms.TextBox tbIFace2ClockRate;
        private System.Windows.Forms.CheckBox cbIface2Name;
        private System.Windows.Forms.TextBox tbIface2Name;
        private System.Windows.Forms.CheckBox cbIface2Shut;
        private System.Windows.Forms.CheckBox cbIface2IP;
        private System.Windows.Forms.TextBox tbIface2Netmask;
        private System.Windows.Forms.TextBox tbIface2IP;
        private System.Windows.Forms.GroupBox gbIface1;
        private System.Windows.Forms.CheckBox cbIFace1ClockRate;
        private System.Windows.Forms.TextBox tbIFace1ClockRate;
        private System.Windows.Forms.CheckBox cbIface1Name;
        private System.Windows.Forms.TextBox tbIface1Name;
        private System.Windows.Forms.CheckBox cbIface1Shut;
        private System.Windows.Forms.CheckBox cbIface1IP;
        private System.Windows.Forms.TextBox tbIface1Netmask;
        private System.Windows.Forms.TextBox tbIface1IP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbAssignVlan;
        private System.Windows.Forms.TextBox tbInterfaceName4;
        private System.Windows.Forms.CheckBox cbAssignToInterface4;
        private System.Windows.Forms.TextBox tbVlanName4;
        private System.Windows.Forms.TextBox tbVlanID4;
        private System.Windows.Forms.CheckBox cbVlan4;
        private System.Windows.Forms.TextBox tbInterfaceName3;
        private System.Windows.Forms.CheckBox cbAssignToInterface3;
        private System.Windows.Forms.TextBox tbVlanName3;
        private System.Windows.Forms.TextBox tbVlanID3;
        private System.Windows.Forms.CheckBox cbVlan3;
        private System.Windows.Forms.TextBox tbInterfaceName2;
        private System.Windows.Forms.CheckBox cbAssignToInterface2;
        private System.Windows.Forms.TextBox tbVlanName2;
        private System.Windows.Forms.TextBox tbVlanID2;
        private System.Windows.Forms.CheckBox cbVlan2;
        private System.Windows.Forms.TextBox tbInterfaceName1;
        private System.Windows.Forms.CheckBox cbAssignToInterface1;
        private System.Windows.Forms.TextBox tbVlanName1;
        private System.Windows.Forms.TextBox tbVlanID1;
        private System.Windows.Forms.CheckBox cbVlan1;
        private System.Windows.Forms.TextBox tbInterfaceName7;
        private System.Windows.Forms.CheckBox cbAssignToInterface7;
        private System.Windows.Forms.TextBox tbVlanName7;
        private System.Windows.Forms.TextBox tbVlanID7;
        private System.Windows.Forms.CheckBox cbVlan7;
        private System.Windows.Forms.TextBox tbInterfaceName6;
        private System.Windows.Forms.CheckBox cbAssignToInterface6;
        private System.Windows.Forms.TextBox tbVlanName6;
        private System.Windows.Forms.TextBox tbVlanID6;
        private System.Windows.Forms.CheckBox cbVlan6;
        private System.Windows.Forms.TextBox tbInterfaceName5;
        private System.Windows.Forms.CheckBox cbAssignToInterface5;
        private System.Windows.Forms.TextBox tbVlanName5;
        private System.Windows.Forms.TextBox tbVlanID5;
        private System.Windows.Forms.CheckBox cbVlan5;
        private System.Windows.Forms.CheckBox cbWriteVlan;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbManagementInterface;
        private System.Windows.Forms.TextBox tbManagementVlanName;
        private System.Windows.Forms.TextBox tbManagementVlanID;
        private System.Windows.Forms.CheckBox cbManagementVlan;
        private System.Windows.Forms.TextBox tbManagementNetmask;
        private System.Windows.Forms.TextBox tbManagementIP;
        private System.Windows.Forms.GroupBox gbTrunking;
        private System.Windows.Forms.Label lblTrunkInterface;
        private System.Windows.Forms.TextBox tbTrunkInterface;
        private System.Windows.Forms.TextBox tbTrunkingNativeVlan;
        private System.Windows.Forms.CheckBox cbTrunking;
        private System.Windows.Forms.CheckBox cbWriteSwitchCommands;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbWriteEIGRP;
        private System.Windows.Forms.GroupBox gbEIGRP;
        private System.Windows.Forms.CheckBox cbEIGRPNetwork2;
        private System.Windows.Forms.TextBox tbEIGRPNetworkID2;
        private System.Windows.Forms.CheckBox cbEIGRPNetwork1;
        private System.Windows.Forms.TextBox tbEIGRPNetworkID1;
        private System.Windows.Forms.CheckBox cbEIGRPID;
        private System.Windows.Forms.TextBox tbEIGRPAreaID;
        private System.Windows.Forms.CheckBox cbWriteOSPF;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox gbExcludedIPs;
        private System.Windows.Forms.TextBox tbExcludeRangeStop1;
        private System.Windows.Forms.TextBox tbExcludeRangeStart1;
        private System.Windows.Forms.CheckBox cbExcludeRange1;
        private System.Windows.Forms.CheckBox cbWriteDHCP;
        private System.Windows.Forms.GroupBox gbDHCPConfig;
        private System.Windows.Forms.TextBox tbDHCPNetworkNetmask;
        private System.Windows.Forms.TextBox tbDHCPPool;
        private System.Windows.Forms.TextBox tbDHCPNetworkIP;
        private System.Windows.Forms.CheckBox cbDHCPPool;
        private System.Windows.Forms.TextBox tbExcludeRangeStop2;
        private System.Windows.Forms.TextBox tbExcludeRangeStart2;
        private System.Windows.Forms.CheckBox cbExcludeRange2;
        private System.Windows.Forms.TextBox tbDHCPDefaultRouter;
        private System.Windows.Forms.CheckBox cbDHCPDefaultRouter;
        private System.Windows.Forms.TextBox tbDHCPDnsServer;
        private System.Windows.Forms.CheckBox cbDHCPDnsServer;
        private System.Windows.Forms.CheckBox cbDHCPHelperAddress2;
        private System.Windows.Forms.TextBox tbDHCPHelperAddress2;
        private System.Windows.Forms.CheckBox cbDHCPHelperAddress1;
        private System.Windows.Forms.TextBox tbDHCPHelperAddress1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox cbWriteNAT;
        private System.Windows.Forms.GroupBox gbNatInOut;
        private System.Windows.Forms.TextBox tbNATOutsideInt;
        private System.Windows.Forms.CheckBox cbNATOutsideInt;
        private System.Windows.Forms.TextBox tbNATInsideInt;
        private System.Windows.Forms.CheckBox cbNATInsideInt;
        private System.Windows.Forms.GroupBox gbNATMapping;
        private System.Windows.Forms.TextBox tbOutsideNATPublic;
        private System.Windows.Forms.TextBox tbOutsideNATPrivate;
        private System.Windows.Forms.CheckBox cbOutsideNAT;
        private System.Windows.Forms.TextBox tbInsideNATPublic;
        private System.Windows.Forms.TextBox tbInsideNATPrivate;
        private System.Windows.Forms.CheckBox cbInsideNAT;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox gbStandardACL;
        private System.Windows.Forms.CheckBox cbWriteStandardACL;
        private System.Windows.Forms.TextBox tbStandardACL8;
        private System.Windows.Forms.CheckBox cbStandardACL8;
        private System.Windows.Forms.TextBox tbStandardACL6;
        private System.Windows.Forms.CheckBox cbStandardACL6;
        private System.Windows.Forms.TextBox tbStandardACL7;
        private System.Windows.Forms.CheckBox cbStandardACL7;
        private System.Windows.Forms.TextBox tbStandardACL5;
        private System.Windows.Forms.CheckBox cbStandardACL5;
        private System.Windows.Forms.TextBox tbStandardACL4;
        private System.Windows.Forms.CheckBox cbStandardACL4;
        private System.Windows.Forms.TextBox tbStandardACL2;
        private System.Windows.Forms.CheckBox cbStandardACL2;
        private System.Windows.Forms.TextBox tbStandardACL3;
        private System.Windows.Forms.CheckBox cbStandardACL3;
        private System.Windows.Forms.TextBox tbStandardACL1;
        private System.Windows.Forms.CheckBox cbStandardACL1;
        private System.Windows.Forms.TextBox tbStandardACLApplyInOut;
        private System.Windows.Forms.CheckBox cbStandardACLApply;
        private System.Windows.Forms.TextBox tbStandardACLApply;
        private System.Windows.Forms.TextBox tbStandardACLName;
        private System.Windows.Forms.CheckBox cbStandardACL;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbExtendedACL4;
        private System.Windows.Forms.CheckBox cbExtendedACL4;
        private System.Windows.Forms.TextBox tbExtendedACL3;
        private System.Windows.Forms.CheckBox cbExtendedACL3;
        private System.Windows.Forms.TextBox tbExtendedACL2;
        private System.Windows.Forms.CheckBox cbExtendedACL2;
        private System.Windows.Forms.TextBox tbExtendedACL1;
        private System.Windows.Forms.CheckBox cbExtendedACL1;
        private System.Windows.Forms.TextBox tbExtendedACLApplyInOut;
        private System.Windows.Forms.CheckBox cbExtendedACLApply;
        private System.Windows.Forms.TextBox tbExtendedACLApply;
        private System.Windows.Forms.TextBox tbExtendedACLName;
        private System.Windows.Forms.CheckBox cbExtendedACL;
        private System.Windows.Forms.CheckBox cbWriteExtendedACL;
        private System.Windows.Forms.GroupBox gbOSPF;
        private System.Windows.Forms.CheckBox cbOSPFNetworkID2;
        private System.Windows.Forms.TextBox tbOSPFNetworkID2;
        private System.Windows.Forms.TextBox tbOSPFInvMask2;
        private System.Windows.Forms.CheckBox cbOSPFNetworkID1;
        private System.Windows.Forms.TextBox tbOSPFNetworkID1;
        private System.Windows.Forms.CheckBox cbOSPFID;
        private System.Windows.Forms.TextBox tbOSPFInvMask1;
        private System.Windows.Forms.TextBox tbOSPFAreaID;
    }
}

