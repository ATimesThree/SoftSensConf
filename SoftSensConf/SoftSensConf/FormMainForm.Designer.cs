
namespace SoftSensConf
{
    partial class FormMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonMenuBarExit = new System.Windows.Forms.Button();
            this.buttonMenuBarConfiguration = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelLogoPanel = new System.Windows.Forms.Panel();
            this.pictureBoxLogoBox = new System.Windows.Forms.PictureBox();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadConfigToolStripMenuItemLoadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveConfigToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationToolStripMenuItemConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetToolStripMenuItemDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.graphPictureToolStripMenuItemGraphPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItemDahshboard = new System.Windows.Forms.ToolStripMenuItem();
            this.setupConfigToolStripMenuItemSetupAndConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.panelMainHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMainConnectivity = new System.Windows.Forms.TextBox();
            this.textBoxMainUserName = new System.Windows.Forms.TextBox();
            this.labelSoftwareVersion = new System.Windows.Forms.Label();
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.ConnectivityChecker = new System.Windows.Forms.Timer(this.components);
            this.timerStatusBarChecker = new System.Windows.Forms.Timer(this.components);
            this.timerTabContoller = new System.Windows.Forms.Timer(this.components);
            this.timerDashboardDataInformation = new System.Windows.Forms.Timer(this.components);
            this.timerWifiImageChecker = new System.Windows.Forms.Timer(this.components);
            this.timerSerialDataRequester = new System.Windows.Forms.Timer(this.components);
            this.timerDataChartUpdater = new System.Windows.Forms.Timer(this.components);
            this.toolTipConfigDeviceName = new System.Windows.Forms.ToolTip(this.components);
            this.timerAlarmRequester = new System.Windows.Forms.Timer(this.components);
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.textBoxConfigurationDeviceName = new System.Windows.Forms.TextBox();
            this.comboBoxConfigurationSerialPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxConfigurationChoseBaudRate = new System.Windows.Forms.ComboBox();
            this.panelConfigurationSetup = new System.Windows.Forms.Panel();
            this.labelSetupIpAddress = new System.Windows.Forms.Label();
            this.labelSetupRDCID = new System.Windows.Forms.Label();
            this.labelConfigurationSetup = new System.Windows.Forms.Label();
            this.buttonConfigurationConnect = new System.Windows.Forms.Button();
            this.buttonConfigurationDisconnect = new System.Windows.Forms.Button();
            this.pictureBoxConfigurationWifi = new System.Windows.Forms.PictureBox();
            this.comboBoxSetupRDCID = new System.Windows.Forms.ComboBox();
            this.textBoxSetupRDCIPAddress = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelSetupDAUID = new System.Windows.Forms.Label();
            this.labelSetupDeviceName = new System.Windows.Forms.Label();
            this.labelSetupComPort = new System.Windows.Forms.Label();
            this.labelSetupBaudRate = new System.Windows.Forms.Label();
            this.textBoxSetupDAUComPort = new System.Windows.Forms.TextBox();
            this.textBoxSetupDAUBaudRate = new System.Windows.Forms.TextBox();
            this.textBoxSetupDAULastUpdated = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSetupDAUInstallmentDate = new System.Windows.Forms.TextBox();
            this.labelSetupLastUpdated = new System.Windows.Forms.Label();
            this.textBoxSetupDAUAreaCode = new System.Windows.Forms.TextBox();
            this.labelSetupArea = new System.Windows.Forms.Label();
            this.textBoxSetupDAUFacility = new System.Windows.Forms.TextBox();
            this.textBoxSetupDAUCountry = new System.Windows.Forms.TextBox();
            this.comboBoxSetupDAUID = new System.Windows.Forms.ComboBox();
            this.comboBoxSetupDAUDeviceName = new System.Windows.Forms.ComboBox();
            this.panelConfigurationConfiguration = new System.Windows.Forms.Panel();
            this.labelConfigurationConfiguration = new System.Windows.Forms.Label();
            this.textBoxConfigurationURV = new System.Windows.Forms.TextBox();
            this.textBoxConfigurationLRV = new System.Windows.Forms.TextBox();
            this.labelConfigurationAlertURV = new System.Windows.Forms.Label();
            this.labelConfigurationAlertLRV = new System.Windows.Forms.Label();
            this.buttonConfigurationSaveConfiguration = new System.Windows.Forms.Button();
            this.buttonConfigurationSendConfiguration = new System.Windows.Forms.Button();
            this.textBoxConfigurationAlarmLow = new System.Windows.Forms.TextBox();
            this.labelConfigurationAlarmLow = new System.Windows.Forms.Label();
            this.buttonConfigurationLoadConfiguration = new System.Windows.Forms.Button();
            this.labelConfigurationDeviceName = new System.Windows.Forms.Label();
            this.textBoxConfigurationAlarmHigh = new System.Windows.Forms.TextBox();
            this.labelConfigurationAlarmHigh = new System.Windows.Forms.Label();
            this.buttonConfigurationRquestDeviceConfig = new System.Windows.Forms.Button();
            this.textBoxConfigurationIType = new System.Windows.Forms.TextBox();
            this.labelConfigurationIOType = new System.Windows.Forms.Label();
            this.textBoxConfigurationAreaCode = new System.Windows.Forms.TextBox();
            this.textBoxConfigurationScanningFrequency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxConfigurationFacility = new System.Windows.Forms.TextBox();
            this.labelConfigurationScanningFrequency = new System.Windows.Forms.Label();
            this.textBoxConfigurationCountry = new System.Windows.Forms.TextBox();
            this.comboBoxConfigurationTag = new System.Windows.Forms.ComboBox();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.panelDashboardChart = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelDashboardGraph = new System.Windows.Forms.Label();
            this.chartDashboardChartRaw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDashboardChartScaled = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBoxDashboardGraphData = new System.Windows.Forms.GroupBox();
            this.radioButtonDashboardRaw = new System.Windows.Forms.RadioButton();
            this.radioButtonDashboardScaled = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBoxDashboardLine7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxDashboardLRV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDashboardURV = new System.Windows.Forms.TextBox();
            this.labelDashboardAlarmHigh = new System.Windows.Forms.Label();
            this.labelDashboardGraphLRV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDashboardGraphURV = new System.Windows.Forms.Label();
            this.textBoxDashboardAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxDashboardAlarmLow = new System.Windows.Forms.TextBox();
            this.panelDashboardDataInformation = new System.Windows.Forms.Panel();
            this.pictureBoxDashboardLine9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardLine2 = new System.Windows.Forms.PictureBox();
            this.labelDashboardPortName = new System.Windows.Forms.Label();
            this.labelDashboardDataInformation = new System.Windows.Forms.Label();
            this.labelDashboardCurrentDataStatus = new System.Windows.Forms.Label();
            this.labelDashboardBaudRate = new System.Windows.Forms.Label();
            this.textBoxDashboardPortName = new System.Windows.Forms.TextBox();
            this.textBoxDashboardBaudRate = new System.Windows.Forms.TextBox();
            this.textBoxDashboardDataStatus = new System.Windows.Forms.TextBox();
            this.labelDashboardConnectivityStatus = new System.Windows.Forms.Label();
            this.textBoxDashboardConnectivityStatus = new System.Windows.Forms.TextBox();
            this.labelDashboardDatapoints = new System.Windows.Forms.Label();
            this.labelDashboardDataType = new System.Windows.Forms.Label();
            this.textBoxDashboardDatapoints = new System.Windows.Forms.TextBox();
            this.panelDashboardControl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDashboardStartRecordingData = new System.Windows.Forms.Button();
            this.buttonDashboardStopReceiving = new System.Windows.Forms.Button();
            this.listBoxDashboardTextDataRaw = new System.Windows.Forms.ListBox();
            this.buttonDashboardSaveGraphImage = new System.Windows.Forms.Button();
            this.buttonDashboardResetDatapoints = new System.Windows.Forms.Button();
            this.buttonDashboardSaveFile = new System.Windows.Forms.Button();
            this.listBoxDashboardTextDataScaled = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBoxDashboardFaultyData = new System.Windows.Forms.TextBox();
            this.textBoxDashboardError = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboardError = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDashboardDeviceStatus = new System.Windows.Forms.Label();
            this.labelDashboardFaultyData = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.labelConfigurationComType = new System.Windows.Forms.Label();
            this.textBoxConfigurationCommunicationType = new System.Windows.Forms.TextBox();
            this.textBoxDashboardFrequency = new System.Windows.Forms.TextBox();
            this.labelDashboardFrequency = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBoxDashboardDataType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConfigurationLastUpdated = new System.Windows.Forms.Label();
            this.textBoxConfigurationLastUpdated = new System.Windows.Forms.TextBox();
            this.panelMainMenu.SuspendLayout();
            this.panelLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoBox)).BeginInit();
            this.menuStripFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.panelMainHeader.SuspendLayout();
            this.panelFormLoader.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.panelConfigurationSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigurationWifi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelConfigurationConfiguration.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.panelDashboardChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardChartRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardChartScaled)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBoxDashboardGraphData.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDashboardDataInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine2)).BeginInit();
            this.panelDashboardControl.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardError)).BeginInit();
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelMainMenu.Controls.Add(this.label4);
            this.panelMainMenu.Controls.Add(this.button1);
            this.panelMainMenu.Controls.Add(this.buttonMenuBarExit);
            this.panelMainMenu.Controls.Add(this.buttonMenuBarConfiguration);
            this.panelMainMenu.Controls.Add(this.buttonDashboard);
            this.panelMainMenu.Controls.Add(this.panelLogoPanel);
            this.panelMainMenu.Controls.Add(this.statusStripMain);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(186, 669);
            this.panelMainMenu.TabIndex = 99;
            // 
            // buttonMenuBarExit
            // 
            this.buttonMenuBarExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenuBarExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMenuBarExit.FlatAppearance.BorderSize = 0;
            this.buttonMenuBarExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuBarExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuBarExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonMenuBarExit.Image = global::SoftSensConf.Properties.Resources.Exit_Menu_Icon_Black;
            this.buttonMenuBarExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuBarExit.Location = new System.Drawing.Point(0, 605);
            this.buttonMenuBarExit.Name = "buttonMenuBarExit";
            this.buttonMenuBarExit.Size = new System.Drawing.Size(186, 42);
            this.buttonMenuBarExit.TabIndex = 92;
            this.buttonMenuBarExit.Text = "&Exit";
            this.buttonMenuBarExit.UseVisualStyleBackColor = true;
            this.buttonMenuBarExit.Click += new System.EventHandler(this.buttonMenuBarExit_Click);
            this.buttonMenuBarExit.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonMenuBarExit.MouseHover += new System.EventHandler(this.buttonMenuBarExit_MouseHover);
            // 
            // buttonMenuBarConfiguration
            // 
            this.buttonMenuBarConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenuBarConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuBarConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonMenuBarConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuBarConfiguration.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuBarConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonMenuBarConfiguration.Image = global::SoftSensConf.Properties.Resources.Setup_Config_Menu_Black;
            this.buttonMenuBarConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuBarConfiguration.Location = new System.Drawing.Point(0, 165);
            this.buttonMenuBarConfiguration.Name = "buttonMenuBarConfiguration";
            this.buttonMenuBarConfiguration.Size = new System.Drawing.Size(186, 42);
            this.buttonMenuBarConfiguration.TabIndex = 91;
            this.buttonMenuBarConfiguration.Text = "Setup && &Config";
            this.buttonMenuBarConfiguration.UseVisualStyleBackColor = true;
            this.buttonMenuBarConfiguration.Click += new System.EventHandler(this.buttonMenuBarConfiguration_Click);
            this.buttonMenuBarConfiguration.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonMenuBarConfiguration.MouseHover += new System.EventHandler(this.buttonMenuBarConfiguration_MouseHover);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDashboard.Image = global::SoftSensConf.Properties.Resources.Dashboard_Icon_Menu_Black;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 123);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(186, 42);
            this.buttonDashboard.TabIndex = 90;
            this.buttonDashboard.Text = "&Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            this.buttonDashboard.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonDashboard.MouseHover += new System.EventHandler(this.buttonDashboard_MouseHover);
            // 
            // panelLogoPanel
            // 
            this.panelLogoPanel.Controls.Add(this.pictureBoxLogoBox);
            this.panelLogoPanel.Controls.Add(this.menuStripFile);
            this.panelLogoPanel.Controls.Add(this.pictureBoxMain);
            this.panelLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.panelLogoPanel.Name = "panelLogoPanel";
            this.panelLogoPanel.Size = new System.Drawing.Size(186, 123);
            this.panelLogoPanel.TabIndex = 0;
            // 
            // pictureBoxLogoBox
            // 
            this.pictureBoxLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogoBox.Image = global::SoftSensConf.Properties.Resources.SoftSenseConf_Logo_Black;
            this.pictureBoxLogoBox.Location = new System.Drawing.Point(9, 25);
            this.pictureBoxLogoBox.Name = "pictureBoxLogoBox";
            this.pictureBoxLogoBox.Size = new System.Drawing.Size(168, 93);
            this.pictureBoxLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoBox.TabIndex = 0;
            this.pictureBoxLogoBox.TabStop = false;
            // 
            // menuStripFile
            // 
            this.menuStripFile.BackColor = System.Drawing.Color.Transparent;
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItemFile,
            this.GotoToolStripMenuItem,
            this.toolStripMenuItemAbout});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(186, 24);
            this.menuStripFile.TabIndex = 1;
            this.menuStripFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItemFile
            // 
            this.fileToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadConfigToolStripMenuItemLoadConfig,
            this.SaveConfigToolStripMenuItemSave,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItemFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItemFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.fileToolStripMenuItemFile.Name = "fileToolStripMenuItemFile";
            this.fileToolStripMenuItemFile.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItemFile.Text = "&File";
            // 
            // LoadConfigToolStripMenuItemLoadConfig
            // 
            this.LoadConfigToolStripMenuItemLoadConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceConfigToolStripMenuItem,
            this.fileConfigToolStripMenuItem});
            this.LoadConfigToolStripMenuItemLoadConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LoadConfigToolStripMenuItemLoadConfig.Name = "LoadConfigToolStripMenuItemLoadConfig";
            this.LoadConfigToolStripMenuItemLoadConfig.Size = new System.Drawing.Size(180, 22);
            this.LoadConfigToolStripMenuItemLoadConfig.Text = "Load";
            this.LoadConfigToolStripMenuItemLoadConfig.Visible = false;
            // 
            // deviceConfigToolStripMenuItem
            // 
            this.deviceConfigToolStripMenuItem.Name = "deviceConfigToolStripMenuItem";
            this.deviceConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deviceConfigToolStripMenuItem.Text = "Device config";
            this.deviceConfigToolStripMenuItem.Click += new System.EventHandler(this.buttonConfigurationRquestDeviceConfig_Click);
            // 
            // fileConfigToolStripMenuItem
            // 
            this.fileConfigToolStripMenuItem.Name = "fileConfigToolStripMenuItem";
            this.fileConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileConfigToolStripMenuItem.Text = "File config";
            this.fileConfigToolStripMenuItem.Click += new System.EventHandler(this.buttonConfigurationLoadConfiguration_Click);
            // 
            // SaveConfigToolStripMenuItemSave
            // 
            this.SaveConfigToolStripMenuItemSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurationToolStripMenuItemConfiguration,
            this.datasetToolStripMenuItemDataset,
            this.graphPictureToolStripMenuItemGraphPicture});
            this.SaveConfigToolStripMenuItemSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SaveConfigToolStripMenuItemSave.Name = "SaveConfigToolStripMenuItemSave";
            this.SaveConfigToolStripMenuItemSave.Size = new System.Drawing.Size(180, 22);
            this.SaveConfigToolStripMenuItemSave.Text = "Save";
            // 
            // ConfigurationToolStripMenuItemConfiguration
            // 
            this.ConfigurationToolStripMenuItemConfiguration.Name = "ConfigurationToolStripMenuItemConfiguration";
            this.ConfigurationToolStripMenuItemConfiguration.Size = new System.Drawing.Size(180, 22);
            this.ConfigurationToolStripMenuItemConfiguration.Text = "Configuration";
            this.ConfigurationToolStripMenuItemConfiguration.Visible = false;
            this.ConfigurationToolStripMenuItemConfiguration.Click += new System.EventHandler(this.buttonConfigurationSaveConfiguration_Click);
            // 
            // datasetToolStripMenuItemDataset
            // 
            this.datasetToolStripMenuItemDataset.Name = "datasetToolStripMenuItemDataset";
            this.datasetToolStripMenuItemDataset.Size = new System.Drawing.Size(180, 22);
            this.datasetToolStripMenuItemDataset.Text = "Numeric Data";
            this.datasetToolStripMenuItemDataset.Visible = false;
            this.datasetToolStripMenuItemDataset.Click += new System.EventHandler(this.buttonDashboardSaveFile_Click);
            // 
            // graphPictureToolStripMenuItemGraphPicture
            // 
            this.graphPictureToolStripMenuItemGraphPicture.Name = "graphPictureToolStripMenuItemGraphPicture";
            this.graphPictureToolStripMenuItemGraphPicture.Size = new System.Drawing.Size(180, 22);
            this.graphPictureToolStripMenuItemGraphPicture.Text = "Graph Picture";
            this.graphPictureToolStripMenuItemGraphPicture.Click += new System.EventHandler(this.buttonDashboardSaveGraphImage_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GotoToolStripMenuItem
            // 
            this.GotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItemDahshboard,
            this.setupConfigToolStripMenuItemSetupAndConfig});
            this.GotoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GotoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GotoToolStripMenuItem.Name = "GotoToolStripMenuItem";
            this.GotoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.GotoToolStripMenuItem.Text = "&Goto";
            this.GotoToolStripMenuItem.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.GotoToolStripMenuItem.MouseHover += new System.EventHandler(this.GotoToolStripMenuItem_MouseHover);
            // 
            // dashboardToolStripMenuItemDahshboard
            // 
            this.dashboardToolStripMenuItemDahshboard.Name = "dashboardToolStripMenuItemDahshboard";
            this.dashboardToolStripMenuItemDahshboard.Size = new System.Drawing.Size(180, 22);
            this.dashboardToolStripMenuItemDahshboard.Text = "Dashboard";
            this.dashboardToolStripMenuItemDahshboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            this.dashboardToolStripMenuItemDahshboard.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.dashboardToolStripMenuItemDahshboard.MouseHover += new System.EventHandler(this.dashboardToolStripMenuItemDahshboard_MouseHover);
            // 
            // setupConfigToolStripMenuItemSetupAndConfig
            // 
            this.setupConfigToolStripMenuItemSetupAndConfig.Name = "setupConfigToolStripMenuItemSetupAndConfig";
            this.setupConfigToolStripMenuItemSetupAndConfig.Size = new System.Drawing.Size(180, 22);
            this.setupConfigToolStripMenuItemSetupAndConfig.Text = "Setup && Config";
            this.setupConfigToolStripMenuItemSetupAndConfig.Click += new System.EventHandler(this.buttonMenuBarConfiguration_Click);
            this.setupConfigToolStripMenuItemSetupAndConfig.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.setupConfigToolStripMenuItemSetupAndConfig.MouseHover += new System.EventHandler(this.setupConfigToolStripMenuItemSetupAndConfig_MouseHover);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItemAbout.Text = "&About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(-1, 109);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(187, 25);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.Color.Transparent;
            this.statusStripMain.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 647);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(186, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "Status";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabelMain.Text = "Status";
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelMainTitle.Location = new System.Drawing.Point(20, 17);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(75, 32);
            this.labelMainTitle.TabIndex = 2;
            this.labelMainTitle.Text = "Title";
            // 
            // panelMainHeader
            // 
            this.panelMainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelMainHeader.Controls.Add(this.panel1);
            this.panelMainHeader.Controls.Add(this.textBoxMainConnectivity);
            this.panelMainHeader.Controls.Add(this.textBoxMainUserName);
            this.panelMainHeader.Controls.Add(this.labelSoftwareVersion);
            this.panelMainHeader.Controls.Add(this.labelMainTitle);
            this.panelMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainHeader.Location = new System.Drawing.Point(186, 0);
            this.panelMainHeader.Name = "panelMainHeader";
            this.panelMainHeader.Size = new System.Drawing.Size(765, 68);
            this.panelMainHeader.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 81);
            this.panel1.TabIndex = 6;
            // 
            // textBoxMainConnectivity
            // 
            this.textBoxMainConnectivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMainConnectivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxMainConnectivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainConnectivity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMainConnectivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxMainConnectivity.ForeColor = System.Drawing.Color.Red;
            this.textBoxMainConnectivity.Location = new System.Drawing.Point(653, 31);
            this.textBoxMainConnectivity.Name = "textBoxMainConnectivity";
            this.textBoxMainConnectivity.Size = new System.Drawing.Size(100, 13);
            this.textBoxMainConnectivity.TabIndex = 5;
            this.textBoxMainConnectivity.TabStop = false;
            this.textBoxMainConnectivity.Text = "Disconnected";
            this.textBoxMainConnectivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMainConnectivity.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxMainConnectivity.MouseHover += new System.EventHandler(this.textBoxMainConnectivity_MouseHover);
            // 
            // textBoxMainUserName
            // 
            this.textBoxMainUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMainUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxMainUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMainUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMainUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxMainUserName.Location = new System.Drawing.Point(653, 9);
            this.textBoxMainUserName.Multiline = true;
            this.textBoxMainUserName.Name = "textBoxMainUserName";
            this.textBoxMainUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMainUserName.TabIndex = 4;
            this.textBoxMainUserName.TabStop = false;
            this.textBoxMainUserName.Text = "User Name";
            this.textBoxMainUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMainUserName.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxMainUserName.MouseHover += new System.EventHandler(this.textBoxMainUserName_MouseHover);
            // 
            // labelSoftwareVersion
            // 
            this.labelSoftwareVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoftwareVersion.AutoSize = true;
            this.labelSoftwareVersion.Enabled = false;
            this.labelSoftwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoftwareVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.labelSoftwareVersion.Location = new System.Drawing.Point(681, 50);
            this.labelSoftwareVersion.Name = "labelSoftwareVersion";
            this.labelSoftwareVersion.Size = new System.Drawing.Size(72, 13);
            this.labelSoftwareVersion.TabIndex = 3;
            this.labelSoftwareVersion.Text = "Version: 1.0.0";
            this.labelSoftwareVersion.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.labelSoftwareVersion.MouseHover += new System.EventHandler(this.labelSoftwareVersion_MouseHover);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelFormLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFormLoader.Controls.Add(this.tabControlMain);
            this.panelFormLoader.Location = new System.Drawing.Point(186, 74);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(765, 595);
            this.panelFormLoader.TabIndex = 1;
            // 
            // ConnectivityChecker
            // 
            this.ConnectivityChecker.Enabled = true;
            this.ConnectivityChecker.Tick += new System.EventHandler(this.ConnectivityChecker_Tick);
            // 
            // timerStatusBarChecker
            // 
            this.timerStatusBarChecker.Enabled = true;
            this.timerStatusBarChecker.Interval = 50;
            this.timerStatusBarChecker.Tick += new System.EventHandler(this.timerStatusBarChecker_Tick);
            // 
            // timerTabContoller
            // 
            this.timerTabContoller.Enabled = true;
            this.timerTabContoller.Tick += new System.EventHandler(this.timerTabContoller_Tick);
            // 
            // timerDashboardDataInformation
            // 
            this.timerDashboardDataInformation.Enabled = true;
            this.timerDashboardDataInformation.Interval = 250;
            this.timerDashboardDataInformation.Tick += new System.EventHandler(this.timerDashboardDataInformation_Tick);
            // 
            // timerWifiImageChecker
            // 
            this.timerWifiImageChecker.Enabled = true;
            this.timerWifiImageChecker.Interval = 250;
            this.timerWifiImageChecker.Tick += new System.EventHandler(this.timerWifiImageChecker_Tick);
            // 
            // timerSerialDataRequester
            // 
            this.timerSerialDataRequester.Interval = 1000;
            this.timerSerialDataRequester.Tick += new System.EventHandler(this.timerSerialDataRequester_Tick);
            // 
            // timerDataChartUpdater
            // 
            this.timerDataChartUpdater.Interval = 1000;
            this.timerDataChartUpdater.Tick += new System.EventHandler(this.timerDataChartUpdater_Tick);
            // 
            // timerAlarmRequester
            // 
            this.timerAlarmRequester.Interval = 500;
            this.timerAlarmRequester.Tick += new System.EventHandler(this.timerAlarmRequester_Tick);
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tabPageConfiguration.Controls.Add(this.textBoxConfigurationDeviceName);
            this.tabPageConfiguration.Controls.Add(this.panelConfigurationConfiguration);
            this.tabPageConfiguration.Controls.Add(this.panelConfigurationSetup);
            this.tabPageConfiguration.Controls.Add(this.comboBoxConfigurationChoseBaudRate);
            this.tabPageConfiguration.Controls.Add(this.comboBoxConfigurationSerialPorts);
            this.tabPageConfiguration.Location = new System.Drawing.Point(19, 4);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Size = new System.Drawing.Size(742, 587);
            this.tabPageConfiguration.TabIndex = 1;
            // 
            // textBoxConfigurationDeviceName
            // 
            this.textBoxConfigurationDeviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConfigurationDeviceName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxConfigurationDeviceName.Enabled = false;
            this.textBoxConfigurationDeviceName.Location = new System.Drawing.Point(68, 504);
            this.textBoxConfigurationDeviceName.MaxLength = 10;
            this.textBoxConfigurationDeviceName.Name = "textBoxConfigurationDeviceName";
            this.textBoxConfigurationDeviceName.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationDeviceName.TabIndex = 4;
            this.toolTipConfigDeviceName.SetToolTip(this.textBoxConfigurationDeviceName, "Device name has to be a size of 10");
            this.textBoxConfigurationDeviceName.Visible = false;
            this.textBoxConfigurationDeviceName.Leave += new System.EventHandler(this.textBoxConfigurationDeviceName_Leave);
            this.textBoxConfigurationDeviceName.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxConfigurationDeviceName.MouseHover += new System.EventHandler(this.textBoxConfigurationDeviceName_MouseHover);
            // 
            // comboBoxConfigurationSerialPorts
            // 
            this.comboBoxConfigurationSerialPorts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxConfigurationSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigurationSerialPorts.Enabled = false;
            this.comboBoxConfigurationSerialPorts.FormattingEnabled = true;
            this.comboBoxConfigurationSerialPorts.Location = new System.Drawing.Point(68, 477);
            this.comboBoxConfigurationSerialPorts.Name = "comboBoxConfigurationSerialPorts";
            this.comboBoxConfigurationSerialPorts.Size = new System.Drawing.Size(118, 21);
            this.comboBoxConfigurationSerialPorts.TabIndex = 0;
            this.comboBoxConfigurationSerialPorts.Visible = false;
            this.comboBoxConfigurationSerialPorts.Enter += new System.EventHandler(this.comboBoxConfigurationSerialPorts_Enter);
            this.comboBoxConfigurationSerialPorts.Leave += new System.EventHandler(this.comboBoxConfigurationSerialPorts_Leave);
            this.comboBoxConfigurationSerialPorts.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.comboBoxConfigurationSerialPorts.MouseHover += new System.EventHandler(this.comboBoxConfigurationSerialPorts_MouseHover);
            // 
            // comboBoxConfigurationChoseBaudRate
            // 
            this.comboBoxConfigurationChoseBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxConfigurationChoseBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigurationChoseBaudRate.Enabled = false;
            this.comboBoxConfigurationChoseBaudRate.FormattingEnabled = true;
            this.comboBoxConfigurationChoseBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.comboBoxConfigurationChoseBaudRate.Location = new System.Drawing.Point(68, 450);
            this.comboBoxConfigurationChoseBaudRate.Name = "comboBoxConfigurationChoseBaudRate";
            this.comboBoxConfigurationChoseBaudRate.Size = new System.Drawing.Size(118, 21);
            this.comboBoxConfigurationChoseBaudRate.TabIndex = 1;
            this.comboBoxConfigurationChoseBaudRate.Visible = false;
            this.comboBoxConfigurationChoseBaudRate.Leave += new System.EventHandler(this.comboBoxConfigurationChoseBaudRate_Leave);
            this.comboBoxConfigurationChoseBaudRate.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.comboBoxConfigurationChoseBaudRate.MouseHover += new System.EventHandler(this.comboBoxConfigurationChoseBaudRate_MouseHover);
            // 
            // panelConfigurationSetup
            // 
            this.panelConfigurationSetup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelConfigurationSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelConfigurationSetup.Controls.Add(this.comboBoxSetupDAUDeviceName);
            this.panelConfigurationSetup.Controls.Add(this.comboBoxSetupDAUID);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAUCountry);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAUFacility);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupArea);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAUAreaCode);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupLastUpdated);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAUInstallmentDate);
            this.panelConfigurationSetup.Controls.Add(this.label12);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAULastUpdated);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAUBaudRate);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupDAUComPort);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupBaudRate);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupComPort);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupDeviceName);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupDAUID);
            this.panelConfigurationSetup.Controls.Add(this.pictureBox7);
            this.panelConfigurationSetup.Controls.Add(this.textBoxSetupRDCIPAddress);
            this.panelConfigurationSetup.Controls.Add(this.comboBoxSetupRDCID);
            this.panelConfigurationSetup.Controls.Add(this.pictureBoxConfigurationWifi);
            this.panelConfigurationSetup.Controls.Add(this.buttonConfigurationDisconnect);
            this.panelConfigurationSetup.Controls.Add(this.buttonConfigurationConnect);
            this.panelConfigurationSetup.Controls.Add(this.labelConfigurationSetup);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupRDCID);
            this.panelConfigurationSetup.Controls.Add(this.labelSetupIpAddress);
            this.panelConfigurationSetup.Location = new System.Drawing.Point(68, 7);
            this.panelConfigurationSetup.Name = "panelConfigurationSetup";
            this.panelConfigurationSetup.Size = new System.Drawing.Size(292, 437);
            this.panelConfigurationSetup.TabIndex = 18;
            // 
            // labelSetupIpAddress
            // 
            this.labelSetupIpAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSetupIpAddress.AutoSize = true;
            this.labelSetupIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupIpAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupIpAddress.Location = new System.Drawing.Point(8, 96);
            this.labelSetupIpAddress.Name = "labelSetupIpAddress";
            this.labelSetupIpAddress.Size = new System.Drawing.Size(104, 16);
            this.labelSetupIpAddress.TabIndex = 34;
            this.labelSetupIpAddress.Text = "IPv4 Address:";
            // 
            // labelSetupRDCID
            // 
            this.labelSetupRDCID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSetupRDCID.AutoSize = true;
            this.labelSetupRDCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupRDCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupRDCID.Location = new System.Drawing.Point(8, 48);
            this.labelSetupRDCID.Name = "labelSetupRDCID";
            this.labelSetupRDCID.Size = new System.Drawing.Size(63, 16);
            this.labelSetupRDCID.TabIndex = 33;
            this.labelSetupRDCID.Text = "RDC ID:";
            // 
            // labelConfigurationSetup
            // 
            this.labelConfigurationSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfigurationSetup.AutoSize = true;
            this.labelConfigurationSetup.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationSetup.Location = new System.Drawing.Point(6, 9);
            this.labelConfigurationSetup.Name = "labelConfigurationSetup";
            this.labelConfigurationSetup.Size = new System.Drawing.Size(64, 25);
            this.labelConfigurationSetup.TabIndex = 7;
            this.labelConfigurationSetup.Text = "Setup";
            // 
            // buttonConfigurationConnect
            // 
            this.buttonConfigurationConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfigurationConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfigurationConnect.FlatAppearance.BorderSize = 0;
            this.buttonConfigurationConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurationConnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfigurationConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfigurationConnect.Location = new System.Drawing.Point(84, 391);
            this.buttonConfigurationConnect.Name = "buttonConfigurationConnect";
            this.buttonConfigurationConnect.Size = new System.Drawing.Size(91, 34);
            this.buttonConfigurationConnect.TabIndex = 2;
            this.buttonConfigurationConnect.Text = "Connect";
            this.buttonConfigurationConnect.UseVisualStyleBackColor = false;
            this.buttonConfigurationConnect.Click += new System.EventHandler(this.buttonConfigurationConnect_Click);
            this.buttonConfigurationConnect.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonConfigurationConnect.MouseHover += new System.EventHandler(this.buttonConfigurationConnect_MouseHover);
            // 
            // buttonConfigurationDisconnect
            // 
            this.buttonConfigurationDisconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfigurationDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfigurationDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonConfigurationDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurationDisconnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfigurationDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfigurationDisconnect.Location = new System.Drawing.Point(193, 391);
            this.buttonConfigurationDisconnect.Name = "buttonConfigurationDisconnect";
            this.buttonConfigurationDisconnect.Size = new System.Drawing.Size(91, 34);
            this.buttonConfigurationDisconnect.TabIndex = 3;
            this.buttonConfigurationDisconnect.Text = "Disconnect";
            this.buttonConfigurationDisconnect.UseVisualStyleBackColor = false;
            this.buttonConfigurationDisconnect.Click += new System.EventHandler(this.buttonConfigurationDisconnect_Click_1);
            this.buttonConfigurationDisconnect.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonConfigurationDisconnect.MouseHover += new System.EventHandler(this.buttonConfigurationDisconnect_MouseHover);
            // 
            // pictureBoxConfigurationWifi
            // 
            this.pictureBoxConfigurationWifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxConfigurationWifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxConfigurationWifi.Location = new System.Drawing.Point(141, 9);
            this.pictureBoxConfigurationWifi.Name = "pictureBoxConfigurationWifi";
            this.pictureBoxConfigurationWifi.Size = new System.Drawing.Size(141, 129);
            this.pictureBoxConfigurationWifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfigurationWifi.TabIndex = 33;
            this.pictureBoxConfigurationWifi.TabStop = false;
            // 
            // comboBoxSetupRDCID
            // 
            this.comboBoxSetupRDCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetupRDCID.FormattingEnabled = true;
            this.comboBoxSetupRDCID.Location = new System.Drawing.Point(11, 67);
            this.comboBoxSetupRDCID.Name = "comboBoxSetupRDCID";
            this.comboBoxSetupRDCID.Size = new System.Drawing.Size(118, 21);
            this.comboBoxSetupRDCID.TabIndex = 35;
            this.comboBoxSetupRDCID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetupRDCID_SelectedIndexChanged);
            this.comboBoxSetupRDCID.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // textBoxSetupRDCIPAddress
            // 
            this.textBoxSetupRDCIPAddress.Enabled = false;
            this.textBoxSetupRDCIPAddress.Location = new System.Drawing.Point(11, 115);
            this.textBoxSetupRDCIPAddress.Name = "textBoxSetupRDCIPAddress";
            this.textBoxSetupRDCIPAddress.Size = new System.Drawing.Size(118, 20);
            this.textBoxSetupRDCIPAddress.TabIndex = 103;
            this.textBoxSetupRDCIPAddress.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(11, 144);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(271, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 104;
            this.pictureBox7.TabStop = false;
            // 
            // labelSetupDAUID
            // 
            this.labelSetupDAUID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSetupDAUID.AutoSize = true;
            this.labelSetupDAUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupDAUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupDAUID.Location = new System.Drawing.Point(8, 184);
            this.labelSetupDAUID.Name = "labelSetupDAUID";
            this.labelSetupDAUID.Size = new System.Drawing.Size(63, 16);
            this.labelSetupDAUID.TabIndex = 105;
            this.labelSetupDAUID.Text = "DAU ID:";
            // 
            // labelSetupDeviceName
            // 
            this.labelSetupDeviceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSetupDeviceName.AutoSize = true;
            this.labelSetupDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupDeviceName.Location = new System.Drawing.Point(8, 232);
            this.labelSetupDeviceName.Name = "labelSetupDeviceName";
            this.labelSetupDeviceName.Size = new System.Drawing.Size(106, 16);
            this.labelSetupDeviceName.TabIndex = 106;
            this.labelSetupDeviceName.Text = "Device Name:";
            // 
            // labelSetupComPort
            // 
            this.labelSetupComPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSetupComPort.AutoSize = true;
            this.labelSetupComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupComPort.Location = new System.Drawing.Point(7, 280);
            this.labelSetupComPort.Name = "labelSetupComPort";
            this.labelSetupComPort.Size = new System.Drawing.Size(71, 16);
            this.labelSetupComPort.TabIndex = 107;
            this.labelSetupComPort.Text = "ComPort:";
            // 
            // labelSetupBaudRate
            // 
            this.labelSetupBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSetupBaudRate.AutoSize = true;
            this.labelSetupBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupBaudRate.Location = new System.Drawing.Point(8, 327);
            this.labelSetupBaudRate.Name = "labelSetupBaudRate";
            this.labelSetupBaudRate.Size = new System.Drawing.Size(81, 16);
            this.labelSetupBaudRate.TabIndex = 108;
            this.labelSetupBaudRate.Text = "BaudRate:";
            // 
            // textBoxSetupDAUComPort
            // 
            this.textBoxSetupDAUComPort.Enabled = false;
            this.textBoxSetupDAUComPort.Location = new System.Drawing.Point(11, 299);
            this.textBoxSetupDAUComPort.Name = "textBoxSetupDAUComPort";
            this.textBoxSetupDAUComPort.Size = new System.Drawing.Size(118, 20);
            this.textBoxSetupDAUComPort.TabIndex = 110;
            this.textBoxSetupDAUComPort.MouseLeave += new System.EventHandler(this.comboBoxConfigurationChoseBaudRate_Leave);
            this.textBoxSetupDAUComPort.MouseHover += new System.EventHandler(this.textBoxSetupDAUComPort_MouseHover);
            // 
            // textBoxSetupDAUBaudRate
            // 
            this.textBoxSetupDAUBaudRate.Enabled = false;
            this.textBoxSetupDAUBaudRate.Location = new System.Drawing.Point(11, 346);
            this.textBoxSetupDAUBaudRate.Name = "textBoxSetupDAUBaudRate";
            this.textBoxSetupDAUBaudRate.Size = new System.Drawing.Size(118, 20);
            this.textBoxSetupDAUBaudRate.TabIndex = 111;
            this.textBoxSetupDAUBaudRate.MouseLeave += new System.EventHandler(this.comboBoxConfigurationChoseBaudRate_Leave);
            this.textBoxSetupDAUBaudRate.MouseHover += new System.EventHandler(this.textBoxSetupDAUBaudRate_MouseHover);
            // 
            // textBoxSetupDAULastUpdated
            // 
            this.textBoxSetupDAULastUpdated.Enabled = false;
            this.textBoxSetupDAULastUpdated.Location = new System.Drawing.Point(164, 251);
            this.textBoxSetupDAULastUpdated.Name = "textBoxSetupDAULastUpdated";
            this.textBoxSetupDAULastUpdated.Size = new System.Drawing.Size(120, 20);
            this.textBoxSetupDAULastUpdated.TabIndex = 145;
            this.textBoxSetupDAULastUpdated.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.label12.Location = new System.Drawing.Point(161, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 146;
            this.label12.Text = "Install Date:";
            // 
            // textBoxSetupDAUInstallmentDate
            // 
            this.textBoxSetupDAUInstallmentDate.Enabled = false;
            this.textBoxSetupDAUInstallmentDate.Location = new System.Drawing.Point(164, 203);
            this.textBoxSetupDAUInstallmentDate.Name = "textBoxSetupDAUInstallmentDate";
            this.textBoxSetupDAUInstallmentDate.Size = new System.Drawing.Size(120, 20);
            this.textBoxSetupDAUInstallmentDate.TabIndex = 147;
            this.textBoxSetupDAUInstallmentDate.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // labelSetupLastUpdated
            // 
            this.labelSetupLastUpdated.AutoSize = true;
            this.labelSetupLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSetupLastUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupLastUpdated.Location = new System.Drawing.Point(161, 232);
            this.labelSetupLastUpdated.Name = "labelSetupLastUpdated";
            this.labelSetupLastUpdated.Size = new System.Drawing.Size(105, 16);
            this.labelSetupLastUpdated.TabIndex = 148;
            this.labelSetupLastUpdated.Text = "Last Updated:";
            // 
            // textBoxSetupDAUAreaCode
            // 
            this.textBoxSetupDAUAreaCode.Enabled = false;
            this.textBoxSetupDAUAreaCode.Location = new System.Drawing.Point(164, 299);
            this.textBoxSetupDAUAreaCode.Name = "textBoxSetupDAUAreaCode";
            this.textBoxSetupDAUAreaCode.Size = new System.Drawing.Size(42, 20);
            this.textBoxSetupDAUAreaCode.TabIndex = 149;
            this.textBoxSetupDAUAreaCode.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // labelSetupArea
            // 
            this.labelSetupArea.AutoSize = true;
            this.labelSetupArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSetupArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelSetupArea.Location = new System.Drawing.Point(161, 280);
            this.labelSetupArea.Name = "labelSetupArea";
            this.labelSetupArea.Size = new System.Drawing.Size(45, 16);
            this.labelSetupArea.TabIndex = 150;
            this.labelSetupArea.Text = "Area:";
            // 
            // textBoxSetupDAUFacility
            // 
            this.textBoxSetupDAUFacility.Enabled = false;
            this.textBoxSetupDAUFacility.Location = new System.Drawing.Point(212, 299);
            this.textBoxSetupDAUFacility.Name = "textBoxSetupDAUFacility";
            this.textBoxSetupDAUFacility.Size = new System.Drawing.Size(72, 20);
            this.textBoxSetupDAUFacility.TabIndex = 151;
            this.textBoxSetupDAUFacility.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // textBoxSetupDAUCountry
            // 
            this.textBoxSetupDAUCountry.Enabled = false;
            this.textBoxSetupDAUCountry.Location = new System.Drawing.Point(164, 325);
            this.textBoxSetupDAUCountry.Name = "textBoxSetupDAUCountry";
            this.textBoxSetupDAUCountry.Size = new System.Drawing.Size(120, 20);
            this.textBoxSetupDAUCountry.TabIndex = 152;
            this.textBoxSetupDAUCountry.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // comboBoxSetupDAUID
            // 
            this.comboBoxSetupDAUID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetupDAUID.FormattingEnabled = true;
            this.comboBoxSetupDAUID.Location = new System.Drawing.Point(11, 203);
            this.comboBoxSetupDAUID.Name = "comboBoxSetupDAUID";
            this.comboBoxSetupDAUID.Size = new System.Drawing.Size(118, 21);
            this.comboBoxSetupDAUID.TabIndex = 153;
            this.comboBoxSetupDAUID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetupDAUID_SelectedIndexChanged);
            this.comboBoxSetupDAUID.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // comboBoxSetupDAUDeviceName
            // 
            this.comboBoxSetupDAUDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetupDAUDeviceName.FormattingEnabled = true;
            this.comboBoxSetupDAUDeviceName.Location = new System.Drawing.Point(11, 251);
            this.comboBoxSetupDAUDeviceName.Name = "comboBoxSetupDAUDeviceName";
            this.comboBoxSetupDAUDeviceName.Size = new System.Drawing.Size(118, 21);
            this.comboBoxSetupDAUDeviceName.TabIndex = 154;
            this.comboBoxSetupDAUDeviceName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetupDAUDeviceName_SelectedIndexChanged);
            this.comboBoxSetupDAUDeviceName.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // panelConfigurationConfiguration
            // 
            this.panelConfigurationConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelConfigurationConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationLastUpdated);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationLastUpdated);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationComType);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationCommunicationType);
            this.panelConfigurationConfiguration.Controls.Add(this.comboBoxConfigurationTag);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationCountry);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationScanningFrequency);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationFacility);
            this.panelConfigurationConfiguration.Controls.Add(this.label11);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationScanningFrequency);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationAreaCode);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationIOType);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationIType);
            this.panelConfigurationConfiguration.Controls.Add(this.buttonConfigurationRquestDeviceConfig);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationAlarmHigh);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationAlarmHigh);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationDeviceName);
            this.panelConfigurationConfiguration.Controls.Add(this.buttonConfigurationLoadConfiguration);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationAlarmLow);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationAlarmLow);
            this.panelConfigurationConfiguration.Controls.Add(this.buttonConfigurationSendConfiguration);
            this.panelConfigurationConfiguration.Controls.Add(this.buttonConfigurationSaveConfiguration);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationAlertLRV);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationAlertURV);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationLRV);
            this.panelConfigurationConfiguration.Controls.Add(this.textBoxConfigurationURV);
            this.panelConfigurationConfiguration.Controls.Add(this.labelConfigurationConfiguration);
            this.panelConfigurationConfiguration.Location = new System.Drawing.Point(385, 7);
            this.panelConfigurationConfiguration.Name = "panelConfigurationConfiguration";
            this.panelConfigurationConfiguration.Size = new System.Drawing.Size(292, 437);
            this.panelConfigurationConfiguration.TabIndex = 19;
            // 
            // labelConfigurationConfiguration
            // 
            this.labelConfigurationConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationConfiguration.AutoSize = true;
            this.labelConfigurationConfiguration.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationConfiguration.Location = new System.Drawing.Point(4, 9);
            this.labelConfigurationConfiguration.Name = "labelConfigurationConfiguration";
            this.labelConfigurationConfiguration.Size = new System.Drawing.Size(138, 25);
            this.labelConfigurationConfiguration.TabIndex = 6;
            this.labelConfigurationConfiguration.Text = "Configuration";
            // 
            // textBoxConfigurationURV
            // 
            this.textBoxConfigurationURV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfigurationURV.Enabled = false;
            this.textBoxConfigurationURV.Location = new System.Drawing.Point(118, 115);
            this.textBoxConfigurationURV.MaxLength = 7;
            this.textBoxConfigurationURV.Name = "textBoxConfigurationURV";
            this.textBoxConfigurationURV.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationURV.TabIndex = 8;
            this.textBoxConfigurationURV.TextChanged += new System.EventHandler(this.textBoxConfigurationURV_TextChanged);
            this.textBoxConfigurationURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfigurationURV_KeyPress);
            this.textBoxConfigurationURV.Leave += new System.EventHandler(this.textBoxConfigurationURV_Leave);
            this.textBoxConfigurationURV.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxConfigurationURV.MouseHover += new System.EventHandler(this.textBoxConfigurationURV_MouseHover);
            // 
            // textBoxConfigurationLRV
            // 
            this.textBoxConfigurationLRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfigurationLRV.Enabled = false;
            this.textBoxConfigurationLRV.Location = new System.Drawing.Point(118, 82);
            this.textBoxConfigurationLRV.MaxLength = 7;
            this.textBoxConfigurationLRV.Name = "textBoxConfigurationLRV";
            this.textBoxConfigurationLRV.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationLRV.TabIndex = 7;
            this.textBoxConfigurationLRV.TextChanged += new System.EventHandler(this.textBoxConfigurationLRV_TextChanged);
            this.textBoxConfigurationLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfigurationLRV_KeyPress);
            this.textBoxConfigurationLRV.Leave += new System.EventHandler(this.textBoxConfigurationLRV_Leave);
            this.textBoxConfigurationLRV.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxConfigurationLRV.MouseHover += new System.EventHandler(this.textBoxConfigurationLRV_MouseHover);
            // 
            // labelConfigurationAlertURV
            // 
            this.labelConfigurationAlertURV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationAlertURV.AutoSize = true;
            this.labelConfigurationAlertURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationAlertURV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationAlertURV.Location = new System.Drawing.Point(6, 116);
            this.labelConfigurationAlertURV.Name = "labelConfigurationAlertURV";
            this.labelConfigurationAlertURV.Size = new System.Drawing.Size(44, 16);
            this.labelConfigurationAlertURV.TabIndex = 42;
            this.labelConfigurationAlertURV.Text = "URV:";
            // 
            // labelConfigurationAlertLRV
            // 
            this.labelConfigurationAlertLRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationAlertLRV.AutoSize = true;
            this.labelConfigurationAlertLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationAlertLRV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationAlertLRV.Location = new System.Drawing.Point(6, 83);
            this.labelConfigurationAlertLRV.Name = "labelConfigurationAlertLRV";
            this.labelConfigurationAlertLRV.Size = new System.Drawing.Size(41, 16);
            this.labelConfigurationAlertLRV.TabIndex = 43;
            this.labelConfigurationAlertLRV.Text = "LRV:";
            // 
            // buttonConfigurationSaveConfiguration
            // 
            this.buttonConfigurationSaveConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfigurationSaveConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfigurationSaveConfiguration.BackgroundImage = global::SoftSensConf.Properties.Resources.Save_File_Icon;
            this.buttonConfigurationSaveConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfigurationSaveConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonConfigurationSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurationSaveConfiguration.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfigurationSaveConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfigurationSaveConfiguration.Location = new System.Drawing.Point(143, 392);
            this.buttonConfigurationSaveConfiguration.Name = "buttonConfigurationSaveConfiguration";
            this.buttonConfigurationSaveConfiguration.Size = new System.Drawing.Size(42, 33);
            this.buttonConfigurationSaveConfiguration.TabIndex = 12;
            this.buttonConfigurationSaveConfiguration.UseVisualStyleBackColor = false;
            this.buttonConfigurationSaveConfiguration.Visible = false;
            this.buttonConfigurationSaveConfiguration.Click += new System.EventHandler(this.buttonConfigurationSaveConfiguration_Click);
            this.buttonConfigurationSaveConfiguration.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonConfigurationSaveConfiguration.MouseHover += new System.EventHandler(this.buttonConfigurationSaveConfiguration_MouseHover);
            // 
            // buttonConfigurationSendConfiguration
            // 
            this.buttonConfigurationSendConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfigurationSendConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfigurationSendConfiguration.BackgroundImage = global::SoftSensConf.Properties.Resources.Send_Config;
            this.buttonConfigurationSendConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfigurationSendConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonConfigurationSendConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurationSendConfiguration.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfigurationSendConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfigurationSendConfiguration.Location = new System.Drawing.Point(240, 392);
            this.buttonConfigurationSendConfiguration.Name = "buttonConfigurationSendConfiguration";
            this.buttonConfigurationSendConfiguration.Size = new System.Drawing.Size(42, 33);
            this.buttonConfigurationSendConfiguration.TabIndex = 9;
            this.buttonConfigurationSendConfiguration.UseVisualStyleBackColor = false;
            this.buttonConfigurationSendConfiguration.Click += new System.EventHandler(this.buttonConfigurationSendConfiguration_Click);
            this.buttonConfigurationSendConfiguration.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonConfigurationSendConfiguration.MouseHover += new System.EventHandler(this.buttonConfigurationSendConfiguration_MouseHover);
            // 
            // textBoxConfigurationAlarmLow
            // 
            this.textBoxConfigurationAlarmLow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConfigurationAlarmLow.Enabled = false;
            this.textBoxConfigurationAlarmLow.Location = new System.Drawing.Point(118, 149);
            this.textBoxConfigurationAlarmLow.MaxLength = 4;
            this.textBoxConfigurationAlarmLow.Name = "textBoxConfigurationAlarmLow";
            this.textBoxConfigurationAlarmLow.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationAlarmLow.TabIndex = 5;
            this.toolTipConfigDeviceName.SetToolTip(this.textBoxConfigurationAlarmLow, "Case sensetive password. Max length: 10");
            this.textBoxConfigurationAlarmLow.TextChanged += new System.EventHandler(this.textBoxConfigurationAlarmLow_TextChanged);
            this.textBoxConfigurationAlarmLow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfigurationAlarmLow_KeyPress);
            this.textBoxConfigurationAlarmLow.Leave += new System.EventHandler(this.textBoxConfigurationAlarmLow_Leave);
            this.textBoxConfigurationAlarmLow.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxConfigurationAlarmLow.MouseHover += new System.EventHandler(this.textBoxConfigurationAlarmLow_MouseHover);
            // 
            // labelConfigurationAlarmLow
            // 
            this.labelConfigurationAlarmLow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfigurationAlarmLow.AutoSize = true;
            this.labelConfigurationAlarmLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationAlarmLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationAlarmLow.Location = new System.Drawing.Point(6, 150);
            this.labelConfigurationAlarmLow.Name = "labelConfigurationAlarmLow";
            this.labelConfigurationAlarmLow.Size = new System.Drawing.Size(83, 16);
            this.labelConfigurationAlarmLow.TabIndex = 32;
            this.labelConfigurationAlarmLow.Text = "Alarm Low:";
            // 
            // buttonConfigurationLoadConfiguration
            // 
            this.buttonConfigurationLoadConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfigurationLoadConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfigurationLoadConfiguration.BackgroundImage = global::SoftSensConf.Properties.Resources.Load_Current_Config;
            this.buttonConfigurationLoadConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfigurationLoadConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonConfigurationLoadConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurationLoadConfiguration.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfigurationLoadConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfigurationLoadConfiguration.Location = new System.Drawing.Point(93, 392);
            this.buttonConfigurationLoadConfiguration.Name = "buttonConfigurationLoadConfiguration";
            this.buttonConfigurationLoadConfiguration.Size = new System.Drawing.Size(42, 33);
            this.buttonConfigurationLoadConfiguration.TabIndex = 11;
            this.buttonConfigurationLoadConfiguration.UseVisualStyleBackColor = false;
            this.buttonConfigurationLoadConfiguration.Visible = false;
            this.buttonConfigurationLoadConfiguration.Click += new System.EventHandler(this.buttonConfigurationLoadConfiguration_Click);
            this.buttonConfigurationLoadConfiguration.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonConfigurationLoadConfiguration.MouseHover += new System.EventHandler(this.buttonConfigurationLoadConfiguration_MouseHover);
            // 
            // labelConfigurationDeviceName
            // 
            this.labelConfigurationDeviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfigurationDeviceName.AutoSize = true;
            this.labelConfigurationDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationDeviceName.Location = new System.Drawing.Point(6, 51);
            this.labelConfigurationDeviceName.Name = "labelConfigurationDeviceName";
            this.labelConfigurationDeviceName.Size = new System.Drawing.Size(93, 16);
            this.labelConfigurationDeviceName.TabIndex = 45;
            this.labelConfigurationDeviceName.Text = "Device Tag:";
            // 
            // textBoxConfigurationAlarmHigh
            // 
            this.textBoxConfigurationAlarmHigh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfigurationAlarmHigh.Enabled = false;
            this.textBoxConfigurationAlarmHigh.Location = new System.Drawing.Point(118, 181);
            this.textBoxConfigurationAlarmHigh.MaxLength = 4;
            this.textBoxConfigurationAlarmHigh.Name = "textBoxConfigurationAlarmHigh";
            this.textBoxConfigurationAlarmHigh.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationAlarmHigh.TabIndex = 6;
            this.textBoxConfigurationAlarmHigh.TextChanged += new System.EventHandler(this.textBoxConfigurationAlarmHigh_TextChanged);
            this.textBoxConfigurationAlarmHigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfigurationAlarmHigh_KeyPress);
            this.textBoxConfigurationAlarmHigh.Leave += new System.EventHandler(this.textBoxConfigurationAlarmHigh_Leave);
            this.textBoxConfigurationAlarmHigh.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxConfigurationAlarmHigh.MouseHover += new System.EventHandler(this.textBoxConfigurationAlarmHigh_MouseHover);
            // 
            // labelConfigurationAlarmHigh
            // 
            this.labelConfigurationAlarmHigh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationAlarmHigh.AutoSize = true;
            this.labelConfigurationAlarmHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationAlarmHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationAlarmHigh.Location = new System.Drawing.Point(6, 182);
            this.labelConfigurationAlarmHigh.Name = "labelConfigurationAlarmHigh";
            this.labelConfigurationAlarmHigh.Size = new System.Drawing.Size(88, 16);
            this.labelConfigurationAlarmHigh.TabIndex = 47;
            this.labelConfigurationAlarmHigh.Text = "Alarm High:";
            // 
            // buttonConfigurationRquestDeviceConfig
            // 
            this.buttonConfigurationRquestDeviceConfig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfigurationRquestDeviceConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfigurationRquestDeviceConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfigurationRquestDeviceConfig.BackgroundImage")));
            this.buttonConfigurationRquestDeviceConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfigurationRquestDeviceConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfigurationRquestDeviceConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurationRquestDeviceConfig.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfigurationRquestDeviceConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfigurationRquestDeviceConfig.Location = new System.Drawing.Point(192, 392);
            this.buttonConfigurationRquestDeviceConfig.Name = "buttonConfigurationRquestDeviceConfig";
            this.buttonConfigurationRquestDeviceConfig.Size = new System.Drawing.Size(42, 33);
            this.buttonConfigurationRquestDeviceConfig.TabIndex = 13;
            this.buttonConfigurationRquestDeviceConfig.UseVisualStyleBackColor = false;
            this.buttonConfigurationRquestDeviceConfig.Visible = false;
            this.buttonConfigurationRquestDeviceConfig.Click += new System.EventHandler(this.buttonConfigurationRquestDeviceConfig_Click);
            this.buttonConfigurationRquestDeviceConfig.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonConfigurationRquestDeviceConfig.MouseHover += new System.EventHandler(this.buttonConfigurationRquestDeviceConfig_MouseHover);
            // 
            // textBoxConfigurationIType
            // 
            this.textBoxConfigurationIType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfigurationIType.Enabled = false;
            this.textBoxConfigurationIType.Location = new System.Drawing.Point(118, 212);
            this.textBoxConfigurationIType.MaxLength = 4;
            this.textBoxConfigurationIType.Name = "textBoxConfigurationIType";
            this.textBoxConfigurationIType.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationIType.TabIndex = 48;
            this.textBoxConfigurationIType.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // labelConfigurationIOType
            // 
            this.labelConfigurationIOType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationIOType.AutoSize = true;
            this.labelConfigurationIOType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationIOType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationIOType.Location = new System.Drawing.Point(6, 213);
            this.labelConfigurationIOType.Name = "labelConfigurationIOType";
            this.labelConfigurationIOType.Size = new System.Drawing.Size(67, 16);
            this.labelConfigurationIOType.TabIndex = 49;
            this.labelConfigurationIOType.Text = "IO Type:";
            // 
            // textBoxConfigurationAreaCode
            // 
            this.textBoxConfigurationAreaCode.Enabled = false;
            this.textBoxConfigurationAreaCode.Location = new System.Drawing.Point(118, 305);
            this.textBoxConfigurationAreaCode.Name = "textBoxConfigurationAreaCode";
            this.textBoxConfigurationAreaCode.Size = new System.Drawing.Size(42, 20);
            this.textBoxConfigurationAreaCode.TabIndex = 153;
            this.textBoxConfigurationAreaCode.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // textBoxConfigurationScanningFrequency
            // 
            this.textBoxConfigurationScanningFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfigurationScanningFrequency.Enabled = false;
            this.textBoxConfigurationScanningFrequency.Location = new System.Drawing.Point(118, 274);
            this.textBoxConfigurationScanningFrequency.MaxLength = 4;
            this.textBoxConfigurationScanningFrequency.Name = "textBoxConfigurationScanningFrequency";
            this.textBoxConfigurationScanningFrequency.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationScanningFrequency.TabIndex = 50;
            this.textBoxConfigurationScanningFrequency.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.label11.Location = new System.Drawing.Point(6, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 154;
            this.label11.Text = "Area:";
            // 
            // textBoxConfigurationFacility
            // 
            this.textBoxConfigurationFacility.Enabled = false;
            this.textBoxConfigurationFacility.Location = new System.Drawing.Point(166, 305);
            this.textBoxConfigurationFacility.Name = "textBoxConfigurationFacility";
            this.textBoxConfigurationFacility.Size = new System.Drawing.Size(74, 20);
            this.textBoxConfigurationFacility.TabIndex = 155;
            this.textBoxConfigurationFacility.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // labelConfigurationScanningFrequency
            // 
            this.labelConfigurationScanningFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationScanningFrequency.AutoSize = true;
            this.labelConfigurationScanningFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationScanningFrequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationScanningFrequency.Location = new System.Drawing.Point(6, 275);
            this.labelConfigurationScanningFrequency.Name = "labelConfigurationScanningFrequency";
            this.labelConfigurationScanningFrequency.Size = new System.Drawing.Size(110, 16);
            this.labelConfigurationScanningFrequency.TabIndex = 51;
            this.labelConfigurationScanningFrequency.Text = "Scan. Frq (Hz):";
            // 
            // textBoxConfigurationCountry
            // 
            this.textBoxConfigurationCountry.Enabled = false;
            this.textBoxConfigurationCountry.Location = new System.Drawing.Point(118, 331);
            this.textBoxConfigurationCountry.Name = "textBoxConfigurationCountry";
            this.textBoxConfigurationCountry.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationCountry.TabIndex = 156;
            this.textBoxConfigurationCountry.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // comboBoxConfigurationTag
            // 
            this.comboBoxConfigurationTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigurationTag.FormattingEnabled = true;
            this.comboBoxConfigurationTag.Location = new System.Drawing.Point(118, 50);
            this.comboBoxConfigurationTag.Name = "comboBoxConfigurationTag";
            this.comboBoxConfigurationTag.Size = new System.Drawing.Size(122, 21);
            this.comboBoxConfigurationTag.TabIndex = 157;
            this.comboBoxConfigurationTag.SelectedIndexChanged += new System.EventHandler(this.comboBoxConfigurationDeviceName_SelectedIndexChanged);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tabPageDashboard.Controls.Add(this.panel4);
            this.tabPageDashboard.Controls.Add(this.panel2);
            this.tabPageDashboard.Controls.Add(this.panelDashboardControl);
            this.tabPageDashboard.Controls.Add(this.panelDashboardDataInformation);
            this.tabPageDashboard.Controls.Add(this.panelDashboardChart);
            this.tabPageDashboard.Location = new System.Drawing.Point(19, 4);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(742, 587);
            this.tabPageDashboard.TabIndex = 0;
            // 
            // panelDashboardChart
            // 
            this.panelDashboardChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashboardChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelDashboardChart.Controls.Add(this.panel6);
            this.panelDashboardChart.Controls.Add(this.panel3);
            this.panelDashboardChart.Controls.Add(this.chartDashboardChartScaled);
            this.panelDashboardChart.Controls.Add(this.chartDashboardChartRaw);
            this.panelDashboardChart.Controls.Add(this.labelDashboardGraph);
            this.panelDashboardChart.Controls.Add(this.pictureBox4);
            this.panelDashboardChart.Location = new System.Drawing.Point(8, 213);
            this.panelDashboardChart.Name = "panelDashboardChart";
            this.panelDashboardChart.Size = new System.Drawing.Size(725, 371);
            this.panelDashboardChart.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(569, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // labelDashboardGraph
            // 
            this.labelDashboardGraph.AutoSize = true;
            this.labelDashboardGraph.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardGraph.Location = new System.Drawing.Point(6, 10);
            this.labelDashboardGraph.Name = "labelDashboardGraph";
            this.labelDashboardGraph.Size = new System.Drawing.Size(115, 25);
            this.labelDashboardGraph.TabIndex = 6;
            this.labelDashboardGraph.Text = "Scaled Data";
            // 
            // chartDashboardChartRaw
            // 
            this.chartDashboardChartRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDashboardChartRaw.BackColor = System.Drawing.Color.Transparent;
            this.chartDashboardChartRaw.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Title = "Time [ s ]";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.Title = "Raw Value";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartDashboardChartRaw.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.chartDashboardChartRaw.Legends.Add(legend3);
            this.chartDashboardChartRaw.Location = new System.Drawing.Point(3, 56);
            this.chartDashboardChartRaw.Name = "chartDashboardChartRaw";
            this.chartDashboardChartRaw.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.Legend = "Legend1";
            series3.Name = "RawData";
            this.chartDashboardChartRaw.Series.Add(series3);
            this.chartDashboardChartRaw.Size = new System.Drawing.Size(474, 312);
            this.chartDashboardChartRaw.TabIndex = 35;
            this.chartDashboardChartRaw.TabStop = false;
            this.chartDashboardChartRaw.Text = "Data";
            this.chartDashboardChartRaw.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.chartDashboardChartRaw.MouseHover += new System.EventHandler(this.dataGridView1_MouseHover);
            // 
            // chartDashboardChartScaled
            // 
            this.chartDashboardChartScaled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDashboardChartScaled.BackColor = System.Drawing.Color.Transparent;
            this.chartDashboardChartScaled.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.Title = "Time [ s ]";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.Title = "Scaled  Value ";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartDashboardChartScaled.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Name = "Legend1";
            this.chartDashboardChartScaled.Legends.Add(legend4);
            this.chartDashboardChartScaled.Location = new System.Drawing.Point(3, 56);
            this.chartDashboardChartScaled.Name = "chartDashboardChartScaled";
            this.chartDashboardChartScaled.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.Legend = "Legend1";
            series4.Name = "ScaledData";
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chartDashboardChartScaled.Series.Add(series4);
            this.chartDashboardChartScaled.Size = new System.Drawing.Size(474, 312);
            this.chartDashboardChartScaled.TabIndex = 36;
            this.chartDashboardChartScaled.TabStop = false;
            this.chartDashboardChartScaled.Text = "Data";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(475, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 113);
            this.panel3.TabIndex = 47;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel5.Controls.Add(this.groupBoxDashboardGraphData);
            this.panel5.Location = new System.Drawing.Point(25, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 100);
            this.panel5.TabIndex = 1;
            // 
            // groupBoxDashboardGraphData
            // 
            this.groupBoxDashboardGraphData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDashboardGraphData.Controls.Add(this.radioButtonDashboardScaled);
            this.groupBoxDashboardGraphData.Controls.Add(this.radioButtonDashboardRaw);
            this.groupBoxDashboardGraphData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.groupBoxDashboardGraphData.Location = new System.Drawing.Point(45, 14);
            this.groupBoxDashboardGraphData.Name = "groupBoxDashboardGraphData";
            this.groupBoxDashboardGraphData.Size = new System.Drawing.Size(139, 75);
            this.groupBoxDashboardGraphData.TabIndex = 6;
            this.groupBoxDashboardGraphData.TabStop = false;
            this.groupBoxDashboardGraphData.Text = "Data Shown";
            // 
            // radioButtonDashboardRaw
            // 
            this.radioButtonDashboardRaw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonDashboardRaw.AutoSize = true;
            this.radioButtonDashboardRaw.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonDashboardRaw.Location = new System.Drawing.Point(88, 26);
            this.radioButtonDashboardRaw.Name = "radioButtonDashboardRaw";
            this.radioButtonDashboardRaw.Size = new System.Drawing.Size(33, 30);
            this.radioButtonDashboardRaw.TabIndex = 1;
            this.radioButtonDashboardRaw.Text = "Raw";
            this.radioButtonDashboardRaw.UseVisualStyleBackColor = true;
            this.radioButtonDashboardRaw.CheckedChanged += new System.EventHandler(this.radioButtonDashboardRaw_CheckedChanged);
            this.radioButtonDashboardRaw.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // radioButtonDashboardScaled
            // 
            this.radioButtonDashboardScaled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonDashboardScaled.AutoSize = true;
            this.radioButtonDashboardScaled.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonDashboardScaled.Checked = true;
            this.radioButtonDashboardScaled.Location = new System.Drawing.Point(28, 26);
            this.radioButtonDashboardScaled.Name = "radioButtonDashboardScaled";
            this.radioButtonDashboardScaled.Size = new System.Drawing.Size(44, 30);
            this.radioButtonDashboardScaled.TabIndex = 0;
            this.radioButtonDashboardScaled.TabStop = true;
            this.radioButtonDashboardScaled.Text = "Scaled";
            this.radioButtonDashboardScaled.UseVisualStyleBackColor = true;
            this.radioButtonDashboardScaled.CheckedChanged += new System.EventHandler(this.radioButtonDashboardScaled_CheckedChanged);
            this.radioButtonDashboardScaled.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(475, 236);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 139);
            this.panel6.TabIndex = 47;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel7.Controls.Add(this.textBoxDashboardAlarmLow);
            this.panel7.Controls.Add(this.textBoxDashboardAlarmHigh);
            this.panel7.Controls.Add(this.labelDashboardGraphURV);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.labelDashboardGraphLRV);
            this.panel7.Controls.Add(this.labelDashboardAlarmHigh);
            this.panel7.Controls.Add(this.textBoxDashboardURV);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.textBoxDashboardLRV);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.pictureBoxDashboardLine8);
            this.panel7.Controls.Add(this.pictureBoxDashboardLine7);
            this.panel7.Location = new System.Drawing.Point(26, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(224, 126);
            this.panel7.TabIndex = 1;
            // 
            // pictureBoxDashboardLine7
            // 
            this.pictureBoxDashboardLine7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardLine7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine7.Image")));
            this.pictureBoxDashboardLine7.Location = new System.Drawing.Point(7, 43);
            this.pictureBoxDashboardLine7.Name = "pictureBoxDashboardLine7";
            this.pictureBoxDashboardLine7.Size = new System.Drawing.Size(205, 25);
            this.pictureBoxDashboardLine7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine7.TabIndex = 33;
            this.pictureBoxDashboardLine7.TabStop = false;
            // 
            // pictureBoxDashboardLine8
            // 
            this.pictureBoxDashboardLine8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardLine8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine8.Image")));
            this.pictureBoxDashboardLine8.Location = new System.Drawing.Point(7, 21);
            this.pictureBoxDashboardLine8.Name = "pictureBoxDashboardLine8";
            this.pictureBoxDashboardLine8.Size = new System.Drawing.Size(205, 25);
            this.pictureBoxDashboardLine8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine8.TabIndex = 31;
            this.pictureBoxDashboardLine8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxDashboardLRV
            // 
            this.textBoxDashboardLRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDashboardLRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardLRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardLRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardLRV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardLRV.Location = new System.Drawing.Point(152, 15);
            this.textBoxDashboardLRV.Name = "textBoxDashboardLRV";
            this.textBoxDashboardLRV.Size = new System.Drawing.Size(60, 14);
            this.textBoxDashboardLRV.TabIndex = 32;
            this.textBoxDashboardLRV.TabStop = false;
            this.textBoxDashboardLRV.Text = "Lo-Ra-Va";
            this.textBoxDashboardLRV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardLRV.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardLRV.MouseHover += new System.EventHandler(this.textBoxDashboardLRV_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDashboardURV
            // 
            this.textBoxDashboardURV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDashboardURV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardURV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardURV.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardURV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardURV.Location = new System.Drawing.Point(152, 37);
            this.textBoxDashboardURV.Name = "textBoxDashboardURV";
            this.textBoxDashboardURV.Size = new System.Drawing.Size(60, 14);
            this.textBoxDashboardURV.TabIndex = 31;
            this.textBoxDashboardURV.TabStop = false;
            this.textBoxDashboardURV.Text = "Up-Ra-Va";
            this.textBoxDashboardURV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardURV.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardURV.MouseHover += new System.EventHandler(this.textBoxDashboardURV_MouseHover);
            // 
            // labelDashboardAlarmHigh
            // 
            this.labelDashboardAlarmHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDashboardAlarmHigh.AutoSize = true;
            this.labelDashboardAlarmHigh.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardAlarmHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardAlarmHigh.Location = new System.Drawing.Point(8, 83);
            this.labelDashboardAlarmHigh.Name = "labelDashboardAlarmHigh";
            this.labelDashboardAlarmHigh.Size = new System.Drawing.Size(83, 17);
            this.labelDashboardAlarmHigh.TabIndex = 37;
            this.labelDashboardAlarmHigh.Text = "Alarm High:";
            // 
            // labelDashboardGraphLRV
            // 
            this.labelDashboardGraphLRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDashboardGraphLRV.AutoSize = true;
            this.labelDashboardGraphLRV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardGraphLRV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardGraphLRV.Location = new System.Drawing.Point(8, 14);
            this.labelDashboardGraphLRV.Name = "labelDashboardGraphLRV";
            this.labelDashboardGraphLRV.Size = new System.Drawing.Size(129, 17);
            this.labelDashboardGraphLRV.TabIndex = 13;
            this.labelDashboardGraphLRV.Text = "Lower Range Value:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Alarm Low:";
            // 
            // labelDashboardGraphURV
            // 
            this.labelDashboardGraphURV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDashboardGraphURV.AutoSize = true;
            this.labelDashboardGraphURV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardGraphURV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardGraphURV.Location = new System.Drawing.Point(8, 36);
            this.labelDashboardGraphURV.Name = "labelDashboardGraphURV";
            this.labelDashboardGraphURV.Size = new System.Drawing.Size(129, 17);
            this.labelDashboardGraphURV.TabIndex = 12;
            this.labelDashboardGraphURV.Text = "Upper Range Value:";
            // 
            // textBoxDashboardAlarmHigh
            // 
            this.textBoxDashboardAlarmHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDashboardAlarmHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardAlarmHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardAlarmHigh.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardAlarmHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardAlarmHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardAlarmHigh.Location = new System.Drawing.Point(152, 84);
            this.textBoxDashboardAlarmHigh.Name = "textBoxDashboardAlarmHigh";
            this.textBoxDashboardAlarmHigh.Size = new System.Drawing.Size(60, 14);
            this.textBoxDashboardAlarmHigh.TabIndex = 39;
            this.textBoxDashboardAlarmHigh.TabStop = false;
            this.textBoxDashboardAlarmHigh.Text = "AL-HI-VA";
            this.textBoxDashboardAlarmHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardAlarmHigh.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardAlarmHigh.MouseHover += new System.EventHandler(this.textBoxDashboardAlarmHigh_MouseHover);
            // 
            // textBoxDashboardAlarmLow
            // 
            this.textBoxDashboardAlarmLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDashboardAlarmLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardAlarmLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardAlarmLow.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardAlarmLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardAlarmLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardAlarmLow.Location = new System.Drawing.Point(152, 62);
            this.textBoxDashboardAlarmLow.Name = "textBoxDashboardAlarmLow";
            this.textBoxDashboardAlarmLow.Size = new System.Drawing.Size(60, 14);
            this.textBoxDashboardAlarmLow.TabIndex = 41;
            this.textBoxDashboardAlarmLow.TabStop = false;
            this.textBoxDashboardAlarmLow.Text = "AL-LO-VA";
            this.textBoxDashboardAlarmLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardAlarmLow.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardAlarmLow.MouseHover += new System.EventHandler(this.textBoxDashboardAlarmLow_MouseHover);
            // 
            // panelDashboardDataInformation
            // 
            this.panelDashboardDataInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashboardDataInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardPortName);
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardDataType);
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardFrequency);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardFrequency);
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardDatapoints);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardDataType);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardDatapoints);
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardConnectivityStatus);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardConnectivityStatus);
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardDataStatus);
            this.panelDashboardDataInformation.Controls.Add(this.textBoxDashboardBaudRate);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardBaudRate);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardCurrentDataStatus);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardDataInformation);
            this.panelDashboardDataInformation.Controls.Add(this.labelDashboardPortName);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine2);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine3);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine4);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine6);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine5);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine1);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBoxDashboardLine9);
            this.panelDashboardDataInformation.Controls.Add(this.pictureBox8);
            this.panelDashboardDataInformation.Location = new System.Drawing.Point(509, 6);
            this.panelDashboardDataInformation.Name = "panelDashboardDataInformation";
            this.panelDashboardDataInformation.Size = new System.Drawing.Size(224, 187);
            this.panelDashboardDataInformation.TabIndex = 10;
            // 
            // pictureBoxDashboardLine9
            // 
            this.pictureBoxDashboardLine9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine9.Image")));
            this.pictureBoxDashboardLine9.Location = new System.Drawing.Point(7, 16);
            this.pictureBoxDashboardLine9.Name = "pictureBoxDashboardLine9";
            this.pictureBoxDashboardLine9.Size = new System.Drawing.Size(160, 25);
            this.pictureBoxDashboardLine9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine9.TabIndex = 31;
            this.pictureBoxDashboardLine9.TabStop = false;
            // 
            // pictureBoxDashboardLine1
            // 
            this.pictureBoxDashboardLine1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine1.Image")));
            this.pictureBoxDashboardLine1.Location = new System.Drawing.Point(7, 146);
            this.pictureBoxDashboardLine1.Name = "pictureBoxDashboardLine1";
            this.pictureBoxDashboardLine1.Size = new System.Drawing.Size(210, 25);
            this.pictureBoxDashboardLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine1.TabIndex = 30;
            this.pictureBoxDashboardLine1.TabStop = false;
            // 
            // pictureBoxDashboardLine5
            // 
            this.pictureBoxDashboardLine5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine5.Image")));
            this.pictureBoxDashboardLine5.Location = new System.Drawing.Point(7, 62);
            this.pictureBoxDashboardLine5.Name = "pictureBoxDashboardLine5";
            this.pictureBoxDashboardLine5.Size = new System.Drawing.Size(210, 25);
            this.pictureBoxDashboardLine5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine5.TabIndex = 29;
            this.pictureBoxDashboardLine5.TabStop = false;
            // 
            // pictureBoxDashboardLine6
            // 
            this.pictureBoxDashboardLine6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine6.Image")));
            this.pictureBoxDashboardLine6.Location = new System.Drawing.Point(7, 40);
            this.pictureBoxDashboardLine6.Name = "pictureBoxDashboardLine6";
            this.pictureBoxDashboardLine6.Size = new System.Drawing.Size(210, 25);
            this.pictureBoxDashboardLine6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine6.TabIndex = 28;
            this.pictureBoxDashboardLine6.TabStop = false;
            // 
            // pictureBoxDashboardLine4
            // 
            this.pictureBoxDashboardLine4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine4.Image")));
            this.pictureBoxDashboardLine4.Location = new System.Drawing.Point(7, 83);
            this.pictureBoxDashboardLine4.Name = "pictureBoxDashboardLine4";
            this.pictureBoxDashboardLine4.Size = new System.Drawing.Size(210, 25);
            this.pictureBoxDashboardLine4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine4.TabIndex = 27;
            this.pictureBoxDashboardLine4.TabStop = false;
            // 
            // pictureBoxDashboardLine3
            // 
            this.pictureBoxDashboardLine3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine3.Image")));
            this.pictureBoxDashboardLine3.Location = new System.Drawing.Point(7, 104);
            this.pictureBoxDashboardLine3.Name = "pictureBoxDashboardLine3";
            this.pictureBoxDashboardLine3.Size = new System.Drawing.Size(210, 25);
            this.pictureBoxDashboardLine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine3.TabIndex = 26;
            this.pictureBoxDashboardLine3.TabStop = false;
            // 
            // pictureBoxDashboardLine2
            // 
            this.pictureBoxDashboardLine2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardLine2.Image")));
            this.pictureBoxDashboardLine2.Location = new System.Drawing.Point(7, 125);
            this.pictureBoxDashboardLine2.Name = "pictureBoxDashboardLine2";
            this.pictureBoxDashboardLine2.Size = new System.Drawing.Size(210, 25);
            this.pictureBoxDashboardLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardLine2.TabIndex = 15;
            this.pictureBoxDashboardLine2.TabStop = false;
            // 
            // labelDashboardPortName
            // 
            this.labelDashboardPortName.AutoSize = true;
            this.labelDashboardPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardPortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardPortName.Location = new System.Drawing.Point(8, 34);
            this.labelDashboardPortName.Name = "labelDashboardPortName";
            this.labelDashboardPortName.Size = new System.Drawing.Size(85, 16);
            this.labelDashboardPortName.TabIndex = 14;
            this.labelDashboardPortName.Text = "Port Name:";
            // 
            // labelDashboardDataInformation
            // 
            this.labelDashboardDataInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDashboardDataInformation.AutoSize = true;
            this.labelDashboardDataInformation.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardDataInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardDataInformation.Location = new System.Drawing.Point(6, 3);
            this.labelDashboardDataInformation.Name = "labelDashboardDataInformation";
            this.labelDashboardDataInformation.Size = new System.Drawing.Size(166, 25);
            this.labelDashboardDataInformation.TabIndex = 7;
            this.labelDashboardDataInformation.Text = "Data Information";
            // 
            // labelDashboardCurrentDataStatus
            // 
            this.labelDashboardCurrentDataStatus.AutoSize = true;
            this.labelDashboardCurrentDataStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardCurrentDataStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardCurrentDataStatus.Location = new System.Drawing.Point(8, 98);
            this.labelDashboardCurrentDataStatus.Name = "labelDashboardCurrentDataStatus";
            this.labelDashboardCurrentDataStatus.Size = new System.Drawing.Size(92, 16);
            this.labelDashboardCurrentDataStatus.TabIndex = 15;
            this.labelDashboardCurrentDataStatus.Text = "Data Status:";
            // 
            // labelDashboardBaudRate
            // 
            this.labelDashboardBaudRate.AutoSize = true;
            this.labelDashboardBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardBaudRate.Location = new System.Drawing.Point(8, 57);
            this.labelDashboardBaudRate.Name = "labelDashboardBaudRate";
            this.labelDashboardBaudRate.Size = new System.Drawing.Size(85, 16);
            this.labelDashboardBaudRate.TabIndex = 16;
            this.labelDashboardBaudRate.Text = "Baud Rate:";
            // 
            // textBoxDashboardPortName
            // 
            this.textBoxDashboardPortName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardPortName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardPortName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardPortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardPortName.Location = new System.Drawing.Point(113, 31);
            this.textBoxDashboardPortName.Multiline = true;
            this.textBoxDashboardPortName.Name = "textBoxDashboardPortName";
            this.textBoxDashboardPortName.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardPortName.TabIndex = 17;
            this.textBoxDashboardPortName.TabStop = false;
            this.textBoxDashboardPortName.Text = "PortNameHere";
            this.textBoxDashboardPortName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardPortName.WordWrap = false;
            this.textBoxDashboardPortName.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardPortName.MouseHover += new System.EventHandler(this.textBoxDashboardPortName_MouseHover);
            // 
            // textBoxDashboardBaudRate
            // 
            this.textBoxDashboardBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardBaudRate.Location = new System.Drawing.Point(113, 54);
            this.textBoxDashboardBaudRate.Multiline = true;
            this.textBoxDashboardBaudRate.Name = "textBoxDashboardBaudRate";
            this.textBoxDashboardBaudRate.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardBaudRate.TabIndex = 18;
            this.textBoxDashboardBaudRate.TabStop = false;
            this.textBoxDashboardBaudRate.Text = "BaudRateHere";
            this.textBoxDashboardBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardBaudRate.WordWrap = false;
            this.textBoxDashboardBaudRate.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardBaudRate.MouseHover += new System.EventHandler(this.textBoxDashboardBaudRate_MouseHover);
            // 
            // textBoxDashboardDataStatus
            // 
            this.textBoxDashboardDataStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardDataStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardDataStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardDataStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardDataStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardDataStatus.Location = new System.Drawing.Point(113, 96);
            this.textBoxDashboardDataStatus.Multiline = true;
            this.textBoxDashboardDataStatus.Name = "textBoxDashboardDataStatus";
            this.textBoxDashboardDataStatus.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardDataStatus.TabIndex = 19;
            this.textBoxDashboardDataStatus.TabStop = false;
            this.textBoxDashboardDataStatus.Text = "Line/NotLive";
            this.textBoxDashboardDataStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardDataStatus.WordWrap = false;
            this.textBoxDashboardDataStatus.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardDataStatus.MouseHover += new System.EventHandler(this.textBoxDashboardDataStatus_MouseHover);
            // 
            // labelDashboardConnectivityStatus
            // 
            this.labelDashboardConnectivityStatus.AutoSize = true;
            this.labelDashboardConnectivityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardConnectivityStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardConnectivityStatus.Location = new System.Drawing.Point(8, 78);
            this.labelDashboardConnectivityStatus.Name = "labelDashboardConnectivityStatus";
            this.labelDashboardConnectivityStatus.Size = new System.Drawing.Size(96, 16);
            this.labelDashboardConnectivityStatus.TabIndex = 20;
            this.labelDashboardConnectivityStatus.Text = "Connectivity:";
            // 
            // textBoxDashboardConnectivityStatus
            // 
            this.textBoxDashboardConnectivityStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardConnectivityStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardConnectivityStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardConnectivityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardConnectivityStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardConnectivityStatus.Location = new System.Drawing.Point(113, 75);
            this.textBoxDashboardConnectivityStatus.Multiline = true;
            this.textBoxDashboardConnectivityStatus.Name = "textBoxDashboardConnectivityStatus";
            this.textBoxDashboardConnectivityStatus.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardConnectivityStatus.TabIndex = 21;
            this.textBoxDashboardConnectivityStatus.TabStop = false;
            this.textBoxDashboardConnectivityStatus.Text = "Connected?";
            this.textBoxDashboardConnectivityStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardConnectivityStatus.WordWrap = false;
            this.textBoxDashboardConnectivityStatus.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardConnectivityStatus.MouseHover += new System.EventHandler(this.textBoxDashboardConnectivityStatus_MouseHover);
            // 
            // labelDashboardDatapoints
            // 
            this.labelDashboardDatapoints.AutoSize = true;
            this.labelDashboardDatapoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardDatapoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardDatapoints.Location = new System.Drawing.Point(8, 161);
            this.labelDashboardDatapoints.Name = "labelDashboardDatapoints";
            this.labelDashboardDatapoints.Size = new System.Drawing.Size(87, 16);
            this.labelDashboardDatapoints.TabIndex = 22;
            this.labelDashboardDatapoints.Text = "Datapoints:";
            // 
            // labelDashboardDataType
            // 
            this.labelDashboardDataType.AutoSize = true;
            this.labelDashboardDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardDataType.Location = new System.Drawing.Point(8, 119);
            this.labelDashboardDataType.Name = "labelDashboardDataType";
            this.labelDashboardDataType.Size = new System.Drawing.Size(79, 16);
            this.labelDashboardDataType.TabIndex = 23;
            this.labelDashboardDataType.Text = "Data type:";
            // 
            // textBoxDashboardDatapoints
            // 
            this.textBoxDashboardDatapoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardDatapoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardDatapoints.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardDatapoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardDatapoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardDatapoints.Location = new System.Drawing.Point(113, 159);
            this.textBoxDashboardDatapoints.Multiline = true;
            this.textBoxDashboardDatapoints.Name = "textBoxDashboardDatapoints";
            this.textBoxDashboardDatapoints.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardDatapoints.TabIndex = 24;
            this.textBoxDashboardDatapoints.TabStop = false;
            this.textBoxDashboardDatapoints.Text = "DataPnts-Count";
            this.textBoxDashboardDatapoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardDatapoints.WordWrap = false;
            this.textBoxDashboardDatapoints.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardDatapoints.MouseHover += new System.EventHandler(this.textBoxDashboardDatapoints_MouseHover);
            // 
            // panelDashboardControl
            // 
            this.panelDashboardControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashboardControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelDashboardControl.Controls.Add(this.listBoxDashboardTextDataScaled);
            this.panelDashboardControl.Controls.Add(this.buttonDashboardSaveFile);
            this.panelDashboardControl.Controls.Add(this.buttonDashboardResetDatapoints);
            this.panelDashboardControl.Controls.Add(this.buttonDashboardSaveGraphImage);
            this.panelDashboardControl.Controls.Add(this.listBoxDashboardTextDataRaw);
            this.panelDashboardControl.Controls.Add(this.buttonDashboardStopReceiving);
            this.panelDashboardControl.Controls.Add(this.buttonDashboardStartRecordingData);
            this.panelDashboardControl.Controls.Add(this.label2);
            this.panelDashboardControl.Location = new System.Drawing.Point(8, 6);
            this.panelDashboardControl.Name = "panelDashboardControl";
            this.panelDashboardControl.Size = new System.Drawing.Size(477, 187);
            this.panelDashboardControl.TabIndex = 8;
            this.panelDashboardControl.TabStop = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datapoints";
            // 
            // buttonDashboardStartRecordingData
            // 
            this.buttonDashboardStartRecordingData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDashboardStartRecordingData.FlatAppearance.BorderSize = 0;
            this.buttonDashboardStartRecordingData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardStartRecordingData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDashboardStartRecordingData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDashboardStartRecordingData.Location = new System.Drawing.Point(11, 43);
            this.buttonDashboardStartRecordingData.Name = "buttonDashboardStartRecordingData";
            this.buttonDashboardStartRecordingData.Size = new System.Drawing.Size(119, 34);
            this.buttonDashboardStartRecordingData.TabIndex = 1;
            this.buttonDashboardStartRecordingData.Text = "Start Receiving";
            this.buttonDashboardStartRecordingData.UseVisualStyleBackColor = false;
            this.buttonDashboardStartRecordingData.Click += new System.EventHandler(this.buttonDashboardStartRecordingData_Click);
            this.buttonDashboardStartRecordingData.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonDashboardStartRecordingData.MouseHover += new System.EventHandler(this.buttonDashboardStartRecordingData_MouseHover);
            // 
            // buttonDashboardStopReceiving
            // 
            this.buttonDashboardStopReceiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDashboardStopReceiving.FlatAppearance.BorderSize = 0;
            this.buttonDashboardStopReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardStopReceiving.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDashboardStopReceiving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDashboardStopReceiving.Location = new System.Drawing.Point(11, 83);
            this.buttonDashboardStopReceiving.Name = "buttonDashboardStopReceiving";
            this.buttonDashboardStopReceiving.Size = new System.Drawing.Size(119, 34);
            this.buttonDashboardStopReceiving.TabIndex = 2;
            this.buttonDashboardStopReceiving.Text = "Stop Receiving";
            this.buttonDashboardStopReceiving.UseVisualStyleBackColor = false;
            this.buttonDashboardStopReceiving.Click += new System.EventHandler(this.buttonDashboardStopReceiving_Click);
            this.buttonDashboardStopReceiving.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonDashboardStopReceiving.MouseHover += new System.EventHandler(this.buttonDashboardStopReceiving_MouseHover);
            // 
            // listBoxDashboardTextDataRaw
            // 
            this.listBoxDashboardTextDataRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDashboardTextDataRaw.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxDashboardTextDataRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDashboardTextDataRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listBoxDashboardTextDataRaw.FormattingEnabled = true;
            this.listBoxDashboardTextDataRaw.ItemHeight = 15;
            this.listBoxDashboardTextDataRaw.Location = new System.Drawing.Point(168, 8);
            this.listBoxDashboardTextDataRaw.Name = "listBoxDashboardTextDataRaw";
            this.listBoxDashboardTextDataRaw.ScrollAlwaysVisible = true;
            this.listBoxDashboardTextDataRaw.Size = new System.Drawing.Size(291, 124);
            this.listBoxDashboardTextDataRaw.TabIndex = 13;
            this.listBoxDashboardTextDataRaw.TabStop = false;
            // 
            // buttonDashboardSaveGraphImage
            // 
            this.buttonDashboardSaveGraphImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDashboardSaveGraphImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDashboardSaveGraphImage.BackgroundImage = global::SoftSensConf.Properties.Resources.Picture_Icon;
            this.buttonDashboardSaveGraphImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDashboardSaveGraphImage.FlatAppearance.BorderSize = 0;
            this.buttonDashboardSaveGraphImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardSaveGraphImage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDashboardSaveGraphImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDashboardSaveGraphImage.Location = new System.Drawing.Point(327, 137);
            this.buttonDashboardSaveGraphImage.Name = "buttonDashboardSaveGraphImage";
            this.buttonDashboardSaveGraphImage.Size = new System.Drawing.Size(42, 33);
            this.buttonDashboardSaveGraphImage.TabIndex = 4;
            this.buttonDashboardSaveGraphImage.UseVisualStyleBackColor = false;
            this.buttonDashboardSaveGraphImage.Click += new System.EventHandler(this.buttonDashboardSaveGraphImage_Click);
            this.buttonDashboardSaveGraphImage.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonDashboardSaveGraphImage.MouseHover += new System.EventHandler(this.buttonDashboardSaveGraphImage_MouseHover);
            // 
            // buttonDashboardResetDatapoints
            // 
            this.buttonDashboardResetDatapoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDashboardResetDatapoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDashboardResetDatapoints.FlatAppearance.BorderSize = 0;
            this.buttonDashboardResetDatapoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardResetDatapoints.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDashboardResetDatapoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDashboardResetDatapoints.Location = new System.Drawing.Point(387, 136);
            this.buttonDashboardResetDatapoints.Name = "buttonDashboardResetDatapoints";
            this.buttonDashboardResetDatapoints.Size = new System.Drawing.Size(72, 34);
            this.buttonDashboardResetDatapoints.TabIndex = 5;
            this.buttonDashboardResetDatapoints.Text = "Reset";
            this.buttonDashboardResetDatapoints.UseVisualStyleBackColor = false;
            this.buttonDashboardResetDatapoints.Click += new System.EventHandler(this.buttonDashboardResetDatapoints_Click);
            this.buttonDashboardResetDatapoints.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonDashboardResetDatapoints.MouseHover += new System.EventHandler(this.buttonDashboardResetDatapoints_MouseHover);
            // 
            // buttonDashboardSaveFile
            // 
            this.buttonDashboardSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDashboardSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDashboardSaveFile.BackgroundImage = global::SoftSensConf.Properties.Resources.Save_File_Icon;
            this.buttonDashboardSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDashboardSaveFile.FlatAppearance.BorderSize = 0;
            this.buttonDashboardSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardSaveFile.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDashboardSaveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDashboardSaveFile.Location = new System.Drawing.Point(271, 137);
            this.buttonDashboardSaveFile.Name = "buttonDashboardSaveFile";
            this.buttonDashboardSaveFile.Size = new System.Drawing.Size(42, 33);
            this.buttonDashboardSaveFile.TabIndex = 3;
            this.buttonDashboardSaveFile.UseVisualStyleBackColor = false;
            this.buttonDashboardSaveFile.Click += new System.EventHandler(this.buttonDashboardSaveFile_Click);
            this.buttonDashboardSaveFile.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.buttonDashboardSaveFile.MouseHover += new System.EventHandler(this.buttonDashboardSaveFile_MouseHover);
            // 
            // listBoxDashboardTextDataScaled
            // 
            this.listBoxDashboardTextDataScaled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDashboardTextDataScaled.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxDashboardTextDataScaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDashboardTextDataScaled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listBoxDashboardTextDataScaled.FormattingEnabled = true;
            this.listBoxDashboardTextDataScaled.ItemHeight = 15;
            this.listBoxDashboardTextDataScaled.Location = new System.Drawing.Point(168, 8);
            this.listBoxDashboardTextDataScaled.Name = "listBoxDashboardTextDataScaled";
            this.listBoxDashboardTextDataScaled.ScrollAlwaysVisible = true;
            this.listBoxDashboardTextDataScaled.Size = new System.Drawing.Size(291, 124);
            this.listBoxDashboardTextDataScaled.TabIndex = 14;
            this.listBoxDashboardTextDataScaled.TabStop = false;
            this.listBoxDashboardTextDataScaled.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.listBoxDashboardTextDataScaled.MouseHover += new System.EventHandler(this.listBoxDashboardTextData_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(483, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 133);
            this.panel2.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel4.Controls.Add(this.labelDashboardFaultyData);
            this.panel4.Controls.Add(this.labelDashboardDeviceStatus);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBoxDashboardError);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.textBoxDashboardError);
            this.panel4.Controls.Add(this.textBoxDashboardFaultyData);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Location = new System.Drawing.Point(508, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 126);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(8, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(206, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(206, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // textBoxDashboardFaultyData
            // 
            this.textBoxDashboardFaultyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDashboardFaultyData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardFaultyData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardFaultyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardFaultyData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDashboardFaultyData.Location = new System.Drawing.Point(132, 74);
            this.textBoxDashboardFaultyData.Multiline = true;
            this.textBoxDashboardFaultyData.Name = "textBoxDashboardFaultyData";
            this.textBoxDashboardFaultyData.Size = new System.Drawing.Size(85, 20);
            this.textBoxDashboardFaultyData.TabIndex = 43;
            this.textBoxDashboardFaultyData.TabStop = false;
            this.textBoxDashboardFaultyData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDashboardError
            // 
            this.textBoxDashboardError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDashboardError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardError.Location = new System.Drawing.Point(132, 48);
            this.textBoxDashboardError.Multiline = true;
            this.textBoxDashboardError.Name = "textBoxDashboardError";
            this.textBoxDashboardError.Size = new System.Drawing.Size(85, 20);
            this.textBoxDashboardError.TabIndex = 32;
            this.textBoxDashboardError.TabStop = false;
            this.textBoxDashboardError.Text = "OK!";
            this.textBoxDashboardError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxDashboardError
            // 
            this.pictureBoxDashboardError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxDashboardError.BackgroundImage = global::SoftSensConf.Properties.Resources.AlertInactive;
            this.pictureBoxDashboardError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDashboardError.Location = new System.Drawing.Point(177, 10);
            this.pictureBoxDashboardError.Name = "pictureBoxDashboardError";
            this.pictureBoxDashboardError.Size = new System.Drawing.Size(36, 33);
            this.pictureBoxDashboardError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDashboardError.TabIndex = 34;
            this.pictureBoxDashboardError.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // labelDashboardDeviceStatus
            // 
            this.labelDashboardDeviceStatus.AutoSize = true;
            this.labelDashboardDeviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardDeviceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardDeviceStatus.Location = new System.Drawing.Point(9, 48);
            this.labelDashboardDeviceStatus.Name = "labelDashboardDeviceStatus";
            this.labelDashboardDeviceStatus.Size = new System.Drawing.Size(106, 16);
            this.labelDashboardDeviceStatus.TabIndex = 49;
            this.labelDashboardDeviceStatus.Text = "Device status:";
            // 
            // labelDashboardFaultyData
            // 
            this.labelDashboardFaultyData.AutoSize = true;
            this.labelDashboardFaultyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardFaultyData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardFaultyData.Location = new System.Drawing.Point(9, 74);
            this.labelDashboardFaultyData.Name = "labelDashboardFaultyData";
            this.labelDashboardFaultyData.Size = new System.Drawing.Size(89, 16);
            this.labelDashboardFaultyData.TabIndex = 50;
            this.labelDashboardFaultyData.Text = "Faulty data:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMain.Controls.Add(this.tabPageDashboard);
            this.tabControlMain.Controls.Add(this.tabPageConfiguration);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(0, 0);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(765, 595);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // labelConfigurationComType
            // 
            this.labelConfigurationComType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfigurationComType.AutoSize = true;
            this.labelConfigurationComType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurationComType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationComType.Location = new System.Drawing.Point(6, 244);
            this.labelConfigurationComType.Name = "labelConfigurationComType";
            this.labelConfigurationComType.Size = new System.Drawing.Size(87, 16);
            this.labelConfigurationComType.TabIndex = 159;
            this.labelConfigurationComType.Text = "Com. Type:";
            // 
            // textBoxConfigurationCommunicationType
            // 
            this.textBoxConfigurationCommunicationType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfigurationCommunicationType.Enabled = false;
            this.textBoxConfigurationCommunicationType.Location = new System.Drawing.Point(118, 243);
            this.textBoxConfigurationCommunicationType.MaxLength = 4;
            this.textBoxConfigurationCommunicationType.Name = "textBoxConfigurationCommunicationType";
            this.textBoxConfigurationCommunicationType.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationCommunicationType.TabIndex = 158;
            this.textBoxConfigurationCommunicationType.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            // 
            // textBoxDashboardFrequency
            // 
            this.textBoxDashboardFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardFrequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardFrequency.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardFrequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardFrequency.Location = new System.Drawing.Point(113, 138);
            this.textBoxDashboardFrequency.Multiline = true;
            this.textBoxDashboardFrequency.Name = "textBoxDashboardFrequency";
            this.textBoxDashboardFrequency.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardFrequency.TabIndex = 33;
            this.textBoxDashboardFrequency.TabStop = false;
            this.textBoxDashboardFrequency.Text = "Freq. in Hz";
            this.textBoxDashboardFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardFrequency.WordWrap = false;
            this.textBoxDashboardFrequency.MouseLeave += new System.EventHandler(this.resetStatusBarText);
            this.textBoxDashboardFrequency.MouseHover += new System.EventHandler(this.textBoxDashboardFrequency_MouseHover);
            // 
            // labelDashboardFrequency
            // 
            this.labelDashboardFrequency.AutoSize = true;
            this.labelDashboardFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardFrequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelDashboardFrequency.Location = new System.Drawing.Point(8, 140);
            this.labelDashboardFrequency.Name = "labelDashboardFrequency";
            this.labelDashboardFrequency.Size = new System.Drawing.Size(80, 16);
            this.labelDashboardFrequency.TabIndex = 32;
            this.labelDashboardFrequency.Text = "Freq. (Hz):";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(7, 167);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(210, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // textBoxDashboardDataType
            // 
            this.textBoxDashboardDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDashboardDataType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDashboardDataType.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDashboardDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDashboardDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textBoxDashboardDataType.Location = new System.Drawing.Point(113, 117);
            this.textBoxDashboardDataType.Multiline = true;
            this.textBoxDashboardDataType.Name = "textBoxDashboardDataType";
            this.textBoxDashboardDataType.Size = new System.Drawing.Size(104, 20);
            this.textBoxDashboardDataType.TabIndex = 36;
            this.textBoxDashboardDataType.TabStop = false;
            this.textBoxDashboardDataType.Text = "Digital";
            this.textBoxDashboardDataType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDashboardDataType.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "label4";
            // 
            // labelConfigurationLastUpdated
            // 
            this.labelConfigurationLastUpdated.AutoSize = true;
            this.labelConfigurationLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelConfigurationLastUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.labelConfigurationLastUpdated.Location = new System.Drawing.Point(6, 362);
            this.labelConfigurationLastUpdated.Name = "labelConfigurationLastUpdated";
            this.labelConfigurationLastUpdated.Size = new System.Drawing.Size(105, 16);
            this.labelConfigurationLastUpdated.TabIndex = 156;
            this.labelConfigurationLastUpdated.Text = "Last Updated:";
            // 
            // textBoxConfigurationLastUpdated
            // 
            this.textBoxConfigurationLastUpdated.Enabled = false;
            this.textBoxConfigurationLastUpdated.Location = new System.Drawing.Point(118, 362);
            this.textBoxConfigurationLastUpdated.Name = "textBoxConfigurationLastUpdated";
            this.textBoxConfigurationLastUpdated.Size = new System.Drawing.Size(122, 20);
            this.textBoxConfigurationLastUpdated.TabIndex = 155;
            // 
            // FormMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(951, 669);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panelMainHeader);
            this.Controls.Add(this.panelMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "FormMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.panelLogoPanel.ResumeLayout(false);
            this.panelLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoBox)).EndInit();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.panelMainHeader.ResumeLayout(false);
            this.panelMainHeader.PerformLayout();
            this.panelFormLoader.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.panelConfigurationSetup.ResumeLayout(false);
            this.panelConfigurationSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigurationWifi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelConfigurationConfiguration.ResumeLayout(false);
            this.panelConfigurationConfiguration.PerformLayout();
            this.tabPageDashboard.ResumeLayout(false);
            this.panelDashboardChart.ResumeLayout(false);
            this.panelDashboardChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardChartRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardChartScaled)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBoxDashboardGraphData.ResumeLayout(false);
            this.groupBoxDashboardGraphData.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDashboardDataInformation.ResumeLayout(false);
            this.panelDashboardDataInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardLine2)).EndInit();
            this.panelDashboardControl.ResumeLayout(false);
            this.panelDashboardControl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardError)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelLogoPanel;
        private System.Windows.Forms.PictureBox pictureBoxLogoBox;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.Button buttonMenuBarExit;
        private System.Windows.Forms.Button buttonMenuBarConfiguration;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Panel panelMainHeader;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItemFile;
        private System.Windows.Forms.Label labelSoftwareVersion;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.Timer ConnectivityChecker;
        private System.Windows.Forms.TextBox textBoxMainUserName;
        private System.Windows.Forms.TextBox textBoxMainConnectivity;
        private System.Windows.Forms.Timer timerStatusBarChecker;
        private System.Windows.Forms.ToolStripMenuItem LoadConfigToolStripMenuItemLoadConfig;
        private System.Windows.Forms.ToolStripMenuItem SaveConfigToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItemDahshboard;
        private System.Windows.Forms.ToolStripMenuItem setupConfigToolStripMenuItemSetupAndConfig;
        private System.Windows.Forms.ToolStripMenuItem ConfigurationToolStripMenuItemConfiguration;
        private System.Windows.Forms.ToolStripMenuItem datasetToolStripMenuItemDataset;
        private System.Windows.Forms.ToolStripMenuItem graphPictureToolStripMenuItemGraphPicture;
        private System.Windows.Forms.Timer timerTabContoller;
        private System.Windows.Forms.Timer timerDashboardDataInformation;
        private System.Windows.Forms.Timer timerWifiImageChecker;
        private System.Windows.Forms.Timer timerSerialDataRequester;
        private System.Windows.Forms.Timer timerDataChartUpdater;
        private System.Windows.Forms.ToolTip toolTipConfigDeviceName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem deviceConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileConfigToolStripMenuItem;
        private System.Windows.Forms.Timer timerAlarmRequester;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelDashboardFaultyData;
        private System.Windows.Forms.Label labelDashboardDeviceStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxDashboardError;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxDashboardError;
        private System.Windows.Forms.TextBox textBoxDashboardFaultyData;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDashboardControl;
        private System.Windows.Forms.ListBox listBoxDashboardTextDataScaled;
        private System.Windows.Forms.Button buttonDashboardSaveFile;
        private System.Windows.Forms.Button buttonDashboardResetDatapoints;
        private System.Windows.Forms.Button buttonDashboardSaveGraphImage;
        private System.Windows.Forms.ListBox listBoxDashboardTextDataRaw;
        private System.Windows.Forms.Button buttonDashboardStopReceiving;
        private System.Windows.Forms.Button buttonDashboardStartRecordingData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDashboardDataInformation;
        private System.Windows.Forms.TextBox textBoxDashboardDatapoints;
        private System.Windows.Forms.Label labelDashboardDataType;
        private System.Windows.Forms.Label labelDashboardDatapoints;
        private System.Windows.Forms.TextBox textBoxDashboardConnectivityStatus;
        private System.Windows.Forms.Label labelDashboardConnectivityStatus;
        private System.Windows.Forms.TextBox textBoxDashboardDataStatus;
        private System.Windows.Forms.TextBox textBoxDashboardBaudRate;
        private System.Windows.Forms.TextBox textBoxDashboardPortName;
        private System.Windows.Forms.Label labelDashboardBaudRate;
        private System.Windows.Forms.Label labelDashboardCurrentDataStatus;
        private System.Windows.Forms.Label labelDashboardDataInformation;
        private System.Windows.Forms.Label labelDashboardPortName;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine2;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine3;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine4;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine6;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine5;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine1;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine9;
        private System.Windows.Forms.Panel panelDashboardChart;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxDashboardAlarmLow;
        private System.Windows.Forms.TextBox textBoxDashboardAlarmHigh;
        private System.Windows.Forms.Label labelDashboardGraphURV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDashboardGraphLRV;
        private System.Windows.Forms.Label labelDashboardAlarmHigh;
        private System.Windows.Forms.TextBox textBoxDashboardURV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDashboardLRV;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine8;
        private System.Windows.Forms.PictureBox pictureBoxDashboardLine7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBoxDashboardGraphData;
        private System.Windows.Forms.RadioButton radioButtonDashboardScaled;
        private System.Windows.Forms.RadioButton radioButtonDashboardRaw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboardChartScaled;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboardChartRaw;
        private System.Windows.Forms.Label labelDashboardGraph;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TextBox textBoxConfigurationDeviceName;
        private System.Windows.Forms.Panel panelConfigurationConfiguration;
        private System.Windows.Forms.ComboBox comboBoxConfigurationTag;
        private System.Windows.Forms.TextBox textBoxConfigurationCountry;
        private System.Windows.Forms.Label labelConfigurationScanningFrequency;
        private System.Windows.Forms.TextBox textBoxConfigurationFacility;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxConfigurationScanningFrequency;
        private System.Windows.Forms.TextBox textBoxConfigurationAreaCode;
        private System.Windows.Forms.Label labelConfigurationIOType;
        private System.Windows.Forms.TextBox textBoxConfigurationIType;
        private System.Windows.Forms.Button buttonConfigurationRquestDeviceConfig;
        private System.Windows.Forms.Label labelConfigurationAlarmHigh;
        private System.Windows.Forms.TextBox textBoxConfigurationAlarmHigh;
        private System.Windows.Forms.Label labelConfigurationDeviceName;
        private System.Windows.Forms.Button buttonConfigurationLoadConfiguration;
        private System.Windows.Forms.Label labelConfigurationAlarmLow;
        private System.Windows.Forms.TextBox textBoxConfigurationAlarmLow;
        private System.Windows.Forms.Button buttonConfigurationSendConfiguration;
        private System.Windows.Forms.Button buttonConfigurationSaveConfiguration;
        private System.Windows.Forms.Label labelConfigurationAlertLRV;
        private System.Windows.Forms.Label labelConfigurationAlertURV;
        private System.Windows.Forms.TextBox textBoxConfigurationLRV;
        private System.Windows.Forms.TextBox textBoxConfigurationURV;
        private System.Windows.Forms.Label labelConfigurationConfiguration;
        private System.Windows.Forms.Panel panelConfigurationSetup;
        private System.Windows.Forms.ComboBox comboBoxSetupDAUDeviceName;
        private System.Windows.Forms.ComboBox comboBoxSetupDAUID;
        private System.Windows.Forms.TextBox textBoxSetupDAUCountry;
        private System.Windows.Forms.TextBox textBoxSetupDAUFacility;
        private System.Windows.Forms.Label labelSetupArea;
        private System.Windows.Forms.TextBox textBoxSetupDAUAreaCode;
        private System.Windows.Forms.Label labelSetupLastUpdated;
        private System.Windows.Forms.TextBox textBoxSetupDAUInstallmentDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSetupDAULastUpdated;
        private System.Windows.Forms.TextBox textBoxSetupDAUBaudRate;
        private System.Windows.Forms.TextBox textBoxSetupDAUComPort;
        private System.Windows.Forms.Label labelSetupBaudRate;
        private System.Windows.Forms.Label labelSetupComPort;
        private System.Windows.Forms.Label labelSetupDeviceName;
        private System.Windows.Forms.Label labelSetupDAUID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBoxSetupRDCIPAddress;
        private System.Windows.Forms.ComboBox comboBoxSetupRDCID;
        private System.Windows.Forms.PictureBox pictureBoxConfigurationWifi;
        private System.Windows.Forms.Button buttonConfigurationDisconnect;
        private System.Windows.Forms.Button buttonConfigurationConnect;
        private System.Windows.Forms.Label labelConfigurationSetup;
        private System.Windows.Forms.Label labelSetupRDCID;
        private System.Windows.Forms.Label labelSetupIpAddress;
        private System.Windows.Forms.ComboBox comboBoxConfigurationChoseBaudRate;
        private System.Windows.Forms.ComboBox comboBoxConfigurationSerialPorts;
        private System.Windows.Forms.Label labelConfigurationComType;
        private System.Windows.Forms.TextBox textBoxConfigurationCommunicationType;
        private System.Windows.Forms.TextBox textBoxDashboardFrequency;
        private System.Windows.Forms.Label labelDashboardFrequency;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox textBoxDashboardDataType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConfigurationLastUpdated;
        private System.Windows.Forms.TextBox textBoxConfigurationLastUpdated;
    }
    
}

