using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class GenericModel<T>
    {
        public void Hello()
        {
            System.Console.WriteLine("i am generic");
        }
    }
}
