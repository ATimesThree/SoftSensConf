using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftSensConf
{
    public partial class FormMainForm : Form
    {
        public FormMainForm()
        {
            InitializeComponent();
        }
        static string connectSoftSensDB = ConfigurationManager.ConnectionStrings["softSensDBConnectionString"].ConnectionString;
        SqlConnection connect = new SqlConnection(connectSoftSensDB);



        /////////////// LOAD FORM ///////////////
        #region
        private void Form1_Load(object sender, EventArgs e)
        {
            //System Language
            #region


            //System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.InstalledUICulture;
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CurrentUICulture;

            if (ci.Name.Substring(0,2) == "nb")
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ",";

                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                GlobalDataContainerClass.SystemLang = "Norwegian";
                GlobalDataContainerClass.NumSeperator = ",";
            }
            else
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";

                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                GlobalDataContainerClass.NumSeperator = ".";
                GlobalDataContainerClass.SystemLang = "English";
            }
            #endregion

            labelSoftwareVersion.Text = "Version: " + GlobalDataContainerClass.SoftWareVersion;
            tabControlMain.SelectedTab = tabControlMain.TabPages["tabPageConfiguration"];

            //Get RDC from database
            #region
            try
            {
                string sqlSelectQuery = "SELECT RDC.RDC_ID FROM RDC ORDER BY RDC_ID ASC";
                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                connect.Open();

                SqlDataReader rdcDataReader = command.ExecuteReader();

                comboBoxSetupRDCID.Items.Clear();

                while (rdcDataReader.Read())
                {
                    comboBoxSetupRDCID.Items.Add(rdcDataReader[0].ToString());
                }

                connect.Close();
                comboBoxSetupRDCID.SelectedIndex = 0;

            }

            catch (Exception error)
            {

                MessageBox.Show("Error: " + error);
            }

            finally
            {
                connect.Close();
            }
            #endregion

        }
        #endregion
        /////////////////////////////////////////////



        /////////////// MENU CLICKING ///////////////
        #region
        public void buttonDashboard_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabControlMain.TabPages["tabPageDashboard"];
        }

        private void buttonMenuBarExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMenuBarConfiguration_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabControlMain.TabPages["tabPageConfiguration"];
        }
        #endregion
        /////////////////////////////////////////////



        /////////////// TICKER - MAIN CHECKER ///////////////
        #region
        ///CONNECTIVITY
        ///USERNAME
        ///DISABLE CONFIG BUTTONS WHEN LIVE DATA
        ///RESET GLOBAL VARIABLES WHEN CONNECTION LOST
        #region 
        //Connectivity Checking
        private void ConnectivityChecker_Tick(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen && GlobalDataContainerClass.ConnectivityStatus == false)
            {
                GlobalDataContainerClass.ConnectivityStatus = true;
            }
            else if (!(serialPortMain.IsOpen) && GlobalDataContainerClass.ConnectivityStatus == true)
            {
                GlobalDataContainerClass.ConnectivityStatus = false;
            }

            // Labels and wifi picture
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                if (textBoxMainConnectivity.Text != "Connected")
                {
                    textBoxMainConnectivity.Text = "Connected";
                    textBoxMainConnectivity.ForeColor = System.Drawing.Color.ForestGreen;
                    GlobalDataContainerClass.WifiImageOnline = true;
                    GlobalDataContainerClass.WifiImageChanged = false;
                }
            }
            else
            {
                if (textBoxMainConnectivity.Text != "Disconnected")
                {
                    textBoxMainConnectivity.Text = "Disconnected";
                    textBoxMainConnectivity.ForeColor = System.Drawing.Color.Red;
                    GlobalDataContainerClass.WifiImageOnline = false;
                    GlobalDataContainerClass.WifiImageChanged = false;
                    tabControlMain.SelectedTab = tabControlMain.TabPages["tabPageConfiguration"];
                    MessageBox.Show("You just lost connection!", "DISCONNECTED!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonConfigurationConnect.Focus();

                    /*
                    comboBoxConfigurationSerialPorts.Items.Clear();
                    string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
                    foreach (string ports in comPorts)
                    {
                        comboBoxConfigurationSerialPorts.Items.Add(ports);
                    }
                    comboBoxConfigurationSerialPorts.SelectedIndex = comboBoxConfigurationSerialPorts.Items.Count - 1;
                    */
                }
            }

            // Reset global data when connection is lost
            if (GlobalDataContainerClass.ConnectivityStatus == false)
            {
                ConnectionLostReset();
                buttonDashboardResetDatapoints_Click(sender, e);
            }

            // Username checking
            if (GlobalDataContainerClass.DeviceName != textBoxMainUserName.Text)
            {
                textBoxMainUserName.Text = GlobalDataContainerClass.DeviceName;
            }

            //Cant change RDC, DAU and Instrument while receiving data / Connected
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                //Cant change DAU and RDC when connected to DAU
                comboBoxSetupRDCID.Enabled = false;
                comboBoxSetupDAUID.Enabled = false;
                comboBoxSetupDAUDeviceName.Enabled = false;
                //Cant change Instrument if receiving data
                if (GlobalDataContainerClass.LiveData)
                {
                    comboBoxConfigurationTag.Enabled = false;
                }
                else
                {
                    comboBoxConfigurationTag.Enabled = true;
                }

            }
            else
            {
                comboBoxSetupRDCID.Enabled = true;
                comboBoxSetupDAUID.Enabled = true;
                comboBoxSetupDAUDeviceName.Enabled = true;
            }
        }

        #endregion
        #endregion
        /////////////////////////////////////////////



        /////////////// DASHBOARD ///////////////
        #region


        // HOVERING
        #region
        private void textBoxDashboardAlarmHigh_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Alarm High value";
        }

        private void textBoxDashboardAlarmLow_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Alarm Low value";
        }

        private void buttonDashboardClose_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Close window";
        }

        private void buttonDashboardStartRecordingData_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Start receiving data";
        }

        private void buttonDashboardStopReceiving_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Stop receiving data";
        }

        private void buttonDashboardSaveFile_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Save numeric data";
        }

        private void buttonDashboardSaveGraphImage_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Save graph picture";
        }

        private void buttonDashboardResetDatapoints_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Reset received data";
        }

        private void radioButtonDashboardScaled_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Show scaled data";
        }

        private void radioButtonDashboardRaw_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Show raw data";
        }

        private void textBoxDashboardURV_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Upper-Range-Value";
        }

        private void textBoxDashboardLRV_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Lower-Range-Value";
        }

        private void textBoxDashboardPortName_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Port name selected";
        }

        private void textBoxDashboardBaudRate_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Baud rate selected";
        }

        private void textBoxDashboardConnectivityStatus_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Connectivity status";
        }

        private void textBoxDashboardDataStatus_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Live or not live data";
        }

        private void textBoxDashboardDataType_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Analog, Digital etc";
        }

        private void textBoxDashboardDatapoints_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Count of datapoints";
        }

        private void listBoxDashboardTextData_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Numeric data";
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Graphical data";
        }
        #endregion


        // NUMERIC AND CHART DATA
        #region

        // RAW TO SCALED DATA CONVERTING
        #region
        public string scaledDataConverter(string rawDataInput)
        {
            double tempValue = Convert.ToDouble(rawDataInput);
            string rawDataScaled = "";
            if (Math.Abs(GlobalDataContainerClass.DeviceURV - GlobalDataContainerClass.DeviceLRV) <= 0)
            {
                rawDataScaled = tempValue.ToString();
            }
            else
            {
                tempValue = tempValue * ((GlobalDataContainerClass.DeviceURV - GlobalDataContainerClass.DeviceLRV) / 1024); // (Scale/Bits??)
                rawDataScaled = tempValue.ToString();
            }

            return rawDataScaled;
        }
        #endregion

        // AUTO REQUEST DATA
        #region
        private void timerSerialDataRequester_Tick(object sender, EventArgs e)
        {

            if (GlobalDataContainerClass.ConnectivityStatus && GlobalDataContainerClass.LiveData && (GlobalDataContainerClass.AlarmRequested==false))
            {
                try
                {
                    serialPortMain.WriteLine("readraw");
                    timerDataChartUpdater.Enabled = true;
                    timerSerialDataRequester.Enabled = false;
                }
                catch (Exception)
                {

                    GlobalDataContainerClass.ConnectivityStatus = false;
                }

            }
            else if(GlobalDataContainerClass.ConnectivityStatus && GlobalDataContainerClass.LiveData && GlobalDataContainerClass.AlarmRequested)
            {
                try
                {
                    GlobalDataContainerClass.AlarmRequested = false;
                    GlobalDataContainerClass.AlarmTickCount = 0;
                    serialPortMain.WriteLine("readstatus");
                    timerDataChartUpdater.Enabled = true;
                    timerSerialDataRequester.Enabled = false;
                }
                catch (SystemException)
                {
                    GlobalDataContainerClass.ConnectivityStatus = false;
                }

            }
        }
        #endregion


        // ADD DATA TO CHART AND LISTBOXES
        #region
        private void timerDataChartUpdater_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPortMain.BytesToRead > 0 && GlobalDataContainerClass.LiveData)
                {
                    string availableData = "";
                    availableData = serialPortMain.ReadExisting().ToString();
                    availableData = availableData.Replace(";\r\n", "").Replace(";\n", "").Replace(";\r", ""); //Remove new lines at the end

                    if (!(availableData == "") && Int32.TryParse(availableData, out Int32 JustForChecking))
                    {

                        // Value might be an alarm
                        #region
                        if (GlobalDataContainerClass.AlarmReceived && (Int32.Parse(availableData) == 0
                           || Int32.Parse(availableData) == 1 || Int32.Parse(availableData) == 2 || Int32.Parse(availableData) == 3))
                        {
                            Int32 deviceStatus = Int32.Parse(availableData);
                            //ALARM IMAGE UPDATER
                            #region
                            //New status which is not OK (image change needed)
                            if ((deviceStatus == 1 || deviceStatus == 2 || deviceStatus == 3) && (GlobalDataContainerClass.AlarmStatus == 0))
                            {
                                pictureBoxDashboardError.Image = SoftSensConf.Properties.Resources.AlertActive;
                            }
                            else if (deviceStatus == 0)
                            {
                                pictureBoxDashboardError.Image = null;
                            }
                            #endregion

                            //ALARM TEXT UPDATER
                            #region
                            //Status is OK!
                            if (deviceStatus == 0)
                            {
                                textBoxDashboardError.Text = "OK!";
                                GlobalDataContainerClass.AlarmStatus = deviceStatus;
                                GlobalDataContainerClass.AlarmTickCount = 0;
                            }

                            //STATUS IS FAIL
                            else if (deviceStatus == 1)
                            {
                                textBoxDashboardError.Text = "FAIL!";
                                GlobalDataContainerClass.AlarmStatus = deviceStatus;
                                GlobalDataContainerClass.AlarmTickCount = 0;
                            }

                            //STATUS IS ALARMLOW
                            else if (deviceStatus == 2)
                            {
                                textBoxDashboardError.Text = "ALARM LOW!";
                                GlobalDataContainerClass.AlarmStatus = deviceStatus;
                                GlobalDataContainerClass.AlarmTickCount = 0;
                            }

                            //STATUS IS ALARMHIGH
                            else if (deviceStatus == 3)
                            {
                                textBoxDashboardError.Text = "ALARM HIGH!";
                                GlobalDataContainerClass.AlarmStatus = deviceStatus;
                                GlobalDataContainerClass.AlarmTickCount = 0;
                            }
                            GlobalDataContainerClass.AlarmReceived = false;

                        }
                        #endregion

                        //Reading is outside of range accepted
                        else if ((Int32.Parse(availableData) > 1000 || Int32.Parse(availableData) < 0))
                        {
                            textBoxDashboardFaultyData.Text = availableData;
                            //Throw some error!
                        }
                        #endregion

                        //Reading is within range
                        #region
                        else
                        {
                            
                            int logID = AddInstrumentLog(GlobalDataContainerClass.DeviceName);
                            if (logID > 0) //-1 is returned if AddInstrumentLog fails
                            {
                                // Update information according to data type
                                switch (GlobalDataContainerClass.CommunicationType)
                                {

                                    case "Analog":
                                        // Add data to raw and scaled graph
                                        #region
                                        //textBoxDashboardFaultyData.Text = "";
                                        listBoxDashboardTextDataRaw.Items.Add(availableData);
                                        chartDashboardChartRaw.Series["RawData"].Points.AddXY(Convert.ToDouble(listBoxDashboardTextDataRaw.Items.Count - 1),
                                                                              Convert.ToDouble(listBoxDashboardTextDataRaw.Items[listBoxDashboardTextDataRaw.Items.Count - 1]));

                                        listBoxDashboardTextDataScaled.Items.Add(scaledDataConverter(availableData));
                                        chartDashboardChartScaled.Series["ScaledData"].Points.AddXY(Convert.ToDouble(listBoxDashboardTextDataScaled.Items.Count - 1),
                                                                              Convert.ToDouble(listBoxDashboardTextDataScaled.Items[listBoxDashboardTextDataScaled.Items.Count - 1]));

                                        GlobalDataContainerClass.NumberOfDataPoints += 1;
                                        #endregion

                                        // Fix listbox view regardless
                                        #region
                                        if (listBoxDashboardTextDataRaw.Items.Count > 1)
                                        {
                                            listBoxDashboardTextDataRaw.SetSelected(listBoxDashboardTextDataRaw.Items.Count - 1, true);
                                            listBoxDashboardTextDataRaw.SetSelected(listBoxDashboardTextDataRaw.Items.Count - 1, false);
                                        }

                                        if (listBoxDashboardTextDataScaled.Items.Count > 1)
                                        {
                                            listBoxDashboardTextDataScaled.SetSelected(listBoxDashboardTextDataScaled.Items.Count - 1, true);
                                            listBoxDashboardTextDataScaled.SetSelected(listBoxDashboardTextDataScaled.Items.Count - 1, false);
                                        }
                                        #endregion

                                        // Update reading in DB based on selected datatype
                                        #region

                                        // Differenciate between Analog input and Analog output
                                        switch (GlobalDataContainerClass.IOType)
                                        {
                                            case "Output":
                                                #region
                                                string sqlInsertQuery = "INSERT INTO LOG_AO (Log_ID, ReadingValue, DataType_ID) VALUES (@id, @value, @DataType)";

                                                SqlCommand command = new SqlCommand(sqlInsertQuery, connect);

                                                command.Parameters.AddWithValue("@id", logID);
                                                // Alter reading and data id based on selected view (Scaled or raw)
                                                #region
                                                switch (GlobalDataContainerClass.ScaledDataType)
                                                {
                                                    //Scaled value selected
                                                    case true:
                                                        command.Parameters.AddWithValue("@value", scaledDataConverter(availableData));
                                                        command.Parameters.AddWithValue("@DataType", 1); // Scaled has DataType_ID 1
                                                        break;

                                                    //Raw value selected
                                                    case false:
                                                        command.Parameters.AddWithValue("@value", availableData);
                                                        command.Parameters.AddWithValue("@DataType", 2); // Raw has DataType_ID 2
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                #endregion

                                                connect.Open();

                                                command.ExecuteNonQuery();

                                                connect.Close();
                                                #endregion
                                                break;

                                            case "Input":
                                                #region
                                                sqlInsertQuery = "INSERT INTO LOG_AI (Log_ID, SendingValue, DataType_ID, AI_Executed) VALUES (@id, @value, @DataType, @executed)";

                                                command = new SqlCommand(sqlInsertQuery, connect);

                                                command.Parameters.AddWithValue("@id", logID);
                                                command.Parameters.AddWithValue("@executed", 0); //Not implemented so using 0 as default
                                                // Alter reading and data id based on selected view (Scaled or raw)
                                                #region
                                                switch (GlobalDataContainerClass.ScaledDataType)
                                                {
                                                    //Scaled value selected
                                                    case true:
                                                        command.Parameters.AddWithValue("@value", scaledDataConverter(availableData));
                                                        command.Parameters.AddWithValue("@DataType", 1); // Scaled has DataType_ID 1
                                                        break;

                                                    //Raw value selected
                                                    case false:
                                                        command.Parameters.AddWithValue("@value", availableData);
                                                        command.Parameters.AddWithValue("@DataType", 2); // Raw has DataType_ID 2
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                #endregion

                                                connect.Open();

                                                command.ExecuteNonQuery();

                                                connect.Close();
                                                #endregion
                                                break;

                                            default:
                                                // Nothing
                                                break;
                                        }
                                        break;
                                    #endregion

                                    case "Digital":



                                        break;

                                    default:
                                        // Any other type or reading
                                        break;

                                }
                            }

                        }
                        
                    }
                    #endregion
                }

                // Update so loop continues
                timerDataChartUpdater.Enabled = false;
                timerSerialDataRequester.Enabled = true;
            }
            #endregion
            #region
            catch (Exception)
            {
                GlobalDataContainerClass.ConnectivityStatus = false;
            }
        }
        #endregion

        #endregion


        //SCALED DATA CHECKED
        #region
        private void radioButtonDashboardScaled_CheckedChanged(object sender, EventArgs e)
        {
            if (labelDashboardGraph.Text == "Raw Data")
            {
                listBoxDashboardTextDataRaw.Visible = false;
                listBoxDashboardTextDataRaw.Visible = true;
                labelDashboardGraph.Text = "Scaled Data";
            }
            GlobalDataContainerClass.ScaledDataType = true;

        }
        #endregion


        //RAW DATA CHECKED
        #region
        private void radioButtonDashboardRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (labelDashboardGraph.Text == "Scaled Data")
            {
                listBoxDashboardTextDataRaw.Visible = true;
                listBoxDashboardTextDataRaw.Visible = false;
                labelDashboardGraph.Text = "Raw Data";
            }
            GlobalDataContainerClass.ScaledDataType = false;
        }
        #endregion


        //SAVE DATAPOINTS FILE
        #region
        private void buttonDashboardSaveFile_Click(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.NumberOfDataPoints >= 2)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                if (GlobalDataContainerClass.ScaledDataType)
                {
                    savefile.FileName = "ScaledData_" + DateTime.Now.ToString("dd-MM-yyyy") + ".csv";
                }
                else
                {
                    savefile.FileName = "RawData_" + DateTime.Now.ToString("dd-MM-yyyy") + ".csv";
                }

                savefile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(savefile.FileName);
                    if (GlobalDataContainerClass.ScaledDataType)
                    {
                        SaveFile.WriteLine("Time"+ "," + "Scaled");
                        for (int i = 0; i < listBoxDashboardTextDataScaled.Items.Count; i++)
                        {
                            SaveFile.WriteLine(""+ i + "," + listBoxDashboardTextDataScaled.Items[i]);
                        }
                    }
                    else
                    {
                        SaveFile.WriteLine("Time"+ "," + "Raw");
                        for (int i = 0; i < listBoxDashboardTextDataRaw.Items.Count; i++)
                        {
                            SaveFile.WriteLine("" + i + "," + listBoxDashboardTextDataRaw.Items[i]);
                        }
                    }
                    SaveFile.Close();
                    MessageBox.Show("Data saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Two or more datapoints are required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        //SAVE GRAPH PICTURE
        #region
        private void buttonDashboardSaveGraphImage_Click(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.NumberOfDataPoints >= 2)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                if (GlobalDataContainerClass.ScaledDataType)
                {
                    savefile.FileName = "GraphPicture_Scaled" + DateTime.Now.ToString("dd-MM-yyyy") + ".png";
                }
                else
                {
                    savefile.FileName = "GraphPicture_Raw" + DateTime.Now.ToString("dd-MM-yyyy") + ".png";
                }

                savefile.Filter = "PNG files (*.png)|*.png";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    //SCALED DATA
                    if (GlobalDataContainerClass.ScaledDataType)
                    {
                        chartDashboardChartScaled.SaveImage(savefile.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    }
                    //RAW DATA
                    else
                    {
                        chartDashboardChartRaw.SaveImage(savefile.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    }

                    MessageBox.Show("Image saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
            else
            {
                MessageBox.Show("Two or more datapoints are required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        //START RECEIVING DATA
        #region
        private void buttonDashboardStartRecordingData_Click(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                if (GlobalDataContainerClass.LiveData == false)
                {
                    // Fix data logging frequency
                    #region
                    if (GlobalDataContainerClass.ScanningFrequency <= 0) //Fail safe
                    {
                        MessageBox.Show("Logging frequency not valid. Please use a frequency thats above zero Hz.",
                                        "Frequency not valid",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        
                        return; // Stop program from logging
                    }
                    
                    else // Change timers to match frequency requested
                    {
                        Int32 newFrequency = Convert.ToInt32(Math.Round(((1 / GlobalDataContainerClass.ScanningFrequency) * 1000),0));
                        timerSerialDataRequester.Interval = timerDataChartUpdater.Interval = newFrequency;
                    }
                    #endregion

                    GlobalDataContainerClass.LiveData = true;
                    timerSerialDataRequester.Enabled = true;
                    timerAlarmRequester.Enabled = true;
                }
            }
        }
        #endregion


        //TICKER - UPDATE DASHBOARD DATAINFORMATION
        #region
        private void timerDashboardDataInformation_Tick(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                textBoxDashboardConnectivityStatus.Text = "Connected";
            }
            else
            {
                textBoxDashboardConnectivityStatus.Text = "Disconnected";
            }

            if (GlobalDataContainerClass.LiveData)
            {
                textBoxDashboardDataStatus.Text = "Live Data";
            }
            else
            {
                textBoxDashboardDataStatus.Text = "Not Live";
            }

            if (GlobalDataContainerClass.ScaledDataType)
            {
                chartDashboardChartScaled.Visible = true;
                chartDashboardChartRaw.Visible = false;
                listBoxDashboardTextDataScaled.Visible = true;
                listBoxDashboardTextDataRaw.Visible = false;
            }
            else
            {
                chartDashboardChartScaled.Visible = false;
                chartDashboardChartRaw.Visible = true;
                listBoxDashboardTextDataScaled.Visible = false;
                listBoxDashboardTextDataRaw.Visible = true;
            }
            textBoxDashboardPortName.Text = GlobalDataContainerClass.PortNameChosen;
            textBoxDashboardBaudRate.Text = GlobalDataContainerClass.BaudRateChosen.ToString();
            textBoxDashboardDatapoints.Text = GlobalDataContainerClass.NumberOfDataPoints.ToString();
            textBoxDashboardDataType.Text = GlobalDataContainerClass.CommunicationType;
            textBoxDashboardFrequency.Text = GlobalDataContainerClass.ScanningFrequency.ToString();
            textBoxDashboardLRV.Text = GlobalDataContainerClass.DeviceLRV.ToString();
            textBoxDashboardURV.Text = GlobalDataContainerClass.DeviceURV.ToString();
            textBoxDashboardAlarmHigh.Text = GlobalDataContainerClass.DeviceAHI.ToString();
            textBoxDashboardAlarmLow.Text = GlobalDataContainerClass.DeviceALO.ToString();
        }
        #endregion


        //STOP RECEIVING DATA
        #region
        private void buttonDashboardStopReceiving_Click(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.LiveData)
            {
                GlobalDataContainerClass.AlarmTickCount = 0;
                GlobalDataContainerClass.AlarmReceived = false;
                GlobalDataContainerClass.AlarmRequested = false;
                timerDataChartUpdater.Enabled = false;
                timerSerialDataRequester.Enabled = false;
                GlobalDataContainerClass.LiveData = false;

                //Clear out potential missed readings
                string clearBuffer = "";
                try
                {
                    WaitNSeconds(1);
                    clearBuffer = serialPortMain.ReadExisting().ToString();
                }
                catch (Exception)
                {
                    //Do nothing
                }
            }
        }
        #endregion


        //RESET DATAPOINTS
        #region
        private void buttonDashboardResetDatapoints_Click(object sender, EventArgs e)
        {
            GlobalDataContainerClass.NumberOfDataPoints = 0;
            chartDashboardChartRaw.Series["RawData"].Points.Clear();
            chartDashboardChartScaled.Series["ScaledData"].Points.Clear();
            listBoxDashboardTextDataRaw.Items.Clear();
            listBoxDashboardTextDataScaled.Items.Clear();
            GlobalDataContainerClass.AlarmTickCount = 0;
            pictureBoxDashboardError.Image = null;
            GlobalDataContainerClass.AlarmStatus = 0;
            textBoxDashboardError.Text = "";
            textBoxDashboardFaultyData.Text = "";
        }
        #endregion
        #endregion
        /////////////////////////////////////////////



        /////////////// CONFIGURATION ///////////////
        #region

        // Adding ports to dropdown
        #region
        private void comboBoxConfigurationSerialPorts_Enter(object sender, EventArgs e)
        {
            
            comboBoxConfigurationSerialPorts.Items.Clear();
            string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBoxConfigurationSerialPorts.Items.Add(ports);
            }
            
        }
        #endregion


        // WIFI picture updater
        #region
        private void timerWifiImageChecker_Tick(object sender, EventArgs e)
        {
            //Update Wifi Picture
            if ((GlobalDataContainerClass.WifiImageOnline) && (GlobalDataContainerClass.ConnectivityStatus) && (GlobalDataContainerClass.WifiImageChanged == false))
            {
                pictureBoxConfigurationWifi.BackgroundImage = SoftSensConf.Properties.Resources.wifi_online; //WIFI ONLINE
                GlobalDataContainerClass.WifiImageChanged = true;
            }
            else if ((GlobalDataContainerClass.WifiImageOnline == false) && (GlobalDataContainerClass.ConnectivityStatus == false) && (GlobalDataContainerClass.WifiImageChanged == false))
            {
                pictureBoxConfigurationWifi.BackgroundImage = SoftSensConf.Properties.Resources.No_Wifi_Signal; //WIFI OFFLINE
                GlobalDataContainerClass.WifiImageChanged = true;
            }
        }
        #endregion


        //Click CONNECT button on configuration page
        #region
        private void buttonConfigurationConnect_Click(object sender, EventArgs e)
        {
            try { 
                if (textBoxSetupDAUComPort.Text != ""
                    && GlobalDataContainerClass.ConnectivityStatus == false)
                {
                    serialPortMain.PortName = textBoxSetupDAUComPort.Text;

                    if (textBoxSetupDAUComPort.Text != "")
                    {
                        serialPortMain.BaudRate = Convert.ToInt32(textBoxSetupDAUBaudRate.Text);
                        serialPortMain.Open();

                        // Add global variables since you're connected
                        #region
                        GlobalDataContainerClass.BaudRateChosen = Convert.ToInt32(textBoxSetupDAUBaudRate.Text);
                        GlobalDataContainerClass.PortNameChosen = textBoxSetupDAUComPort.Text;
                        GlobalDataContainerClass.DeviceName = comboBoxConfigurationTag.SelectedItem.ToString();
                        GlobalDataContainerClass.DeviceLRV = Convert.ToDouble(textBoxConfigurationLRV.Text);
                        GlobalDataContainerClass.DeviceURV = Convert.ToDouble(textBoxConfigurationLRV.Text);
                        GlobalDataContainerClass.DeviceALO = Convert.ToInt32(textBoxConfigurationAlarmLow.Text);
                        GlobalDataContainerClass.DeviceAHI = Convert.ToInt32(textBoxConfigurationAlarmHigh.Text);
                        GlobalDataContainerClass.IOType = textBoxConfigurationIType.Text;
                        GlobalDataContainerClass.CommunicationType = textBoxConfigurationCommunicationType.Text;
                        GlobalDataContainerClass.ScanningFrequency = Convert.ToDouble(textBoxConfigurationScanningFrequency.Text);
                        

                        //Start Status checking
                        textBoxDashboardError.Text = ""; //Reset text
                        #endregion

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect.\nPlease try again.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /*
                comboBoxConfigurationSerialPorts.Items.Clear();
                string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
                foreach (string ports in comPorts)
                {
                    comboBoxConfigurationSerialPorts.Items.Add(ports);
                }
                comboBoxConfigurationSerialPorts.SelectedIndex = comboBoxConfigurationSerialPorts.Items.Count - 1;
                comboBoxConfigurationSerialPorts.Focus();
                */
            }
        }
        #endregion


        //Click DISCONNECT button on configuration page
        #region
        private void buttonConfigurationDisconnect_Click_1(object sender, EventArgs e)
        {
            ConnectionLostReset(); // set variables to default
            buttonDashboardResetDatapoints_Click(sender, e);
            WaitNSeconds(1);
            serialPortMain.Close(); //Disconnect from port
            buttonConfigurationConnect.Focus();
            //comboBoxConfigurationSerialPorts.SelectedIndex = (comboBoxConfigurationSerialPorts.Items.Count - 1);
        }
        #endregion


        //SEND CONFIG TO DEVICE
        #region
        private void buttonConfigurationSendConfiguration_Click(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                if (GlobalDataContainerClass.LiveData)
                {
                    DialogResult DiaRes = MessageBox.Show("Sensor logging must be stopped before request can be sent to device.\r\nDo you want to stop logging and send request?", "Sensor logging active", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DiaRes == DialogResult.Yes)
                    {
                        buttonDashboardStopReceiving_Click(sender, e);
                    }
                    else
                    {
                        return;
                    }
                }
                StopAlarmRequest(); //Reset alarm ticker just to be sure

                GlobalDataContainerClass.StatusBarText = "";
                // Creating partial string to be sent
                #region
                GlobalDataContainerClass.configToBeSent = comboBoxConfigurationTag.SelectedItem.ToString() + ";"
                                                              + textBoxConfigurationLRV.Text + ";"
                                                              + textBoxConfigurationURV.Text + ";"
                                                              + textBoxConfigurationAlarmLow.Text + ";"
                                                              + textBoxConfigurationAlarmHigh.Text;
                #endregion

                // Check if required fields are filled or same as existing configuration
                #region
                if (comboBoxConfigurationTag.SelectedItem.ToString().Length == 0)
                {
                    MessageBox.Show("Device name is blank", "Device name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxConfigurationDeviceName.Focus();
                    return;
                }
                else if (Convert.ToInt32(textBoxConfigurationAlarmHigh.Text) < Convert.ToInt32(textBoxConfigurationAlarmLow.Text))
                {
                    MessageBox.Show("'Alarm high' is lower than 'Alarm low'", "Value diff error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxConfigurationAlarmLow.Focus();
                    return;
                }
                else if (Convert.ToDouble(textBoxConfigurationURV.Text) < Convert.ToDouble(textBoxConfigurationLRV.Text))
                {
                    MessageBox.Show("'Upper-Range-Value' is lower than 'Lower-Range-Value'", "Value diff error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxConfigurationLRV.Focus();
                    return;
                }
                else if (GlobalDataContainerClass.configToBeSent == GlobalDataContainerClass.configReceived)
                {
                    MessageBox.Show("Config is already on device", "Config already existing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (Convert.ToDouble(textBoxConfigurationURV.Text) == 0)
                {
                    MessageBox.Show("Upper-Range-Value cannot be zero", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                else
                {

                    // SHOW RickAstley FORM
                    #region
                    FormRickAshtley RickAshtleyWindow = new FormRickAshtley();
                    RickAshtleyWindow.ShowDialog(this);

                    if (!(GlobalDataContainerClass.RickAstleyConfirmed))
                    {
                        //Pressed cancel
                        GlobalDataContainerClass.RickAstleyConfirmed = false; //Reset RickAstley status
                        return;
                    }
                    GlobalDataContainerClass.RickAstleyConfirmed = false; //Reset RickAstley status
                    #endregion
                    buttonConfigurationSendConfiguration.Enabled = false;

                    //Trying to send config
                    #region
                    serialPortMain.WriteLine("writeconf>" + GlobalDataContainerClass.RickAstley + ">" + GlobalDataContainerClass.configToBeSent);
                    GlobalDataContainerClass.RickAstley = "";
                    WaitNSeconds(1);
                    GlobalDataContainerClass.StatusBarText = "Sending request to device..";
                    for (int i = 0; i < 3; i++) //Try up to 3 times to see if it has been updated
                    {
                        StopAlarmRequest();

                        GlobalDataContainerClass.StatusBarText = "Checking for response..";
                        WaitNSeconds(1); //Sleep 1 seconds
                        try
                        {
                            if (Int32.TryParse(serialPortMain.ReadExisting().ToString(), out Int32 writeConfirmation))
                            {
                                if (writeConfirmation == 1) //Successfully write config to device
                                {
                                    GlobalDataContainerClass.configReceived = GlobalDataContainerClass.configToBeSent;
                                    GlobalDataContainerClass.ConfigurationLog.Add((GlobalDataContainerClass.configReceived + ";" + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss"))); //Add to master log
                                    SaveConfigLogFile(); //Update config logfile

                                    //Update global variables
                                    string[] tmpString = GlobalDataContainerClass.configToBeSent.Split(';');
                                    GlobalDataContainerClass.DeviceName = tmpString[0];
                                    GlobalDataContainerClass.DeviceLRV = double.Parse(tmpString[1]);
                                    GlobalDataContainerClass.DeviceURV = double.Parse(tmpString[2]);
                                    GlobalDataContainerClass.DeviceALO = Int32.Parse(tmpString[3]);
                                    GlobalDataContainerClass.DeviceAHI = Int32.Parse(tmpString[4]);

                                    GlobalDataContainerClass.StatusBarText = "Success";
                                    WaitNSeconds(1);
                                    buttonConfigurationSendConfiguration.Enabled = true;
                                    MessageBox.Show("Configuration successfully sent to device!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //Reset datapoints
                                    buttonDashboardResetDatapoints_Click(sender, e);

                                    // Update DAU Updated Date
                                    #region
                                    try
                                    {
                                        string instrumentUpdatedDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                        string sqlSelectQuery = "UPDATE [INSTRUMENT] SET [LastUpdatedDate] = @NewValue WHERE Tag = '" + comboBoxConfigurationTag.SelectedItem.ToString() +"'";
                                        SqlCommand command = new SqlCommand(sqlSelectQuery, connect);


                                        
                                        command.Parameters.Add("@NewValue", SqlDbType.DateTime).Value = instrumentUpdatedDate;

                                        connect.Open();

                                        command.ExecuteNonQuery();

                                        connect.Close();

                                        // Update text field without making a uneccessary request.
                                        textBoxConfigurationLastUpdated.Text = instrumentUpdatedDate;
                                    }
                                    catch (Exception error)
                                    {
                                        MessageBox.Show("Update fail. Error: " + error);
                                    }
                                    finally
                                    {
                                        connect.Close();
                                    }
                                    #endregion

                                    return;
                                }
                                //Wrong password, response is NOT 1, but received a response
                                #region
                                else // Password was wrong
                                {
                                    GlobalDataContainerClass.StatusBarText = "Incorrect password!";
                                    DialogResult DiaRes1 = MessageBox.Show("Incorrect password! \nDo you want to try again?", "Incorrect Password!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                    if (DiaRes1 == DialogResult.Yes)
                                    {
                                        i = 20; //Just to be sure
                                        buttonConfigurationSendConfiguration.Enabled = true;
                                        buttonConfigurationSendConfiguration_Click(sender, e);
                                        return;
                                    }
                                    else
                                    {
                                        buttonConfigurationSendConfiguration.Enabled = true;
                                        buttonConfigurationSendConfiguration.Focus();
                                        return;
                                    }
                                }
                                #endregion
                            }
                        }
                        catch (Exception)
                        {
                            GlobalDataContainerClass.ConnectivityStatus = false;
                            return;
                        }
                        
                    }
                    // IF NO RESPONSE AT ALL FROM DEVICE
                    #region
                    GlobalDataContainerClass.StatusBarText = "Response not recognizable ";
                    DialogResult DiaRes2 = MessageBox.Show("No recognizable response from device. \nDo you want to try again?", "No Response!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (DiaRes2 == DialogResult.Yes)
                    {
                        buttonConfigurationSendConfiguration.Enabled = true;
                        buttonConfigurationSendConfiguration_Click(sender, e);
                        return;
                    }
                    else
                    {
                        buttonConfigurationSendConfiguration.Enabled = true;
                        return;
                    }

                    #endregion
                }
                #endregion
            }
        }
        #endregion


        //LOAD CONFIG FROM FILE
        #region
        private void buttonConfigurationLoadConfiguration_Click(object sender, EventArgs e)
        {
            bool configFound = false;
            var fileName = string.Empty;
            OpenFileDialog ConfigFile = new OpenFileDialog();
            ConfigFile.Filter = "SSC files (*.ssc)|*.ssc|All files (*.*)|*.*";
            ConfigFile.RestoreDirectory = true;
            ConfigFile.FileName = "";

            if (ConfigFile.ShowDialog() == DialogResult.OK)
            {
                fileName = ConfigFile.FileName;
                try
                {
                    using (System.IO.StreamReader FileReader = new System.IO.StreamReader(fileName))
                    {
                        string line;
                        while ((line = FileReader.ReadLine()) != null)
                        {
                            line = line.Replace(";\r\n", "").Replace(";\n", "").Replace(";\r", "").Replace(" ", ""); //Removing empty lines
                            string[] checkLine = line.Split(';');
                            if (checkLine.Length == 5)
                            {
                                double parsedLRV, parsedURV;
                                Int32 parsedALO, parsedAHI;

                                //Check if values are legit and update if they are
                                if (checkLine[0].Length <= 10 && checkLine[0].Length != 0 // Device name has correct len but not blank
                                    && double.TryParse(checkLine[1], out parsedLRV) && checkLine[1].Length <= 7 //LRV can be transformed to a double
                                    && double.TryParse(checkLine[2], out parsedURV) && checkLine[2].Length <= 7 //URV can be transformed to a double
                                    && Int32.TryParse(checkLine[3], out parsedALO) && checkLine[3].Length <= 4 //Alarm Lower can be transformed to a Int32
                                    && Int32.TryParse(checkLine[4], out parsedAHI) && checkLine[4].Length <= 4 //Alarm High can be transformed to a Int32
                                    )
                                {
                                    //Check if correct config is found
                                    configFound = true;
                                    DialogResult OpenConfDiaRes = MessageBox.Show(string.Format("Configuration found!\r\n"
                                        + "Is this the configuration you're looking for?\r\n\r\n"
                                        + "Device name: {0}\r\n"
                                        + "LRV:                {1}\r\n"
                                        + "URV:               {2}\r\n"
                                        + "AlarmL:           {3}\r\n"
                                        + "AlarmH:          {4}\r\n",
                                        checkLine[0], checkLine[1], checkLine[2], checkLine[3], checkLine[4]), 
                                        "Config found!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                                    if (OpenConfDiaRes == DialogResult.Yes)
                                    {
                                        if (!(tabControlMain.SelectedTab == tabControlMain.TabPages["tabPageConfiguration"]))
                                        {
                                            tabControlMain.SelectedTab = tabControlMain.TabPages["tabPageConfiguration"];
                                            GlobalDataContainerClass.ChangedTabSize = true;
                                            WaitNSeconds(1);
                                        }
                                        textBoxConfigurationDeviceName.Text = checkLine[0];
                                        textBoxConfigurationLRV.Text = checkLine[1];
                                        textBoxConfigurationURV.Text = checkLine[2];
                                        textBoxConfigurationAlarmLow.Text = checkLine[3];
                                        textBoxConfigurationAlarmHigh.Text = checkLine[4];
                                        buttonConfigurationSendConfiguration.Focus();
                                        return;
                                    }
                                    else if (OpenConfDiaRes == DialogResult.No)
                                    {
                                        continue;
                                    }
                                    else 
                                    {
                                        return;//Cancel
                                    }

                                }
                            }
                        }
                        //Config is found earlier but theres not a next one
                        if (configFound)
                        {
                            MessageBox.Show("No other config was found!", "Config not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //No config found at all
                        else
                        {
                            if (GlobalDataContainerClass.SystemLang == "English")
                            {
                                MessageBox.Show("No config was found!\r\nPlease check your file."
                                    + "\r\n\r\nCorrect format:"
                                    + "\r\nDevice name | string | 1-10 characters"
                                    + "\r\nLRV                | float   | Max 7 characters"
                                    + "\r\nURV               | float   | Max 7 characters"
                                    + "\r\nAlarmL           | Int      | Max 4 characters"
                                    + "\r\nAlarmH          | Int      | Max 4 characters"
                                    + "\r\nDelimiter       | string | ';' "
                                    + "\r\n\r\nExample: RIPHARAMBE;5.0;50.0;10;100", "No config found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("No config was found!\r\nPlease check your file."
                                    + "\r\n\r\nCorrect format:"
                                    + "\r\nDevice name | string | 1-10 characters"
                                    + "\r\nLRV                | float   | Max 7 characters"
                                    + "\r\nURV               | float   | Max 7 characters"
                                    + "\r\nAlarmL           | Int      | Max 4 characters"
                                    + "\r\nAlarmH          | Int      | Max 4 characters"
                                    + "\r\nDelimiter       | string | ';' "
                                    + "\r\n\r\nExample: RIPHARAMBE;5,0;50,0;10;100", "No config found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                //File cant be read
                catch (Exception)
                {
                    MessageBox.Show("This file could not be read.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        //Save Configuration
        #region
        private void buttonConfigurationSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (textBoxConfigurationDeviceName.Text.Length <= 10 && textBoxConfigurationDeviceName.Text.Length != 0 && Convert.ToDouble(textBoxConfigurationURV.Text) > 0)
            {
                SaveFileDialog saveCurrentConfig = new SaveFileDialog();
                saveCurrentConfig.FileName = "SoftSensConfiguration_" + DateTime.Now.ToString("dd-MM-yyyy") + ".ssc";
                saveCurrentConfig.Filter = "SSC files (*.ssc)|*.ssc|All files (*.*)|*.*";

                if (saveCurrentConfig.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.StreamWriter SaveCurrentConfig = new System.IO.StreamWriter(saveCurrentConfig.FileName);

                        SaveCurrentConfig.WriteLine("SoftSensConf_Version:" + GlobalDataContainerClass.SoftWareVersion
                              + ";DateTimeSaved: " + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss"));//Informational top info
                        SaveCurrentConfig.WriteLine("DeviceName;LRV;URV;ALARM-L;ALARM-H"); // Insert headers


                        SaveCurrentConfig.WriteLine("" + textBoxConfigurationDeviceName.Text + ";"
                                                    + textBoxConfigurationLRV.Text + ";"
                                                    + textBoxConfigurationURV.Text + ";"
                                                    + textBoxConfigurationAlarmLow.Text + ";"
                                                    + textBoxConfigurationAlarmHigh.Text);
                        SaveCurrentConfig.Close();
                        MessageBox.Show("Configuration saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not save file.\r\nPlease try again", "Save Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (textBoxConfigurationDeviceName.Text.Length == 0)
            {
                MessageBox.Show("Cannot save configuration with empty Device Name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConfigurationDeviceName.Focus();
            }
            else if (Convert.ToDouble(textBoxConfigurationURV.Text) == 0)
            {
                MessageBox.Show("Cannot save configuration with Upper-Range-Value as zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConfigurationURV.Focus();
            }
            else
            {
                MessageBox.Show("Cannot save configuration with empty fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConfigurationDeviceName.Focus();
            }
        }
        #endregion


        // CONFIG-HOVER AND TEXTBOX INPUT
        #region

        private void buttonConfigurationConnect_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Connect to device";
        }

        private void buttonConfigurationDisconnect_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Disconnect from device";
        }

        private void comboBoxConfigurationSerialPorts_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Select communication port";
        }

        private void comboBoxConfigurationChoseBaudRate_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Select baud rate";
        }

        private void textBoxConfigurationURV_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Set Upper-Range-Value";
        }

        private void textBoxConfigurationLRV_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Set Lower-Range-Value";
        }

        private void buttonConfigurationLoadConfiguration_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Load config from file";
        }

        private void buttonConfigurationSendConfiguration_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Send config to device";
        }

        private void buttonConfigurationSaveConfiguration_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Save config to file";
        }


        private void textBoxConfigurationURV_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Only accept numbers
            if (GlobalDataContainerClass.SystemLang == "English")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }


        private void textBoxConfigurationLRV_TextChanged(object sender, EventArgs e)
        {
            // Try to copy in something thats not a number
            
            if (GlobalDataContainerClass.SystemLang == "English")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxConfigurationLRV.Text, "[^.0-9]"))
                {
                    MessageBox.Show("Please only enter numbers.", "NAN Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxConfigurationLRV.Text = "";
                    textBoxConfigurationLRV.Focus();
                }
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxConfigurationLRV.Text, "[^,0-9]"))
                {
                    MessageBox.Show("Please only enter numbers.", "NAN Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxConfigurationLRV.Text = "";
                    textBoxConfigurationLRV.Focus();
                }
            }
        }


        private void textBoxConfigurationDeviceName_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Name of device";
        }

        private void textBoxConfigurationLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GlobalDataContainerClass.SystemLang == "English")
            {
                // Only accept numbers
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            else
            {
                // Only accept numbers
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxConfigurationURV_TextChanged(object sender, EventArgs e)
        {
            // Try to copy in something thats not a number
            if (GlobalDataContainerClass.SystemLang == "English")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxConfigurationURV.Text, "[^.0-9]"))
                {
                    MessageBox.Show("Please only enter numbers.", "NAN Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxConfigurationURV.Text = "";
                    textBoxConfigurationURV.Focus();
                }
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxConfigurationURV.Text, "[^,0-9]"))
                {
                    MessageBox.Show("Please only enter numbers.", "NAN Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxConfigurationURV.Text = "";
                    textBoxConfigurationURV.Focus();
                }
            }
        }

        private void textBoxConfigurationAlarmLow_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Enter lower alarm value";
        }

        private void textBoxConfigurationAlarmHigh_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Enter upper alarm value";
        }

        private void textBoxConfigurationAlarmLow_TextChanged(object sender, EventArgs e)
        {
            // Try to copy in something thats not a number
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxConfigurationAlarmLow.Text, "[^0-9]"))
            {
                MessageBox.Show("Please only enter numbers.", "NAN Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxConfigurationAlarmLow.Text = "";
                textBoxConfigurationAlarmLow.Focus();
            }
        }

        private void textBoxConfigurationAlarmLow_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only accept numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxConfigurationAlarmHigh_TextChanged(object sender, EventArgs e)
        {
            // Try to copy in something thats not a number
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxConfigurationAlarmHigh.Text, "[^0-9]"))
            {
                MessageBox.Show("Please only enter numbers.", "NAN Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxConfigurationAlarmHigh.Text = "";
                textBoxConfigurationAlarmHigh.Focus();
            }
        }

        private void textBoxConfigurationAlarmHigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only accept numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxConfigurationDeviceName_Leave(object sender, EventArgs e)
        {
            //if (textBoxConfigurationDeviceName.Text.Length > 1 && !(textBoxConfigurationDeviceName.Text.Length == 0))
            //{
            //    MessageBox.Show("Device name must to be a length of 10 characters", "Length Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    textBoxConfigurationDeviceName.Focus();
            //}
        }
        #endregion


        //CONFIG HOVER/LEAVE
        #region
        private void textBoxConfigurationAlarmLow_Leave(object sender, EventArgs e)
        {
            if (textBoxConfigurationAlarmLow.Text == "")
            {
                textBoxConfigurationAlarmLow.Text = "0";
            }
            if (Convert.ToInt32(textBoxConfigurationAlarmLow.Text) > 1000)
            {
                textBoxConfigurationAlarmLow.Text = "1000";
            }
        }

        private void textBoxConfigurationAlarmHigh_Leave(object sender, EventArgs e)
        {
            if (textBoxConfigurationAlarmHigh.Text == "")
            {
                textBoxConfigurationAlarmHigh.Text = "0";
            }
            if (Convert.ToInt32(textBoxConfigurationAlarmHigh.Text) > 1000)
            {
                textBoxConfigurationAlarmHigh.Text = "1000";
            }
        }

        private void textBoxConfigurationLRV_Leave(object sender, EventArgs e)
        {
            if (textBoxConfigurationLRV.Text == "")
            {
                textBoxConfigurationLRV.Text = "0";
            }
            if (Convert.ToDouble(textBoxConfigurationLRV.Text) > 1000)
            {
                textBoxConfigurationLRV.Text = "1000";
            }
        }

        private void textBoxConfigurationURV_Leave(object sender, EventArgs e)
        {
            if (textBoxConfigurationURV.Text == "")
            {
                textBoxConfigurationURV.Text = "0";
            }
            if (Convert.ToDouble(textBoxConfigurationURV.Text) > 1000)
            {
                textBoxConfigurationURV.Text = "1000";
            }
        }

        private void buttonConfigurationRquestDeviceConfig_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Request config from device";
        }
        #endregion


        //REQUEST CONFIGURATION FROM DEVICE
        #region
        private void buttonConfigurationRquestDeviceConfig_Click(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                if (GlobalDataContainerClass.LiveData)
                {
                    DialogResult DiaRes = MessageBox.Show("Sensor logging must be stopped before request can be sent to device.\r\nDo you want to stop logging and send request?", "Sensor logging active", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DiaRes == DialogResult.Yes)
                    {
                        buttonDashboardStopReceiving_Click(sender, e);
                    }
                    else
                    {
                        return;
                    }
                }
                StopAlarmRequest();
                //Try to connect three times and update values if connected etc.
                #region
                GlobalDataContainerClass.StatusBarText = "Requesting data..";
                serialPortMain.WriteLine("readconf");
                for (int i = 0; i < 3; i++)
                {
                    WaitNSeconds(1); //Wait 1 second
                    StopAlarmRequest();
                    if (!(serialPortMain.IsOpen))
                    {
                        return;
                    }
                    GlobalDataContainerClass.configReceived = serialPortMain.ReadExisting().ToString();
                    GlobalDataContainerClass.configReceived = GlobalDataContainerClass.configReceived.Replace(";\r\n", "").Replace(";\n", "").
                        Replace(";\r", "").Replace(" ", "").Replace("\r\n","").Replace("\r","").Replace("\n",""); //Removing empty lines
                    string[] tempData = GlobalDataContainerClass.configReceived.Split(';');

                    // Checking for correct length
                    #region
                    if (tempData.Length == 5)
                    {
                        double parsedLRV, parsedURV;
                        Int32 parsedALO, parsedAHI;

                        //Check if values are legit and update if they are
                        #region
                        if (tempData[0].Length <= 10 && tempData[0].Length != 0 // Device name is less or equal to a len of 10, but not zero
                            && double.TryParse(tempData[1], out parsedLRV) && tempData[1].Length <= 7 //LRV can be transformed to a double
                            && double.TryParse(tempData[2], out parsedURV) && tempData[2].Length <= 7 //URV can be transformed to a double
                            && Int32.TryParse(tempData[3], out parsedALO) && tempData[3].Length <= 4 //Alarm Lower can be transformed to a Int32
                            && Int32.TryParse(tempData[4], out parsedAHI) && tempData[4].Length <= 4 //Alarm High can be transformed to a Int32
                            )

                        //Update global variables to existing values

                        {
                            GlobalDataContainerClass.DeviceName = tempData[0];
                            GlobalDataContainerClass.DeviceLRV = double.Parse(tempData[1]);
                            GlobalDataContainerClass.DeviceURV = double.Parse(tempData[2]);
                            GlobalDataContainerClass.DeviceALO = Int32.Parse(tempData[3]);
                            GlobalDataContainerClass.DeviceAHI = Int32.Parse(tempData[4]);
                            GlobalDataContainerClass.ConfigurationLog.Add((GlobalDataContainerClass.configReceived + ";" + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss"))); //Add to master log
                            GlobalDataContainerClass.ChangedTabSize = true;
                            SaveConfigLogFile(); //Update config logfile
                            MessageBox.Show("Configuration successfully received from device!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Reset datapoints
                            buttonDashboardResetDatapoints_Click(sender, e);

                            return;
                        }
                        #endregion
                    }
                    #endregion

                    // Not correct length, maybe not catching data.. Trying again (3 times)
                    #region
                    else
                    {
                        GlobalDataContainerClass.StatusBarText = "No data found. Retrying..";
                    }
                    #endregion
                }
                #endregion

                // If device name == N/A => No pre-existing data was found
                #region
                if (GlobalDataContainerClass.DeviceName == "")
                {
                    GlobalDataContainerClass.configReceived = "";
                    DialogResult DiaRes = MessageBox.Show("No recognizable configuration found.\nDo you want to retry?", "Config not found!",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DiaRes == DialogResult.Yes)
                    {
                        buttonConfigurationRquestDeviceConfig_Click(sender, e);
                        return;
                    }
                    else
                    {
                        GlobalDataContainerClass.StatusBarText = "No data found.";
                        WaitNSeconds(1);
                        GlobalDataContainerClass.StatusBarText = "";
                        return;
                    }
                }
                #endregion
            }
        }
        #endregion


        //CONFIG TEXTBOX CHECKING
        #region
        private void comboBoxConfigurationSerialPorts_Leave(object sender, EventArgs e)
        {
            try
            {
                if (GlobalDataContainerClass.ConnectivityStatus);
                {
                    comboBoxConfigurationSerialPorts.SelectedItem = GlobalDataContainerClass.PortNameChosen;
                }
            }
            catch (Exception)
            {
                comboBoxConfigurationSerialPorts.SelectedIndex = comboBoxConfigurationSerialPorts.Items.Count - 1;
            }

        }

        private void comboBoxConfigurationChoseBaudRate_Leave(object sender, EventArgs e)
        {
            /*
            try
            {
                if (GlobalDataContainerClass.ConnectivityStatus) ;
                {
                    comboBoxConfigurationChoseBaudRate.SelectedItem = GlobalDataContainerClass.BaudRateChosen.ToString();
                }
            }
            catch (Exception)
            {
                comboBoxConfigurationChoseBaudRate.SelectedIndex = comboBoxConfigurationChoseBaudRate.Items.Count - 1;
                throw;
            }
            */

        }
        #endregion
        #endregion
        /////////////////////////////////////////////



        /////////////// TAB CONTROLLING ///////////////
        #region

        //TAB CHANGED => MAKE TAB TICKER TRIGGER
        #region
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalDataContainerClass.ChangedTabSize = true;
        }
        #endregion


        //TICKER - TABCONTROLLING MAIN
        #region
        private void timerTabContoller_Tick(object sender, EventArgs e)
        {
            //TAB IS CHANGED
            if (GlobalDataContainerClass.ChangedTabSize)
            {
                //CHANGED TO CONFIGURATION
                #region
                if (tabControlMain.SelectedTab == tabControlMain.TabPages["tabPageConfiguration"])
                {
                    labelMainTitle.Text = "Setup && Config";
                    this.MinimumSize = new Size(860, 570);
                    this.Size = new Size(860, 570);

                    // If not connected, select first RDC as default
                    if (GlobalDataContainerClass.ConnectivityStatus == false)
                    {
                        
                    }

                    // LOAD DATA FROM DEVICE
                    if (GlobalDataContainerClass.ConnectivityStatus)
                    {

                    }


                    // DEFAULT OR SELECTED BAUD RATE
                    /*
                    if (GlobalDataContainerClass.BaudRateChosen == 0)
                    {
                        comboBoxConfigurationChoseBaudRate.SelectedIndex = 2;
                    }
                    else
                    {
                        comboBoxConfigurationChoseBaudRate.SelectedIndex = comboBoxConfigurationChoseBaudRate.FindString(GlobalDataContainerClass.BaudRateChosen.ToString());
                    }
                    */

                    //DEFAULT OR SELECTED PORTNAME
                    if (GlobalDataContainerClass.PortNameChosen == "N/A")
                    {
                        comboBoxConfigurationSerialPorts.Items.Clear();
                        string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
                        foreach (string ports in comPorts)
                        {
                            comboBoxConfigurationSerialPorts.Items.Add(ports);
                        }
                        comboBoxConfigurationSerialPorts.SelectedIndex = comboBoxConfigurationSerialPorts.Items.Count - 1;
                    }
                    else
                    {
                        comboBoxConfigurationSerialPorts.SelectedIndex = comboBoxConfigurationSerialPorts.FindString(GlobalDataContainerClass.PortNameChosen.ToString());
                    }

                    //DEVICE NAME
                    if (GlobalDataContainerClass.DeviceName == "")
                    {
                        textBoxConfigurationDeviceName.Text = "";
                    }
                    else
                    {
                        textBoxConfigurationDeviceName.Text = GlobalDataContainerClass.DeviceName;
                    }


                    //DEFAULT OR SELECTED URV
                    if (GlobalDataContainerClass.DeviceURV == 0)
                    {
                        textBoxConfigurationURV.Text = "0" + GlobalDataContainerClass.NumSeperator + "0";
                    }
                    else
                    {
                        textBoxConfigurationURV.Text = GlobalDataContainerClass.DeviceURV.ToString();
                    }

                    //DEFAULT OR SELECTED LRV
                    if (GlobalDataContainerClass.DeviceLRV == 0)
                    {
                        textBoxConfigurationLRV.Text = "0" + GlobalDataContainerClass.NumSeperator + "0" ;
                    }
                    else
                    {
                        textBoxConfigurationLRV.Text = GlobalDataContainerClass.DeviceLRV.ToString();
                    }


                    //DEFAULT OR SELECTED ALO
                    if (GlobalDataContainerClass.DeviceALO == 0)
                    {
                        textBoxConfigurationAlarmLow.Text = "0";
                    }
                    else
                    {
                        textBoxConfigurationAlarmLow.Text = GlobalDataContainerClass.DeviceALO.ToString();
                    }

                    //DEFAULT OR SELECTED AHI
                    if (GlobalDataContainerClass.DeviceAHI == 0)
                    {
                        textBoxConfigurationAlarmHigh.Text = "0";
                    }
                    else
                    {
                        textBoxConfigurationAlarmHigh.Text = GlobalDataContainerClass.DeviceAHI.ToString();
                    }
                }
                #endregion

                //CHANGED TO DASHBOARD
                #region
                else
                {
                    labelMainTitle.Text = "Dashboard";
                    this.MinimumSize = new Size(967, 708);
                    this.Size = new Size(967, 708);
                }
                #endregion

                GlobalDataContainerClass.ChangedTabSize = false; //TAB CHANGED DONE
            }
        }
        #endregion

        #endregion
        /////////////////////////////////////////////



        /////////////// OTHER FUNCTIONS AND STUFF ///////////////
        #region
        //Personal sleeper
        #region
        private void WaitNSeconds(double segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        #endregion


        //Logfile Saver
        #region
        private void SaveConfigLogFile()
        {
            try
            {
                string sPath = @"SoftSensConf_ConfigLog_" + DateTime.Now.ToString("dd-MM-yyyy") + ".csv"; //Path

                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);

                SaveFile.WriteLine("SoftSensConf_Version:" + GlobalDataContainerClass.SoftWareVersion
                                      + ";DateTime_Logging: " + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss"));//Informational top info
                SaveFile.WriteLine("DeviceName;LRV;URV;ALARM-L;ALARM-H;DateTimeOfConfig"); // Insert headers

                foreach (var line in GlobalDataContainerClass.ConfigurationLog)
                {
                    SaveFile.WriteLine(line);
                }
                SaveFile.Close();
            }
            catch (Exception)
            {
                //
            }
        }
        #endregion


        // ABOUT WINDOW
        #region
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBoxSoftSenseConf aboutWindow = new AboutBoxSoftSenseConf();
            aboutWindow.ShowDialog(this);
        }
        #endregion


        // RESET ALARM TICKER
        #region
        private void StopAlarmRequest()
        {
            GlobalDataContainerClass.AlarmTickCount = 0;
        }
        #endregion


        //RESET VARIABLES
        #region
        private void ConnectionLostReset()
        {
            GlobalDataContainerClass.ConnectivityStatus = false;
            GlobalDataContainerClass.BaudRateChosen = 0;
            GlobalDataContainerClass.PortNameChosen = "N/A";
            GlobalDataContainerClass.DeviceURV = Double.Parse("0" + GlobalDataContainerClass.NumSeperator + "0");
            GlobalDataContainerClass.DeviceLRV = Double.Parse("0" + GlobalDataContainerClass.NumSeperator + "0");
            GlobalDataContainerClass.DeviceALO = 0;
            GlobalDataContainerClass.DeviceAHI = 0;
            GlobalDataContainerClass.DeviceName = "";
            GlobalDataContainerClass.configReceived = "";
            GlobalDataContainerClass.configToBeSent = "";
            GlobalDataContainerClass.CommunicationType = "";
            GlobalDataContainerClass.IOType = "";
            GlobalDataContainerClass.ScanningFrequency = 1;
            GlobalDataContainerClass.LiveData = false;
            StopAlarmRequest();

            //Alarm stuff
            if (pictureBoxDashboardError.Image != null)
            {
                pictureBoxDashboardError.Image.Dispose(); //Remove picture
                pictureBoxDashboardError.Image = null; //Removes any picture
            }
            textBoxDashboardError.Text = "";
            GlobalDataContainerClass.AlarmStatus = 0; //Reset value to default
        }

        #endregion


        //ALARM TICKER
        #region
        private void timerAlarmRequester_Tick(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.AlarmTickCount >= 16 && GlobalDataContainerClass.LiveData)
            {
                GlobalDataContainerClass.AlarmRequested = true;
                GlobalDataContainerClass.AlarmReceived = true;
            }
            else
            {
                GlobalDataContainerClass.AlarmRequested = false;
            }

            if (GlobalDataContainerClass.ConnectivityStatus && GlobalDataContainerClass.LiveData)
            {
                GlobalDataContainerClass.AlarmTickCount += 1;
            }

        }
        #endregion


        //MOUSE HOVERING (MORE)
        #region
        private void buttonMenuBarConfiguration_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Port, Baud Rate etc.";
        }

        private void buttonDashboard_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Graphs and data";
        }

        private void resetStatusBarText(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "";
        }

        private void timerStatusBarChecker_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = GlobalDataContainerClass.StatusBarText;
        }

        private void textBoxMainConnectivity_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Connectivity status";
        }

        private void textBoxMainUserName_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Device name";
        }

        private void buttonMenuBarExit_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Close program";
        }

        private void labelSoftwareVersion_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Program verison";
        }

        private void GotoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Goto a specific window";
        }

        private void dashboardToolStripMenuItemDahshboard_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Goto dashboard";
        }

        private void setupConfigToolStripMenuItemSetupAndConfig_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Goto setup and config";
        }
        #endregion


        //CLOSE FROM MENU
        #region
        #endregion



        // SQL Commands
        #region
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBoxSetupRDCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update RDC Info
            #region
            try
            {
                string sqlSelectQuery = "" +
                "SELECT IPv4Address "+
                "FROM dbo.RDC "+
                "WHERE RDC_ID = " + comboBoxSetupRDCID.SelectedItem.ToString();

                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                connect.Open();

                SqlDataReader rdcDataReader = command.ExecuteReader();

                while (rdcDataReader.Read())
                {
                    textBoxSetupRDCIPAddress.Text = rdcDataReader[0].ToString();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
            finally
            {
                connect.Close();
            }
            #endregion



            //Update DAU Dropdown list
            #region
            try
            {
                string sqlSelectQuery = "SELECT DAU.DAU_ID, DAU.DeviceName " +
                    "FROM DAU " +
                    "WHERE DAU.RDC_ID = " + comboBoxSetupRDCID.SelectedItem.ToString() + " " +
                    "ORDER BY DAU_ID ASC";

                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                connect.Open();

                SqlDataReader rdcDataReader = command.ExecuteReader();

                comboBoxSetupDAUID.Items.Clear();
                comboBoxSetupDAUDeviceName.Items.Clear();

                while (rdcDataReader.Read())
                {
                    comboBoxSetupDAUID.Items.Add(rdcDataReader[0].ToString());
                    comboBoxSetupDAUDeviceName.Items.Add(rdcDataReader[1].ToString());
                }
                connect.Close();

                comboBoxSetupDAUID.SelectedIndex = 0;
                comboBoxSetupDAUDeviceName.SelectedIndex = 0;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error: " + error);
            }
            finally
            {
                connect.Close();
            }
            #endregion

        }

        // Change DAU ID if DeviceName is changed
        #region
        private void comboBoxSetupDAUDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSetupDAUID.SelectedIndex = comboBoxSetupDAUDeviceName.SelectedIndex;
        }
        #endregion


        private void comboBoxSetupDAUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update DAU Fields
            #region
            try
            {
                string sqlSelectQuery = "" +
                "SELECT DAU.DeviceName, DAU.ComPort, BAUDRATE.BaudRate, DAU.InstallmentDate, DAU.LastUpdatedDate, AREA.AreaCode, FACILITY.FacilityName, COUNTRY.Country " +
                "FROM DAU INNER JOIN BAUDRATE ON DAU.BaudRate_ID = BAUDRATE.BaudRate_ID INNER JOIN " +
                "AREA ON DAU.Area_ID = AREA.Area_ID INNER JOIN " +
                "FACILITY ON AREA.Facility_ID = FACILITY.Facility_ID INNER JOIN " +
                "COUNTRY ON FACILITY.Country_ID = COUNTRY.Country_ID " +
                "WHERE DAU_ID = " + comboBoxSetupDAUID.SelectedItem.ToString();

                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                connect.Open();

                SqlDataReader rdcDataReader = command.ExecuteReader();

                while (rdcDataReader.Read())
                {
                    comboBoxSetupDAUDeviceName.SelectedItem = rdcDataReader[0].ToString();
                    textBoxSetupDAUComPort.Text = rdcDataReader[1].ToString();
                    textBoxSetupDAUBaudRate.Text = rdcDataReader[2].ToString();
                    textBoxSetupDAUInstallmentDate.Text = rdcDataReader[3].ToString();
                    textBoxSetupDAULastUpdated.Text = rdcDataReader[4].ToString();
                    textBoxSetupDAUAreaCode.Text = rdcDataReader[5].ToString();
                    textBoxSetupDAUFacility.Text = rdcDataReader[6].ToString();
                    textBoxSetupDAUCountry.Text = rdcDataReader[7].ToString();
                }
                connect.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show("Error: " + error);
            }
            finally
            {
                connect.Close();
            }
            #endregion


            //Update Instrument Dropdown list
            #region
            try
            {
                string sqlSelectQuery = "SELECT INSTRUMENT.Tag " +
                    "FROM INSTRUMENT " +
                    "WHERE INSTRUMENT.DAU_ID = " + comboBoxSetupDAUID.SelectedItem.ToString() + " " +
                    "ORDER BY Tag ASC";

                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                connect.Open();

                SqlDataReader rdcDataReader = command.ExecuteReader();

                comboBoxConfigurationTag.Items.Clear();

                while (rdcDataReader.Read())
                {
                    comboBoxConfigurationTag.Items.Add(rdcDataReader[0].ToString());
                }
                connect.Close();

                comboBoxConfigurationTag.SelectedIndex = 0;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Instruments connected to selected DAU!", "No Instrument", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxConfigurationTag.Items.Clear();
                comboBoxConfigurationTag.Text = "";
            }
            catch (Exception error)
            {

                MessageBox.Show("Error: " + error);
            }
            finally
            {
                connect.Close();
            }
            #endregion

        }

        private void comboBoxConfigurationDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset dashboard data
            buttonDashboardResetDatapoints_Click(sender, e);
            #region
            try
            {
                string sqlSelectQuery = "" +
                "SELECT INSTRUMENT.LowerRangeValue, INSTRUMENT.UpperRangeValue, INSTRUMENT.AlarmLow, INSTRUMENT.AlarmHigh, IOTYPE.IOType, SCANNINGFREQUENCY.ScanningFrequency, " +
                "AREA.AreaCode, FACILITY.FacilityName, COUNTRY.Country, COMMUNICATION.CommunicationType, LastUpdatedDate " +
                "FROM INSTRUMENT INNER JOIN " +
                "IOTYPE ON INSTRUMENT.IOType_ID = IOTYPE.IOType_ID INNER JOIN " +
                "SCANNINGFREQUENCY ON INSTRUMENT.ScanningFrequency_ID = SCANNINGFREQUENCY.ScanningFrequency_ID INNER JOIN " +
                "AREA ON INSTRUMENT.Area_ID = AREA.Area_ID INNER JOIN " +
                "FACILITY ON AREA.Facility_ID = FACILITY.Facility_ID INNER JOIN " +
                "COUNTRY ON FACILITY.Country_ID = COUNTRY.Country_ID INNER JOIN " +
                "COMMUNICATION ON INSTRUMENT.Communication_ID = COMMUNICATION.Communication_ID " +
                "WHERE INSTRUMENT.Tag = '" + comboBoxConfigurationTag.SelectedItem.ToString() + "'";
                
                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                connect.Open();

                SqlDataReader rdcDataReader = command.ExecuteReader();

                while (rdcDataReader.Read())
                {
                    textBoxConfigurationLRV.Text = rdcDataReader[0].ToString();
                    textBoxConfigurationURV.Text = rdcDataReader[1].ToString();
                    textBoxConfigurationAlarmLow.Text = rdcDataReader[2].ToString();
                    textBoxConfigurationAlarmHigh.Text = rdcDataReader[3].ToString();
                    textBoxConfigurationIType.Text = rdcDataReader[4].ToString();
                    textBoxConfigurationScanningFrequency.Text = rdcDataReader[5].ToString();
                    textBoxConfigurationAreaCode.Text = rdcDataReader[6].ToString();
                    textBoxConfigurationFacility.Text = rdcDataReader[7].ToString();
                    textBoxConfigurationCountry.Text = rdcDataReader[8].ToString();
                    textBoxConfigurationCommunicationType.Text = rdcDataReader[9].ToString();
                    textBoxConfigurationLastUpdated.Text = rdcDataReader[10].ToString();
                }
                connect.Close();

                // Add values to global values

            }
            catch (Exception error)
            {

                MessageBox.Show("Error: " + error);
            }
            finally
            {
                connect.Close();
            }

            //Update global variables if connected
            if (GlobalDataContainerClass.ConnectivityStatus)
            {
                GlobalDataContainerClass.DeviceName = comboBoxConfigurationTag.SelectedItem.ToString();
                GlobalDataContainerClass.DeviceLRV = Convert.ToDouble(textBoxConfigurationLRV.Text);
                GlobalDataContainerClass.DeviceURV = Convert.ToDouble(textBoxConfigurationURV.Text);
                GlobalDataContainerClass.DeviceALO = Convert.ToInt32(textBoxConfigurationAlarmLow.Text);
                GlobalDataContainerClass.DeviceAHI = Convert.ToInt32(textBoxConfigurationAlarmHigh.Text);
                GlobalDataContainerClass.IOType = textBoxConfigurationIType.Text;
                GlobalDataContainerClass.ScanningFrequency = Convert.ToDouble(textBoxConfigurationScanningFrequency.Text);
                GlobalDataContainerClass.CommunicationType = textBoxConfigurationCommunicationType.Text;
            }
            #endregion
            
            
        }


        private void textBoxSetupDAUBaudRate_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Select baud rate";
        }

        private void textBoxSetupDAUComPort_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Select communication port";
        }

        private void textBoxDashboardFrequency_MouseHover(object sender, EventArgs e)
        {
            GlobalDataContainerClass.StatusBarText = "Scanning frequency in Hz";
        }


        private int AddInstrumentLog(string tagname)
        {
            try
            {
                string sqlInsertQuery = "INSERT INTO INSTRUMENTLOG (Tag, LogTimestamp) output INSERTED.Log_ID VALUES (@tag, @ts)";

                SqlCommand command = new SqlCommand(sqlInsertQuery, connect);

                command.Parameters.AddWithValue("@tag", tagname);
                command.Parameters.AddWithValue("@ts", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                connect.Open();

                int modified = (int)command.ExecuteScalar();
                
                connect.Close();

                return modified;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
                return -1;
            }
            finally
            {
                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int testings = AddInstrumentLog(GlobalDataContainerClass.DeviceName);
            label4.Text = testings.ToString();
        }


        #endregion

        #endregion
        /////////////////////////////////////////////

    }
}

