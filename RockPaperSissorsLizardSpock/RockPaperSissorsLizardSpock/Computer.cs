using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    public class Computer
    {
        //place random class in here

        public Computer()
        {
            Random rmd = new Random();
            rmd.Next(0, 5);
        }

    }
}
