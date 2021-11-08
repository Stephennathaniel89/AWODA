using System;
using System.Collections;

namespace OwoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var owoWorker = new OwoTicket();
            double money = owoWorker.OwoDispensingTicket();

            for (int i = 0; i > -1; i++)
            {
                Console.WriteLine("Summary of Sales\n" + money);
                Console.WriteLine(" Oga Share\n" + (money) * 0.65 + "\n Owo worker Share\n" + (money * 0.35));
                owoWorker.TCode();
                money = owoWorker.OwoDispensingTicket();
            }


        }
        public class OwoTicket
        {

            public int ticketTotal = 0;
            public double amountInTotal = 0;
            public Random round = new Random();
            ArrayList ticketId = new ArrayList();

            public double OwoDispensingTicket()
            {

                Console.WriteLine("\n You are Welcome to OwoApp! Enter Ticket Type: Day or Month ");
                string typeOfTicket = Console.ReadLine();
                switch (typeOfTicket)
                {
                    case "Day": amountInTotal = amountInTotal + 1000; break;
                    case "Month": amountInTotal = amountInTotal + 500; break;
                    default: amountInTotal = amountInTotal + 0; break;
                }

                return amountInTotal;

            }
            public void TCode()
            {
                decimal newId = round.Next(100);
                if (ticketTotal > 0)
                {
                    foreach (decimal i in ticketId)
                    {
                        {
                            while (newId == i)
                            { newId = round.Next(100); }
                        }
                    }
                }
                ticketId.Add(newId);
                ticketTotal += 1;
                Console.WriteLine(" Sold Ticket\n" + ticketTotal + "  Code \n");
                for (int i = 0; i < ticketTotal; i++)
                {
                    Console.WriteLine((i + 1) + "   " + ticketId[i]);
                }

            }






        }
    }
}

