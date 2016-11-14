using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class Regex
    {
        List<NFA_Node> Nodes = new List<NFA_Node>();

        public void CreateNFA()
        {
            for (int i = 0; i < 11; i++)
            {
                NFA_Node node = new NFA_Node(i);
                Nodes.Add(node);
            }
            Nodes[0].IsStartNode = true;
            Nodes[0].IsEndNode = true;
            NFA_Line line;
            line = new NFA_Line(null, Nodes[0], Nodes[1]);
            line = new NFA_Line(null, Nodes[1], Nodes[2]);
            line = new NFA_Line("a", Nodes[2], Nodes[3]);
            line = new NFA_Line(null, Nodes[3], Nodes[4]);
            line = new NFA_Line("b", Nodes[4], Nodes[5]);
            line = new NFA_Line(null, Nodes[5], Nodes[10]);
            line = new NFA_Line(null, Nodes[10],Nodes[0]);

            line = new NFA_Line(null, Nodes[1], Nodes[6]);
            line = new NFA_Line("c", Nodes[6], Nodes[7]);
            line = new NFA_Line(null, Nodes[7], Nodes[8]);
            line = new NFA_Line("d", Nodes[8], Nodes[9]);
            line = new NFA_Line(null, Nodes[9], Nodes[10]);

        }
    }
}

 