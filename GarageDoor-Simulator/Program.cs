using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace GarageDoorOpener
{
    class Program
    {
        public static string DoorStatus;
        public static bool WasClosing;
        public static bool WasOpening;

        static void Main(string[] args)
        {
            

            Random myRand = new Random();
            int randomGenerated = myRand.Next(1, 3);

            string beforeStatus = "Closed";
            switch (randomGenerated)
            {
                case 1:
                    beforeStatus = "Closed";
                    break;
                case 2:
                    beforeStatus = "Open";
                    break;
                case 3:
                    beforeStatus = "Closed";
                    break;
            }

            if (beforeStatus == "Closed")
            {
                DoorStatus = "Opening";
                WasClosing = true;
            }
            else if (beforeStatus == "Open")
            {
                DoorStatus = "Closing";
                WasOpening = true;
            }
            else if (beforeStatus == "Stopped" && WasOpening == true)
            {
                DoorStatus = "Closing";
                WasOpening = false;
                WasClosing = true;
            }
            else if (beforeStatus == "Stopped" && WasClosing == true)
            {
                DoorStatus = "Opening";
                WasClosing = false;
                WasOpening = true;
            }

            Console.WriteLine("The door was " + beforeStatus + " it's now " + DoorStatus);
            Console.ReadKey();

        }
             
        
    }



}
