// See https://aka.ms/new-console-template for more information
System.Random ramdon = new System.Random();
String[] response_posibility = new String[4] { "", "Rock", "Papper", "Scissors" };

var (points_user, points_machine) = (0, 0);
int response_user;

do
{
    Console.WriteLine("Selected a option... \n1. Start game\n2. Score General \n0. Exit");
    Console.Write("Your option: ");
    response_user = Convert.ToInt16(Console.ReadLine());

    switch (response_user)
    {
        case 1:
            int response_machine = Convert.ToInt16(ramdon.Next(1, 4));

            Console.WriteLine("\n¿Are you ready? \nSelected your response...");
            Console.WriteLine("1. Rock\n2. Papper\n3. Scissors\n");
            Console.Write("Your option: ");
            response_user = Convert.ToInt16(Console.ReadLine());
            int flag_win_draw_lose = 0;

            if (response_machine == response_user) {
                Console.WriteLine("¡Draw!");
                flag_win_draw_lose += 3;

            } else if (response_machine == 1 && response_user == 2) {
                Console.WriteLine("¡You Win!");
                flag_win_draw_lose++;
                points_user++;

            } else if (response_machine == 1 && response_user == 3) {
                Console.WriteLine("¡You Lose!");
                flag_win_draw_lose += 2;
                points_machine++;

            } else if (response_machine == 2 && response_user == 1) {
                Console.WriteLine("¡You Lose!");
                flag_win_draw_lose += 2;
                points_machine++;

            } else if (response_machine == 2 && response_user == 3) {
                Console.WriteLine("¡You Win!");
                flag_win_draw_lose++;
                points_user++;

            } else if (response_machine == 3 && response_user == 1) {
                Console.WriteLine("¡You win!");
                flag_win_draw_lose++;
                points_user++;

            } else if (response_machine == 3 && response_user == 2) {
                Console.WriteLine("¡You Lose!");
                flag_win_draw_lose += 2;
                points_machine++;
            } else {
                Console.WriteLine("\nPlease selected other option... Or zero for exit of game.\n");
            }


            switch (flag_win_draw_lose)
            {
                case 1:
                    Console.WriteLine($"{response_posibility[response_user]} prevails {response_posibility[response_machine]}\n");
                    break;

                case 2:
                    Console.WriteLine($"{response_posibility[response_machine]} prevails {response_posibility[response_user]}\n");
                    break;

                case 3:
                    Console.WriteLine($"{response_posibility[response_machine]} is equal to {response_posibility[response_user]} \n");
                    break;
            }
            break;

        case 2:
            Console.WriteLine();
            if (points_machine >= points_user)
            {
                Console.WriteLine($"Machine: {points_machine}");
                Console.WriteLine($"User: {points_user}\n");

            }
            else
            {
                Console.WriteLine($"User: {points_user}");
                Console.WriteLine($"Machine: {points_machine} \n");
            }
            break;

        case 0:
            break;

        default:
            Console.WriteLine("\nPlease selected other option... Or zero for exit of game.\n");
            break;
    }

} while (response_user != 0);