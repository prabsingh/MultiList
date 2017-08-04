using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    public class MultilistBuilder
    {
        private Node multilistHead;
        private NodeFactory factory;

        public MultilistBuilder()
        {
            factory = new NodeFactory();
            multilistHead = factory.createMultilistHeader();
        }

        public void addStudentToClass(int pStudentNum, int pClassNum, int pGrade)
        {
            checkAndCreateStudentHeader(pStudentNum);
            checkAndCreateClassHeader(pClassNum);

            Node nodeToAdd = factory.createNode(pStudentNum, pClassNum, pGrade);

            Node curNode = multilistHead;
            Node prevNode = multilistHead;

            #region Connecting to student 
            while (curNode.StudentNum < pStudentNum)
            {
                curNode = curNode.NextStudent;
            }

            prevNode = curNode;

            while (curNode != null && curNode.ClassNum < pClassNum)
            {
                prevNode = curNode;
                curNode = curNode.NextClass;
            }

            nodeToAdd.NextClass = curNode;
            prevNode.NextClass = nodeToAdd;
            #endregion

            curNode = multilistHead;
            prevNode = multilistHead;

            #region Connecting to Class
            while (curNode.ClassNum < pClassNum)
            {
                curNode = curNode.NextClass;
            }

            prevNode = curNode;

            while (curNode != null && curNode.StudentNum < pStudentNum)
            {
                prevNode = curNode;
                curNode = curNode.NextStudent;
            }

            nodeToAdd.NextStudent = curNode;
            prevNode.NextStudent = nodeToAdd;
            #endregion 

        }

        private void checkAndCreateStudentHeader(int pStudentNum)
        {
            Node curNode = multilistHead;
            Node prevNode = multilistHead;

            bool keepgoing = true;
            while (keepgoing)
            {
                if (curNode == null)
                {
                    Node studentHeader = factory.createStudentHeader(pStudentNum);
                    prevNode.NextStudent = studentHeader;

                    keepgoing = false;
                }
                else if (curNode.StudentNum < pStudentNum)
                {
                    prevNode = curNode;
                    curNode = curNode.NextStudent;
                }
                else if (curNode.StudentNum == pStudentNum)
                {
                    keepgoing = false;
                }
                else
                {
                    Node studentHeader = factory.createStudentHeader(pStudentNum);
                    studentHeader.NextStudent = curNode;
                    prevNode.NextStudent = studentHeader;

                    keepgoing = false;
                }
            }
        }

        private void checkAndCreateClassHeader(int pClassNum)
        {
            Node curNode = multilistHead;
            Node prevNode = multilistHead;

            bool keepgoing = true;
            while (keepgoing)
            {
                if (curNode == null)
                {
                    Node classHeader = factory.createClassHeader(pClassNum);
                    prevNode.NextClass = classHeader;

                    keepgoing = false;
                }
                else if (curNode.ClassNum < pClassNum)
                {
                    prevNode = curNode;
                    curNode = curNode.NextClass;
                }
                else if (curNode.ClassNum == pClassNum)
                {
                    keepgoing = false;
                }
                else
                {
                    Node classHeader = factory.createClassHeader(pClassNum);
                    classHeader.NextClass = curNode;
                    prevNode.NextClass = classHeader;

                    keepgoing = false;
                }
            }
        }

        public void printAllStudentsOfClass(int pClassNum)
        {
            Node traverseNode = multilistHead;

            bool keepgoing = true;
            while (keepgoing)
            {
                if (traverseNode != null)
                {
                    if (traverseNode.ClassNum < pClassNum)
                    {
                        traverseNode = traverseNode.NextClass;
                    }
                    else if (traverseNode.ClassNum == pClassNum)
                    {
                        traverseNode = traverseNode.NextStudent;
                        while (traverseNode != null)
                        {
                            Console.Write(traverseNode.StudentNum + " ");
                            traverseNode = traverseNode.NextStudent;
                        }
                        keepgoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Class does not exist");
                        keepgoing = false;
                    }
                }
                else
                {
                    Console.WriteLine("Class does not exist");
                    keepgoing = false;
                }
            }
        }

        public void printAllClassesOfStudent(int pStudentNum)
        {
            Node traverseNode = multilistHead;

            bool keepgoing = true;
            while (keepgoing)
            {
                if (traverseNode != null)
                {
                    if (traverseNode.StudentNum < pStudentNum)
                    {
                        traverseNode = traverseNode.NextStudent;
                    }
                    else if (traverseNode.StudentNum == pStudentNum)
                    {
                        traverseNode = traverseNode.NextClass;
                        while (traverseNode != null)
                        {
                            Console.Write(traverseNode.ClassNum + " ");
                            traverseNode = traverseNode.NextClass;
                        }
                        keepgoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Student does not exist");
                        keepgoing = false;
                    }
                }
                else
                {
                    Console.WriteLine("Student does not exist");
                    keepgoing = false;
                }
            }
        }
    }
}
