using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Pupil
    {
        public string Name { get; }
        public string Surname { get; }

        public Pupil(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }
    }
}
