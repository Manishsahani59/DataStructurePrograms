using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class BalanceToken
    {

        public void balanceToken()
        {
           char[] exp = { '[','{', '(', ')', '}', '[', ']',']' };
           Console.WriteLine(Utility.AreBalanced(exp));

        }

    }
}
