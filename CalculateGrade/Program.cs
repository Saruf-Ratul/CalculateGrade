using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your marks: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = GetGpa(number)
            Console.WriteLine(result);
            Console.ReadKey();


        }
        static string GetGpa(int number) 
        {
            string result;
            if ((marksObtained >= 90) && (marksObtained <= 100))
            {
                result = "You have got A+ Grade";
            }
            else if ((marksObtained >= 80) && (marksObtained <= 89))
            {
                result = "You have got A Grade";
            }
            else if ((marksObtained >= 70) && (marksObtained < 79))
            {
                result = "You have got B+ Grade";
            }
            else if ((marksObtained >= 60) && (marksObtained < 69))
            {
                result = "You have got B Grade";
            }
            else if ((marksObtained >= 50) && (marksObtained < 59))
            {
                result = "You have got C Grade";
            }
            else if ((marksObtained >= 0) && (marksObtained < 49))
            {
                result = "You have got F Grade";
            }

            if ((marksObtained < 0) || (marksObtained > 100))
            {
                result = "Invalid Number";
            }

            return result;

        }

    }
}
