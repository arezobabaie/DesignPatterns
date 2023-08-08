using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace SingletoneDesignPattern
{
    // This class is sealed, which means it cannot be inherited.
    public sealed class ApplicationGeneralReport
    {
        // This is the single instance of the class that will be created.
        private static ApplicationGeneralReport uniqueInstance = null;

        // This object is used for locking to ensure thread safety when creating the instance.
        private static readonly object padlock = new object();

        // The constructor is private, which means it cannot be called from outside the class.
        // This is a key part of the Singleton pattern.
        private ApplicationGeneralReport() { }

        public int OnlineUsers { get; set; }
        public int TodayViews { get; set; }

        // This is the property you use to get the instance of the class.
        public static ApplicationGeneralReport Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    // This lock ensures that only one thread can enter this block of code at a time.
                    // This is necessary to ensure that only one instance of the class is created in the case of concurrent access.
                    lock (padlock)
                    {
                        if (uniqueInstance == null)
                        {
                            // If the instance has not been created yet, create it.
                            uniqueInstance = new ApplicationGeneralReport();
                        }
                    }
                }

                return uniqueInstance;
            }

        }
    }
}


