using System;
class Menu
{
    static void Main()
    {
        int rotiPrice = 15;
        int paneerPrice = 180;
        int chhashPrice = 30;
		int salaadPrice = 20;
        int rotiQty = 0;
        int paneerQty = 0;
        int chhashQty = 0;
		int salaadQty = 0;
        char yn;

        do
        {
            Console.WriteLine("\n------ HOTEL MENU ------");
            Console.WriteLine("[1] Roti: (15)");
            Console.WriteLine("[2] Paneer Tikka: (180)");
            Console.WriteLine("[3] Chhash: (30)");
			Console.WriteLine("[4] salaad: (20)");
            Console.Write("\nYour Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Roti Quantity: ");
                    rotiQty += int.Parse(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter Paneer Tikka Quantity: ");
                    paneerQty += int.Parse(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Enter Chhash Quantity: ");
                    chhashQty += int.Parse(Console.ReadLine());
                    break;
					
                case 4:
                    Console.Write("Enter salaad Quantity: ");
                    salaadQty += int.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
            Console.Write("Do you want to order more? (y/n): ");
            yn = char.Parse(Console.ReadLine());

        }while(yn == 'y');

        int rotiTotal = rotiQty * rotiPrice;
        int paneerTotal = paneerQty * paneerPrice;
        int chhashTotal = chhashQty * chhashPrice;
        int salaadTotal = salaadQty * salaadPrice;
        int grandTotal = rotiTotal + paneerTotal + chhashTotal + salaadTotal;

        Console.WriteLine("\n--------------- BILL ---------------");
        Console.WriteLine("Item            Qty   Price   Amount");

        if (rotiQty > 0)
            Console.WriteLine("Roti            " + rotiQty + "   *   " + rotiPrice + "   = " + rotiTotal);

        if (paneerQty > 0)
            Console.WriteLine("Paneer Tikka    " + paneerQty + "   *   " + paneerPrice + "  = " + paneerTotal);

        if (chhashQty > 0)
            Console.WriteLine("Chhash          " + chhashQty + "   *   " + chhashPrice + "   = " + chhashTotal);

        if (salaadQty > 0)
            Console.WriteLine("salaad          " + salaadQty + "   *   " + salaadPrice + "   = " + salaadTotal);

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Grand Total:                   " + grandTotal);

        // 10% Discount if bill >= 1000
        if (grandTotal >= 1000)
        {
            int discount = grandTotal * 10 / 100;
            grandTotal -= discount;
            Console.WriteLine("Discount (10%): -" + discount);
            Console.WriteLine("Final Payable Amount: " + grandTotal);
        }
    }
}
