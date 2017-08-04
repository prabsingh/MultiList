using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    public class NodeFactory
    {
        public Node createMultilistHeader()
        {
            return new Node(0, 0, 0, null, null);
        }

        public Node createClassHeader(int pClassNum)
        {
            return new Node(0, pClassNum, 0, null, null);
        }

        public Node createStudentHeader(int pStudentNum)
        {
            return new Node(pStudentNum, 0, 0, null, null);
        }

        public Node createNode(int pStudentNum, int pClassNum, int pGrade)
        {
            return new Node(pStudentNum, pClassNum, pGrade, null, null);
        }
    }
}
