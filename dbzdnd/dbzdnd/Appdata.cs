using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbzdnd
{
    //A class to store every variable and save / load it from file.
    class AppData
    {

        /// <summary>
        /// The single instance of the object.
        /// </summary>
        /// 
        private static AppData singleObject = null;
        private readonly static Object padlock = new Object();
        private MainForm _MainForm;
        /// <summary>
        /// Constructor (DON'T USE, USE Instance() INSTEAD!!!)
        /// </summary>
        public AppData()
        {

        }

        /// <summary>
        /// Loads the appData data
        /// </summary>
        /// <returns></returns>
        public static AppData loadAppData()
        {
            return null;
        }

        /// <summary>
        /// Used when this method is called from the initial forms. Creates a new appdata based on what the user wants to use.
        /// </summary>
        /// <param name="IP">The server's IP</param>
        /// <param name="online">Checks if the user wants to go online or offline</param>
        /// <param name="name">user's name, used to load the save</param>
        /// <param name="loadLocation">online / offline / none loading</param>
        /// <returns></returns>
        public static AppData Instance(int IP, bool online, string name, string loadLocation)
        {

            lock (padlock)
            {
                if (singleObject == null)
                {
                    //loads the saved appdata
                    singleObject = new AppData();

                    if (loadLocation == "online")
                    {
                        //singleObject = loadOnline(name, ip)
                    }
                    else if (loadLocation == "offline")
                    {
                        singleObject = loadAppData();
                    }
                }
                singleObject._MainForm = new MainForm();
                singleObject._MainForm.Show();
                return singleObject;
            }

        }

        /// <summary>
        /// Returns a single static object of this class
        /// </summary>
        public static AppData Instance()
        {
            lock (padlock)
            {
                return singleObject;
            }

        }
    }

}
