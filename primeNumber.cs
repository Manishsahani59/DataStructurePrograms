using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class primeNumber
    {

        public void primenumber()
        {
            Console.WriteLine("Enter the size to check prime number");
            int size = Convert.ToInt32(Console.ReadLine());
            Utility.primeNumber(size);
        }

    }
}
