using System;

namespace EmployeeDirectoryNET20
{
    internal static class Util
    {
        internal static string AskForString(string promt)
        {
            bool success = false;
            string answer;
            do
            {
                Console.WriteLine(promt);
                answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;                    
                
                }


            } while (!success);
           
            return answer;
        }
    }
}