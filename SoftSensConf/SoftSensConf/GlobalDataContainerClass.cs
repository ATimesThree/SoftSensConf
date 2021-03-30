using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SoftSensConf
{
    class GlobalDataContainerClass
    {
        private static string v_SystemLang = "";
        private static string v_NumSeperator = "";

        //General
        private static string v_DeviceName = "";
        private static bool v_ConnectivityStatus = false;
        private static string v_StatusBarText = "";
        private static bool v_ChangedTabSize = true;
        private static List<string> v_ConfigurationLog = new List<string>(); //Config master log, continuesly overwrite existing (daily log)
        private static string v_SoftWareVersion = "1.0.0.0";
        private static bool v_RickAstleyDialogOpen = false;
        private static bool v_RickAstleyConfirmed = false;

        //Data Information
        private static Int32 v_NumberOfDataPoints = 0;
        private static Int32 v_BaudRateChosen = 0;
        private static string v_PortNameChosen = "N/A";
        private static bool v_LiveData = false;
        private static bool v_ScaledDataType = true;
        private static string v_RickAstley = "N/A";

        //Alarm Stuff
        private static Int32 v_AlarmTickCount = 0;
        private static Int32 v_AlarmStatus = 0;
        private static bool v_AlarmRequested = false;
        private static bool v_AlarmReceived = false;
        private static double v_DeviceURV = 0;
        private static double v_DeviceLRV = 0;
        private static Int32 v_DeviceAHI = 0;
        private static Int32 v_DeviceALO = 0;

        //WiFi Stuff
        private static bool v_WifiImageOnline = false;
        private static bool v_WifiImageChanged = false;

        //Config stuff
        private static string v_configToBeSent = "";
        private static string v_configReceived = "";


        #region
        public static string NumSeperator
        {
            get { return v_NumSeperator; }
            set { v_NumSeperator = value; }
        }

        public static string SystemLang
        {
            get { return v_SystemLang; }
            set { v_SystemLang = value; }
        }

        public static Int32 NumberOfDataPoints
        {
            get { return v_NumberOfDataPoints; }
            set { v_NumberOfDataPoints = value; }
        }
        
        public static bool ConnectivityStatus
        {
            get { return v_ConnectivityStatus; }
            set { v_ConnectivityStatus = value; }
        }

        public static string DeviceName
        {
            get { return v_DeviceName; }
            set { v_DeviceName = value; }
        }

        public static Int32 BaudRateChosen
        {
            get { return v_BaudRateChosen; }
            set { v_BaudRateChosen = value; }
        }

        public static string PortNameChosen
        {
            get { return v_PortNameChosen; }
            set { v_PortNameChosen = value; }
        }

        public static double DeviceURV
        {
            get { return v_DeviceURV; }
            set { v_DeviceURV = value; }
        }

        public static double DeviceLRV
        {
            get { return v_DeviceLRV; }
            set { v_DeviceLRV = value; }
        }

        public static Int32 DeviceAHI
        {
            get { return v_DeviceAHI; }
            set { v_DeviceAHI = value; }
        }

        public static Int32 AlarmTickCount
        {
            get { return v_AlarmTickCount; }
            set { v_AlarmTickCount = value; }
        }


        public static Int32 DeviceALO
        {
            get { return v_DeviceALO; }
            set { v_DeviceALO = value; }
        }

        public static bool ScaledDataType
        {
            get { return v_ScaledDataType; }
            set { v_ScaledDataType = value; }
        }

        public static bool AlarmReceived
        {
            get { return v_AlarmReceived; }
            set { v_AlarmReceived = value; }
        }


        public static Int32 AlarmStatus
        {
            get { return v_AlarmStatus; }
            set { v_AlarmStatus = value; }
        }

        public static bool WifiImageOnline
        {
            get { return v_WifiImageOnline; }
            set { v_WifiImageOnline = value; }
        }
        
        public static bool WifiImageChanged
        {
            get { return v_WifiImageChanged; }
            set { v_WifiImageChanged = value; }
        }
        
        public static bool LiveData
        {
            get { return v_LiveData; }
            set { v_LiveData = value; }
        }

        public static bool AlarmRequested
        {
            get { return v_AlarmRequested; }
            set { v_AlarmRequested = value; }
        }

        public static string StatusBarText
        {
            get { return v_StatusBarText; }
            set { v_StatusBarText = value; }
        }

        public static string RickAstley
        {
            get { return v_RickAstley; }
            set { v_RickAstley = value; }
        }

        public static List<string> ConfigurationLog
        {
            get { return v_ConfigurationLog; }
            set { v_ConfigurationLog = value; }
        }


        public static bool ChangedTabSize
        {
            get { return v_ChangedTabSize; }
            set { v_ChangedTabSize = value; }
        }

        public static bool RickAstleyDialogOpen
        {
            get { return v_RickAstleyDialogOpen; }
            set { v_RickAstleyDialogOpen = value; }
        }

        public static bool RickAstleyConfirmed
        {
            get { return v_RickAstleyConfirmed; }
            set { v_RickAstleyConfirmed = value; }
        }
        


        public static string configToBeSent
        {
            get { return v_configToBeSent; }
            set { v_configToBeSent = value; }
        }


        public static string configReceived
        {
            get { return v_configReceived; }
            set { v_configReceived = value; }
        }

        public static string SoftWareVersion
        {
            get { return v_SoftWareVersion; }
            set { v_SoftWareVersion = value; }
        }
        #endregion



    }
}
