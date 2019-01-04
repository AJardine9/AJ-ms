using System;
using System.Collections.Generic;
using System.Text;

namespace Variance.Domain.Models
{
   public class Casting
    {
        public void Implicit()
        {
            int x = 10;
            long y = x;

            System.Console.WriteLine(y);
        }

        public void Explicit()
        {//this is an example of boxing becasue value type can not have null value 
            short x = 10;
            byte y = (byte)x;// throw exception if not able to cast 
            Nullable<byte> z = x as byte?;//raises a null value if not able to cast. 

            System.Console.WriteLine(y);
        }// not testable because the point of this explicit method is to display. 

        public IEnumerable<byte?> Explicit(short x)
        {
            byte y = (byte) x;
            byte? z = x as byte?;

            // return y;
            //return z;

            //return new { y1 = y, z1 = z };//anonymous object, valuable but not in our case
            return new byte?[] {y,z};
        }

        public void Explicit(short x, out byte y, out byte? z)//out parameter job is to receive value , out gives value from inside out , hence being called 'out'
        {
            y = (byte)x;
            z = x as byte?;

        }
        public void Explicit (ref short w, ref short x, out byte y)
        {
            x = 100; 
            w = x;
            byte y = (byte)w;
            byte? z = w as byte?;
        }

        public void Converting()
        {
            int x = Convert.ToInt16(true);
            bool y = Convert.ToBoolean(x);
            int z = Convert.ToInt32("banana");
        }
        
        public Nullable<int> ConvertingInt(string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch(System.Exception)
            {
                return null;
            }
        }
    }
}
