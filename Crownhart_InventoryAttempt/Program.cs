using System;

namespace Crownhart_InventoryAttempt
// Sue Crownhart
// IT112 
// NOTES: This is a hot mess, to put it nicely. Had the lecture on Tuesday happened before
//memorial day weekend, I would have had better questions all week long (except for Thursday since
//you had an appointment). Previous programming classes I have taken only briefly cover arrays
// and then quickly move on because "there's much better stuff to use."
//I would very much like to see how this actually done so I can learn from what
//I did wrong. It does work, much like my first attempt.
// BEHAVIORS NOT IMPLEMENTED AND WHY: I'm not sure if I got the IShippable and Shippable classes working
//together as expected. I wasn't quite sure what to do with the Add()method. Also, I have no idea how to make 
//"press any key to continue" work as intended. Also this doesn't quite fit the naming convention as this was
//my second attempt.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle("Bicycle", 9.50);
            LawnMower mower = new LawnMower("Lawn Mower", 24.00);
            BaseballGlove glove = new BaseballGlove("Baseball Glove", 3.23);
            Crackers crack = new Crackers("Crackers", 0.57);
            IShippable[] stuff = new IShippable[10];
            Shippable moreStuff = new Shippable("Bicycle", bicycle);

            Console.WriteLine("Do you want to add items for shipment? y/n");
            string choice = Console.ReadLine();
            int bcount = 0;     decimal bcost = 0;
            int mcount = 0;     decimal mcost = 0;
            int gcount = 0;     decimal gcost = 0;
            int ccount = 0;     decimal ccost = 0;

            while (choice == "y")
            {
                menuDisplay();
                string choice2 = Console.ReadLine();

                switch (choice2)
                {
                    case "1":
                        moreStuff.ChangeItem(bicycle);
                        AddToCart(bicycle, stuff);
                        moreStuff.Add((decimal)bicycle.ShipCost);
                        bcount +=1;
                        bcost = bcount * moreStuff.Add((decimal)bicycle.ShipCost);
                        Console.WriteLine("1 Bicycle has been added... press enter to continue");
                        break;
                    case "2":
                        moreStuff.ChangeItem(mower);
                        AddToCart(mower, stuff);
                        moreStuff.Add((decimal)mower.ShipCost);
                        mcount += 1;
                        mcost = mcount * moreStuff.Add((decimal)mower.ShipCost);
                        Console.WriteLine("1 Lawn Mower has been added... press enter to continue");
                        break;
                    case "3":
                        moreStuff.ChangeItem(glove);
                        AddToCart(glove, stuff);
                        moreStuff.Add((decimal)glove.ShipCost);
                        gcount += 1;
                        gcost = gcount * moreStuff.Add((decimal)glove.ShipCost);
                        Console.WriteLine("1 Baseball Glove has been added... press enter to continue");
                        break;
                    case "4":
                        moreStuff.ChangeItem(crack);
                        AddToCart(crack, stuff);
                        moreStuff.Add((decimal)crack.ShipCost);
                        ccount += 1;
                        ccost = ccount * moreStuff.Add((decimal)crack.ShipCost);
                        Console.WriteLine("1 Crackers has been added... press enter to continue");
                        break;
                    case "5":
                        Console.WriteLine("Shipment manifest");
                        if (bcount == 1)
                        {
                            Console.WriteLine(bcount + " Bicycle");
                        }
                        else if (bcount > 1)
                        {
                            Console.WriteLine(bcount + " Bicycles");

                        }

                        if (mcount == 1)
                        {
                            Console.WriteLine(mcount + " Lawn Mower");
                        }
                        else if (mcount > 1)
                        {
                            Console.WriteLine(mcount + " Lawn Mowers");

                        }

                        if (gcount == 1)
                        {
                            Console.WriteLine(gcount + " Baseball Glove");
                        }
                        else if (gcount > 1)
                        {
                            Console.WriteLine(gcount + " BaseballGloves");

                        }

                        if (ccount >= 1)
                        {
                            Console.WriteLine(ccount + " Crackers");
                        }
                        ;

                        break;
                    case "6":
                        decimal TotalCost = 0;
                        TotalCost = bcost + mcost + gcost + ccost;
                            
                        Console.WriteLine("Your total for this order is: " + TotalCost.ToString("$0.00"));
                        break;
                    default: Console.WriteLine("Sorry... you're not understood." +
                        "Did you follow directions");
                        break;
                }
            }
        }

        public static void menuDisplay()
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|                  Main Menu                     |");
            Console.WriteLine("|1. Add a Bicycle to the shipment                |");
            Console.WriteLine("|2. Add a Lawn Mower to the Shipment             |");
            Console.WriteLine("|3. Add a Baseball Glove to the shipment         |");
            Console.WriteLine("|4. Add Crackers to the shipment                 |");
            Console.WriteLine("|5. List Shipment Items                          |");
            Console.WriteLine("|6. Compute Shipping Charges                     |");
            Console.WriteLine("|0. Exit                                         |");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");
        }

        public static bool AddToCart(IShippable stuff, IShippable[] list)
        {
            for (int i = 0; i < 10; i++)
            {
                if (list[i] == null)
                {
                    list[i] = stuff;
                    return true;
                }

            }
            return false;
        }

        


    }
}
