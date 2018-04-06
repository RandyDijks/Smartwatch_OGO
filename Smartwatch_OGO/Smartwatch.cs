using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;

namespace Smartwatch_OGO
{
    class Smartwatch
    {
        private Mode currentMode;
        private ArrayList modes;    // Dit is een arraylist nu omdat een CircularLinkedList niet bestaat in C#
        private Form1 GUI;

        public Smartwatch()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GUI = new Form1();
            Application.Run(GUI);

            modes = new ArrayList();
            

            addModi();  // Modi toevoegen aan de list
            currentMode = (Mode) modes[0];  // Currentmode aangeven
            getDisplay();   // Het updaten van de tijd in de GUI


            Console.ReadLine(); // Onderaan houden, anders gaat de console meteen weg
        }

        private void addModi()
        {
            // index 0 is time and index 1 is calendar mode

            Mode Time = new ModeTime();
            // Mode Calendar = new ModeCalendar();

            modes.Add(Time);
        }

        public void getDisplay() // Dit werkt dus niet omdat je een label niet kan updaten
        {
            //String time = currentMode.getDisplay();
            //GUI.updateTime(time);
            //return time;
        }

        [STAThread]
        static void Main()
        {
            new Smartwatch();
        }
    }
}
