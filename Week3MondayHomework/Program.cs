using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3MondayHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling eh = new ExceptionHandling();
            eh.UsingTryCatch();
            Console.Read();
        }
    }

    class ExceptionHandling
    {
        public void UsingTryCatch()
        {
            try
            {
                Console.WriteLine("Select a difficulty, 1 (easy), 2 (medium), 3 (hard) or 4 (expert)!");
                int num = Console.Read();
                switch (num)
                {
                    case 1:
                        Console.WriteLine("You chose easy!");
                        break;
                    case 2:
                        Console.WriteLine("You chose medium!");
                        break;
                    case 3:
                        Console.WriteLine("You chose hard!");
                        break;
                    default:
                        throw new Exception("Sorry, i forgot to take out Expert from this string, please choose another difficulty");
                        
                }
            }
            catch (SwitchException)
            {
                try
                {
                }
                catch (SwitchException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            finally
            {
                Console.WriteLine("Have fun!");
            }
        }
    }
    class SwitchException : ArgumentOutOfRangeException
    {
        public SwitchException()
        {

        }
        public SwitchException(string message) : base(message)
        {

        }
        public SwitchException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
