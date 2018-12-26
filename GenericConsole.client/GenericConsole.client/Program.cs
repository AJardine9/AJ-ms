using System;
using glm = GenericConsole.Library.Models;


namespace GenericConsole.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var g = new GenericModel<string>();
            //    var h = new GenericModel<int>();
            //    g.Hello();
            //    h.Hello();

            PlayWithGeneric();
        }
        static void PlayWithGeneric()
            {
                var c1 = new glm.Client();
                var c2 = new glm.Client();
                foreach (var item in glm.Client.Clients.Peoples)
                {
                    System.Console.WriteLine("{0}\n{1}", item.Name, item.Title);
                }
            }

        public static void PlayWithGenericEmployee()
        {
            var a1 = new glm.Employee<glm.Associate>();
            var a2 = new glm.Employee<glm.Associate>();
            var t1 = new glm.Employee<glm.Trainer>();
            var t2 = new glm.Employee<glm.Trainer>();


        }
        
        
    }
}
