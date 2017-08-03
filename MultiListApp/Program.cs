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
            Multilist multilist = new Multilist();

            bool keepgoing = true;
            while(keepgoing)
            {
                Console.WriteLine("enter 1 to add a student in a class");
                Console.WriteLine("enter 2 to print all classes of a student");
                Console.WriteLine("enter 3 to print all students of a class");
                Console.WriteLine("enter 4 to quit \n");

                string valueEntered = Console.ReadLine();
                if(valueEntered == "1")
                {
                    Console.WriteLine("Enter Student Number\n");
                    string strStudentNum = Console.ReadLine();
                    int intStudentNum;
                    Int32.TryParse(strStudentNum, out intStudentNum);

                    Console.WriteLine("Enter Class Number \n");
                    string strClassNum = Console.ReadLine();
                    int intClassNum;
                    Int32.TryParse(strClassNum, out intClassNum);

                    Console.WriteLine("Enter Grade \n");
                    string strGrade = Console.ReadLine();
                    int intGrade;
                    Int32.TryParse(strGrade, out intGrade);

                    multilist.addStudentToClass(intStudentNum, intClassNum, intGrade);
                }
                else if(valueEntered == "2")
                {
                    Console.WriteLine("Enter Student Number \n");
                    string strStudentNum = Console.ReadLine();
                    int intStudentNum;
                    Int32.TryParse(strStudentNum, out intStudentNum);

                    multilist.displayAllClassesOfStudent(intStudentNum);
                }
                else if (valueEntered == "3")
                {
                    Console.WriteLine("Enter Class Number \n");
                    string strClassNum = Console.ReadLine();
                    int intClassNum;
                    Int32.TryParse(strClassNum, out intClassNum);

                    multilist.displayAllStudentsOfClass(intClassNum);
                }
                else if (valueEntered == "4")
                {
                    keepgoing = false;
                }
                else
                {
                    Console.WriteLine("Enter a valid input  \n");
                }
            }
        }
    }
}
