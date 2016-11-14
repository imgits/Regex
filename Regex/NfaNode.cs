using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class NFA_Node
    {
        List<NFA_Line> InputLines=new List<NFA_Line>();
        List<NFA_Line> OutputLines=new List<NFA_Line>();
        public bool IsStartNode;
        public bool IsEndNode;
        public int Index;
        public NFA_Node(int index=-1)
        {
            IsStartNode = false;
            IsEndNode = false;
            Index = index;
        }

        public void AddInputLine(NFA_Line line)
        {
            InputLines.Add(line);
        }

        public void AddOutputLine(NFA_Line line)
        {
            OutputLines.Add(line);
        }

        public void RemoveInputLine(NFA_Line line)
        {
            InputLines.Remove(line);
        }

        public void RemoveOutputLine(NFA_Line line)
        {
            OutputLines.Remove(line);
        }
    }
}
