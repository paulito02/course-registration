using System;

namespace Mark
{
    class Program
    {
        static void Main(string[] args)
        {
             string course;
            string input;
                
           Console.WriteLine("identify if you are a  Fulltime student or Part-time student:");
             input = Console.ReadLine();
             if (input.Substring(0,4).ToLower().Contains("full"))
          {
           Console.WriteLine("what is your course of study in fulltime:");
           course = Console.ReadLine();
           Console.WriteLine(course+" it's a good course.");
          }

              if (input.Substring(0,4).ToLower().Contains("part"))
               {
              Console.WriteLine("How many credit are you taking ?");
              int partTimeCredit = Convert.ToInt32(Console.ReadLine());
              if (partTimeCredit > 6)
               {
                 Console.WriteLine("Too much unit for a part-time student.");
               }
                 else
               {
                 Console.WriteLine("proceed to the screen");
               }
        }   
        }
    }
}
