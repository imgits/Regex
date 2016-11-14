using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class NFA_Line
    {
        NFA_Node FromNode;
        NFA_Node ToNode;
        string Text;
        public NFA_Line(string text=null, NFA_Node from_node=null, NFA_Node to_node=null)
        {
            Text = text;
            FromNode = from_node;
            ToNode = to_node;
            if (from_node!=null) from_node.AddOutputLine(this);
            if (to_node != null) to_node.AddInputLine(this);
        }

        public void Link(NFA_Node from_node, NFA_Node to_node)
        {
            FromNode = from_node;
            ToNode = to_node;
            from_node.AddOutputLine(this);
            to_node.AddInputLine(this);
        }

    }
}
