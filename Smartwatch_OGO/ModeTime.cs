using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartwatch_OGO
{
    class ModeTime : Mode
    {
        private Clock clock;    // Clock aanmaken voor time modus

        public ModeTime()   
        {
            clock = new Clock();
        }

        public String getDisplay()      // Haalt de tijd op vanuit de Clock klasse 
        {
            return clock.getHours() + ":" + clock.getMinutes();
        }
    }
}
