using System.ComponentModel.Design;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main()
        {
            FileManager fileManager = new FileManager();
            
            string filename = "grades.txt";
            string menu;
            do
            {
                Console.WriteLine("1. Edit File");
                Console.WriteLine("2. Read File");
                Console.WriteLine("3. Exit System");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    fileManager.Write(filename);
                   
                }
                else if (menu == "2")
                {
                    fileManager.Read(filename);

                }
                else if (menu == "3")
                {

                }


            } while (menu != "3");
            
        }
    }
}







