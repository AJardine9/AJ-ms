using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.client
{
    public class Robot
    {
      private string _name ;
        public string Name
        {
            get => _name;
            private set
            { 
                _name = value;
            }

        }



        public void Talk(string beeps = "beepitty beep")
        {

        }

        public void Talk(int time, string beeps = "beepitty beep", bool mouthlight = true)
        {

        }


        class Robo2 : Robot
        {
            void x()
            {
                Talk("beep ... I am Robo2 beep");
            }
        }


        class Robo3 : Robot
        {
            void n()
            {
                Talk(3, "I am Robo3...beep", true);
            }
        }


    }
}
