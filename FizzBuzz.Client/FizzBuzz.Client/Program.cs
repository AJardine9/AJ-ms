using System;
using FizzConsole.Library.Models;

namespace FizzBuzz.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fizz = new GenericFizz();
            fizz.Input();
        }
    }
}
