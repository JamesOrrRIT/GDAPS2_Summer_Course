using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesOrr_PE08
{
    class Child
    {
        //Saves the name of the child object
        private string name;

        //Creates a saying for the child object
        private string saying;

        //Parametized constructor that takes two string values to create the child object
        public Child(string childName, string childSaying)
        {
            this.name = childName;
            this.saying = childSaying;
        }

        public void Whine()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(name + " : " + saying + " ");
            }
        }
    }
}
