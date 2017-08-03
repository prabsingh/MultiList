using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    class Multilist
    {
        private NodeFactory factory;
        private Node multilistHead;

        public Multilist()
        {
            factory = new NodeFactory();
            multilistHead = factory.createNodeHead();
        }

        public void displayAllClassesOfStudent(int pStudentNum)
        {

        }

        public void displayAllStudentsOfClass(int pClassNum)
        {

        }

        public void addStudentToClass(int pStudentNum, int pClassNum, int pGrade)
        {
            //check student and class exists
            // if not then create those respective headers
            Node previousStudent = multilistHead;
            Node currentStudent = multilistHead;

            bool keepgoing = true;
            while(keepgoing)
            {
                if(currentStudent.StudentNum < pStudentNum)
                {
                    previousStudent = currentStudent;
                    currentStudent = currentStudent.NextStudent;
                }
                else if(currentStudent.StudentNum == pStudentNum)
                {
                    keepgoing = false;
                }
                else
                {
                    Node studentHeader = factory.createStudentHeader(pStudentNum);
                    studentHeader.NextStudent = previousStudent.NextStudent;
                    previousStudent.NextStudent = studentHeader;
                    keepgoing = false;
                }
            }

            Node previousClass = multilistHead;
            Node currentClass = multilistHead;

            bool keepgoing2 = true;
            while(keepgoing2)
            {
                if (currentClass.ClassNum < pClassNum)
                {
                    previousClass = currentClass;
                    currentClass = currentClass.NextClass;
                }
                else if (currentClass.ClassNum == pClassNum)
                {
                    keepgoing2 = false;
                }
                else
                {
                    Node classHeader = factory.createClassHeader(pClassNum);
                    classHeader.NextClass = previousClass.NextClass;
                    previousClass.NextClass = classHeader;
                    keepgoing2 = false;
                }
            }

            //create node and add it to multilist
            Node StudentClass = factory.createNode(pStudentNum, pClassNum, pGrade);

        }
    }
}
