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
        /// Generates an instance of this class.
        /// </summary>
        public static AppData Instance()
        {

            lock (padlock)
            {
                if (singleObject == null)
                {
                    singleObject = new AppData();
                    AppData getFile = loadAppData();
                    if (getFile != null)
                    {
                        if (MessageBox.Show("Do you want to continue your last session?", "Confirm Load", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            singleObject = getFile;
                        }
                    }

                }

                return singleObject;
            }

        }
    }

}
