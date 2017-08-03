using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    class Node
    {
        private int studentNum;
        private int classNum;
        private Node nextStudent;
        private Node nextClass;
        private int grade;

        public Node(int pStudentNum, int pClassNum,Node pNextStudent, Node pNextClass, int pGrade)
        {
            studentNum = pStudentNum;
            classNum = pClassNum;
            nextStudent = pNextStudent;
            nextClass = pNextClass;
            grade = pGrade;
        }

        public int StudentNum
        {
            get
            {
                return studentNum;
            }
        }

        public int ClassNum
        {
            get
            {
                return classNum;
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

    }
}
