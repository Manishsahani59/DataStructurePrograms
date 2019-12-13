using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class CNode
    {
        public CNode next;
        public object data;

        public CNode(object data)
        {
            this.data = data;
            this.next = null;
        }

    }
}
