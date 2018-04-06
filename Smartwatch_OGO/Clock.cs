using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Smartwatch_OGO
{
    class Clock
    {
        private Timer TimerClock;
        private static int Hours;
        private static int Minutes;
        private static int Seconds;

        

        public Clock()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;


            TimerClock = new Timer();   // Timer aanmaken met 1 sec interval
            TimerClock.Interval = 1000;
            TimerClock.Elapsed += new ElapsedEventHandler(timeTick);    // Wat hij moet uitvoeren om de seconde
            TimerClock.Start();
       }

        private void incrementHours()   // Wanneer minuten 60 is wordt deze aangeroepen
        {
            Hours++;
            if(Hours == 24)
            {
                Hours = 0;
            }
        }

        private void incrementMinutes() // Wanneer seconden 60 is wordt deze aangeroepen
        {
            Minutes++;
            if(Minutes == 60)
            {
                Minutes = 0;
                incrementHours();
            }
        }

        private void showTime() // Print de tijd in de console voor het check of de timer werkt
        {
            String hours = "0";
            String minutes = "0";
            String seconds = "0";

            if (Hours < 10)
            {
                hours = "0" + Hours.ToString();
            } else
            {
                hours = Hours.ToString();
            }

            if (Minutes < 10)
            {
                minutes = "0" + Minutes.ToString();
            }
            else
            {
                minutes = Minutes.ToString();
            }

            if (Seconds < 10)
            {
                seconds = "0" + Seconds.ToString();
            }
            else
            {
                seconds = Seconds.ToString();
            }

            
            Console.WriteLine("Het is: " + hours + ":" + minutes + ":" + seconds);
            //Console.SetCursorPosition(0, Console.CursorTop - 1); // als je dit uncomment plakt hij niet alles onder elkaar maar op de bovenste regel in de console
        }

        public String getHours()    // Haalt de uren op, dit wordt uiteindelijk naar de gui gestuurd
        {
            String hours = "0";
            
            if (Hours < 10)
            {
                return hours = "0" + Hours.ToString();
            }
            else
            {
                return hours = Hours.ToString();
            }
        }

        public String getMinutes()  // Haalt de minuten op, dit wordt uiteindelijk naar de gui gestuurd
        {
            String minutes = "0";

            if(Minutes < 10)
            {
                return minutes = "0" + Minutes.ToString();
            }
            else
            {
                return minutes = Minutes.ToString();
            }
        }

        private void timeTick(object source, EventArgs e)   // Dit wordt uitgevoerd na de interval van de timer
        {
            // Telt de seconden en verhoogt minuten wanneer seconden 60 is

            Seconds++;
            if (Seconds == 60)
            {
                incrementMinutes();
                Seconds = 0;
            }
            showTime(); // Geeft de tijd weer in console elke seconde
        }



    }
}
