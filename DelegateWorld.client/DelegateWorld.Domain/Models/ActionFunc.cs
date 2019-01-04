﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateWorld.Domain.Models
{
    public class ActionFunc
    {
        Action<string> NameTag = (string name) =>
        {
            System.Console.WriteLine(name);
        };

        Func<string, string, string> Sharpie = (string first, string last) =>
         {
             return string.Format("{0} {1}", first,last);
         };

        public string Sharpie2(string f, string l)
        {
           // return string.Format("{0} {1}", first, last);
           return Sharpie(f, l);
        }

        public void MyConference()
        {
            NameTag(Sharpie("fred","belotte"));
        }

        public void MyConference2(Func<string, string, string> sharper)
        {
            NameTag(sharper("fred", "belotte"));
        }
        public void TheConference()
            {
            MyConference2(Sharpie);
            MyConference2(Sharpie2);

        }
    }
}
