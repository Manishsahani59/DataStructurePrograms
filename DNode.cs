using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class DNode
    {
        public DNode next;
        public DNode previous;
        public object data;

        public DNode(object data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }

      

    }
}
