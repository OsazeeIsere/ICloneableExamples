using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A first look at Interface \n");

            //all thes classes support the Icloneable interface
            string myString = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix,
                new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

            //therefore they can all be passed into method taking
            //Icloneable
            CloneMe(myString);
            CloneMe(unixOS);
            CloneMe(sqlCnn);


        }

        private static void CloneMe(ICloneable c)
        {
            //Clone whatever we get and print out name
            object theClone = c.Clone();
            Console.WriteLine("Your Clone is a: {0}", theClone.GetType().Name);

        }
    }
}
