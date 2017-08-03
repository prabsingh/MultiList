using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    class NodeFactory
    {
        public Node createNode(int pStudentNum, int pClassNum, int pGrade)
        {
            return new Node(pStudentNum, pClassNum, null, null, pGrade);
        }

        public Node createStudentHeader(int pStudentNum)
        {
            return new Node(pStudentNum, 0, null, null, 0);
        }

        public Node createClassHeader(int pClassNum)
        {
            return new Node(0, pClassNum, null, null, 0);
        }

        public Node createNodeHead()
        {
            return new Node(0, 0, null, null, 0);
        }
    }
}
