using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateWorld.Domain.Models
{
    public class Delegation
    {
        public delegate void NameTag();

        public delegate string Sharpie(string f, string l);

        public void TheConference(NameTag nt, Sharpie s, string f, string l)
        {
            nt(s(f, l));
        }

        public void MyConference()
        {
            TheConference((string s) =>
            { System.Console.WriteLine(s)}, 
            (string o, string t) ={ return $"{o} {t}"; },
            "fred",
            "belotte"
            );
            
    }
}
