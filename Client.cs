using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server_Project
{
    internal class Client
    {

        List<long> logN = new List<long>();//list storing for register number
        List<string> namL = new List<string>();//list storing for storing register name

        public void Login()
        {
            logN.Add(93983777);
            namL.Add("vinod");

            Console.Write("enter the num to login :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            logN.Add(number);
            if (logN[0] == logN[1])
            {
                Console.Write("welcome to watsapp..." + namL[0]);
            }
            else
            {
                Console.Write("your num is not registred ,please register");

                Registration();
            }


            Console.WriteLine();
            Console.WriteLine("please enter \"1\"for add cotact,\"2\"for edit,and\"3\" for delete");

            string options = Console.ReadLine();
            Console.WriteLine(options);

            if (options == "1")
            {

                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);

                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact added sucessfully...");

            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");

            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }


        }
        List<long> regN = new List<long>();
        List<string> namR = new List<string>();
        //storing contact details

        List<long> CNU = new List<long>();
        List<string> CNA = new List<string>();

        public void Registration()
        {
            Console.Write("enter the num :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            regN.Add(number);
            Console.Write("enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("your name is.." + name);
            namR.Add(name);
            Console.Write("welcome to watsapp..." + namR[0]);
            Console.WriteLine("please enter \"1\"for add,\"2\"for edit,and\"3\" for delete");
            string options = Console.ReadLine();
            Console.WriteLine(options);

            if (options == "1")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                CNU.Add(phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact added sucessfully...");

            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");

            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }



        }
    }
}
