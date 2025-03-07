namespace Project
{
    internal class Program
    {
        private static int enterPass;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this Game I made!");
            int password = 1234;
            string[] menu = new string[] { "[1] New Game", "[2] View Previous Progress", "[3] Scores", "[4] Exit" };
            //while(enterPass != password){
            Console.Write("Enter Password: ");
            int enterPass = Convert.ToInt16(Console.ReadLine());

            if (enterPass == password)
            {
                Console.WriteLine("Entry successful");
                Console.WriteLine("Main Menu");
                foreach (var Mainmenu in menu)
                {
                    Console.WriteLine(Mainmenu);
                }

                    Console.Write("Enter Action: ");
                    int select = Convert.ToInt16(Console.ReadLine());

                switch (select)
                {
                    case 1:

                        break;
                    case 2:
                        String prog1 = "Scene 1";
                        String prog2 = "Scene 5";
                        String prog3 = "Scene 4";
                        String prog4 = "Scene 1";

                        Console.WriteLine(prog1);
                        Console.WriteLine(prog2);
                        Console.WriteLine(prog3);
                        Console.WriteLine(prog4);

                        break;
                    case 3:
                        String progg1 = "10500";
                        String progg2 = "40030";
                        String progg3 = "35003";
                        String progg4 = "9000";

                        Console.WriteLine(progg1);
                        Console.WriteLine(progg2);
                        Console.WriteLine(progg3);
                        Console.WriteLine(progg4);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect Password. Try again.");
            }
            //}
        }
    }
}
