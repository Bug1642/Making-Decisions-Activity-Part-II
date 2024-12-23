using System;
namespace ConsoleAppTest
{
    public class StudentCode
    {
        public bool CheckEverything()
        {
            bool bool1 = true;
            bool isTrue;
            if (bool1 == true)
                isTrue =true;
            else
                isTrue=false;
            return isTrue;
        }
    }
    class Program{
        static void Main(string [] args ){
            StudentCode Checking = new StudentCode();
            Console.WriteLine(Checking.CheckEverything());
        }
    }
}