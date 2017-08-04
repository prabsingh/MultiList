using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultilistBuilder multilist = new MultilistBuilder();

            bool keepgoing = true;
            while (keepgoing)
            {
                Console.WriteLine();
                Console.WriteLine("Press 1 to add a student in a class");
                Console.WriteLine("Press 2 to print all students of a class");
                Console.WriteLine("Press 3 to print all classes of a student");
                Console.WriteLine("Press 4 to quit \n");

                string strInput = Console.ReadLine();
                if (strInput == "1")
                {
                    Console.WriteLine("Enter Student Number");

                    string strStudentNum = Console.ReadLine();
                    int intStudentNum;
                    Int32.TryParse(strStudentNum, out intStudentNum);

                    Console.WriteLine("Enter Class Number");

                    string strClassNum = Console.ReadLine();
                    int intClassNum;
                    Int32.TryParse(strClassNum, out intClassNum);

                    Console.WriteLine("Enter Grade");

                    string strGrade = Console.ReadLine();
                    int intGrade;
                    Int32.TryParse(strGrade, out intGrade);

                    multilist.addStudentToClass(intStudentNum, intClassNum, intGrade);
                }
                else if (strInput == "2")
                {
                    Console.WriteLine("Enter Class Number");

                    string strClassNum = Console.ReadLine();
                    int intClassNum;
                    Int32.TryParse(strClassNum, out intClassNum);

                    multilist.printAllStudentsOfClass(intClassNum);
                }
                else if (strInput == "3")
                {
                    Console.WriteLine("Enter Student Number");

                    string strStudentNum = Console.ReadLine();
                    int intStudentNum;
                    Int32.TryParse(strStudentNum, out intStudentNum);

                    multilist.printAllClassesOfStudent(intStudentNum);
                }
                else if (strInput == "4")
                {
                    keepgoing = false;
                }
                else
                {
                    Console.WriteLine("Enter a valid value \n");
                }
            }
        }
    }
}

