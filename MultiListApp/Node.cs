using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    public class Node
    {
        private int studentNum;
        private int classNum;
        private int grade;
        private Node nextStudent;
        private Node nextClass;

        public Node(int pStudentNum, int pClassNum, int pGrade, Node pNextStudent, Node pNextClass)
        {
            StudentNum = pStudentNum;
            ClassNum = pClassNum;
            Grade = pGrade;
            NextStudent = pNextStudent;
            NextClass = pNextClass;
        }

        public int StudentNum
        {
            get
            {
                return studentNum;
            }
            set
            {
                studentNum = value;
            }
        }

        public int ClassNum
        {
            get
            {
                return classNum;
            }
            set
            {
                classNum = value;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        public Node NextStudent
        {
            get
            {
                return nextStudent;
            }
            set
            {
                nextStudent = value;
            }
        }

        public Node NextClass
        {
            get
            {
                return nextClass;
            }
            set
            {
                nextClass = value;
            }
        }

    }
}
