using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil = new Pupil("Roman", "Popper");
            Pupil pupil2 = new Pupil("Martin", "Popper");

            Console.WriteLine(pupil.ToString());
            Console.WriteLine(pupil2.ToString());

        }
    }
}
