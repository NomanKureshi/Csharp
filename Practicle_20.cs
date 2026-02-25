using System;

class Continue_with_case
{
    static void Main()
    {
		int num;
        do
		{
            Console.WriteLine("\nEnter a number between 1-7 for following selection :-\n");
            Console.WriteLine("Enter [1] for Monday");
            Console.WriteLine("Enter [2] for Tuesday");
            Console.WriteLine("Enter [3] for Wednesday");
            Console.WriteLine("Enter [4] for Thursday");
            Console.WriteLine("Enter [5] for Friday");
            Console.WriteLine("Enter [6] for Saturday");
            Console.WriteLine("Enter [7] for Sunday");
            Console.WriteLine("Enter [0] to Exit\n");

            Console.Write("Enter Your Number :- ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday - Working Day");
                    break;

                case 2:
                    Console.WriteLine("Tuesday - Working Day");
                    break;

                case 3:
                    Console.WriteLine("Wednesday - Working Day");
                    break;

                case 4:
                    Console.WriteLine("Thursday - Working Day");
                    break;

                case 5:
                    Console.WriteLine("Friday - Working Day");
                    break;

                case 6:
                    Console.WriteLine("Saturday - Working Day");
                    break;

                case 7:
                    // continue jumps to next loop iteration
                    continue;
				case 0:
                    Console.WriteLine("Exit");
					break;
					
                default:
                    Console.WriteLine("Please choose number between 1-7");
                    break;
            }
        }while(num != 0);
    }
}
