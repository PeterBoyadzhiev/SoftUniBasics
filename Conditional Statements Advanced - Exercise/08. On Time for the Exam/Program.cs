using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int sumExamInMinutes = hourExam * 60 + minuteExam;
            int sumArriveInMinutes = hourArrive * 60 + minuteArrive;

            if (sumArriveInMinutes > sumExamInMinutes && sumArriveInMinutes - sumExamInMinutes <= 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{sumArriveInMinutes - sumExamInMinutes} minutes after the start");
            }
            else if (sumArriveInMinutes > sumExamInMinutes && sumArriveInMinutes - sumExamInMinutes > 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{(sumArriveInMinutes - sumExamInMinutes) / 60}:{(sumArriveInMinutes - sumExamInMinutes) % 60:d2} hours after the start");
            }
            else if (sumArriveInMinutes == sumExamInMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (sumExamInMinutes > sumArriveInMinutes && sumExamInMinutes - sumArriveInMinutes <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{sumExamInMinutes - sumArriveInMinutes} minutes before the start");
            }
            else if (sumExamInMinutes > sumArriveInMinutes && sumExamInMinutes - sumArriveInMinutes <= 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{sumExamInMinutes - sumArriveInMinutes} minutes before the start");
            }
            else if (sumExamInMinutes > sumArriveInMinutes && sumExamInMinutes - sumArriveInMinutes > 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{(sumExamInMinutes - sumArriveInMinutes) / 60}:{(sumExamInMinutes - sumArriveInMinutes) % 60:d2} hours before the start");
            }
        }
    }
}
