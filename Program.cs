using System;
using System.Diagnostics;
using System.Threading;


namespace ZufallsZahl_LA_1200_Lehner
{
    class Program
    {
        static void Main(string[] args)
        {






            Console.ForegroundColor = ConsoleColor.Green;
            Random rand = new Random();
            int RandomNumber = rand.Next(1, 101);


            string Logo1 = @"
  _____               _____       _      _                         _ _        ______     _     _ 
 |  __ \             / ____|     (_)    | |                       | (_)      |___  /    | |   | |
 | |  | | __ _ ___  | (___  _ __  _  ___| |  _   _ _ __ ___     __| |_  ___     / / __ _| |__ | |
 | |  | |/ _` / __|  \___ \| '_ \| |/ _ \ | | | | | '_ ` _ \   / _` | |/ _ \   / / / _` | '_ \| |
 | |__| | (_| \__ \  ____) | |_) | |  __/ | | |_| | | | | | | | (_| | |  __/  / /_| (_| | | | | |
 |_____/ \__,_|___/ |_____/| .__/|_|\___|_|  \__,_|_| |_| |_|  \__,_|_|\___| /_____\__,_|_| |_|_|
                           | |                                                                   
                           |_|                                                                   
            ";

            Console.WriteLine(Logo1);
            Console.WriteLine("Das Spiel beginnt, es wurde eine Zahl zwischen 1 & 100 erstellt. ");
            Console.WriteLine("Schaffen Sie es die Zahl zu erraten?");


            int AttemptCounter = 0;
            int UserGuess = 5;
            Stopwatch stopWatch = new Stopwatch();
            bool UserGuessTest;


            //---------------------------------------------------------------------------------------------

            do
            {
                Console.Write("Eingabe Zahl zwischen 1-100: ");

                try
                {
                    UserGuess = Convert.ToInt32(Console.ReadLine());
                    if (UserGuess < 1 || UserGuess > 100)
                    {
                        throw new Exception();
                    }

                    AttemptCounter = 0;
                    AttemptCounter = AttemptCounter + 1;
                    stopWatch.Start();
                    UserGuessTest = true;

                }
                catch
                {
                    Console.WriteLine("Ihre Eingabe ist ungültig.");
                    Console.WriteLine("-------------------------------");
                    Console.Write("Eingabe Zahl zwischen 1-100: ");
                    UserGuessTest = false;

                }
            } while (!UserGuessTest);


            //------------------------------------------------------------------------------------------------



            while (UserGuess != RandomNumber)
            {
                try
                {

                    if (RandomNumber > UserGuess && (UserGuess > 0 && UserGuess < 101))
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Sie denken zu klein, versuchen Sie es nochmal.");
                        Console.Write("Eingabe Zahl zwischen 1-100: ");
                        UserGuess = Convert.ToInt32(Console.ReadLine());
                        AttemptCounter++;
                    }
                    else
                    {
                        if (RandomNumber < UserGuess && (UserGuess > 0 && UserGuess < 101))
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Sie denke zu gross, versuchen Sie es nochmal.");
                            Console.Write("Eingabe Zahl zwischen 1-100: ");
                            UserGuess = Convert.ToInt32(Console.ReadLine());
                            AttemptCounter++;
                        }
                        else
                        {
                            if (RandomNumber == AttemptCounter)
                            {

                            }
                            else
                            {
                                AttemptCounter--;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Ihre Eingabe ist ungültig.");
                                Console.Write("Bitte geben Sie eine Natrüliche Zahl zwischen 1-100 ein: ");
                                UserGuess = Convert.ToInt32(Console.ReadLine());
                                AttemptCounter++;
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Ihre Eingabe ist ungültig.");
                    Console.Write("Bitte geben Sie eine Natrüliche Zahl zwischen 1-100 ein: ");
                    UserGuess = Convert.ToInt32(Console.ReadLine());
                    AttemptCounter++;
                }
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Herzlichen Glückwunsch Sie haben die Zahl richtig geraten.");
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("Anzahl Ihrer Versuche: " + AttemptCounter);
            Console.WriteLine("Zeit die Sie gebraucht haben: " + elapsedTime);


            Console.Write("Wollen Sie noch eine Runde spielen?(ja/nein) ");
            string round = Console.ReadLine();









            //-----------------------------------------------------------------------------------------------









            while (round == "ja")
            {
                Console.Clear();
                RandomNumber = rand.Next(1, 101);
                Console.WriteLine("-------------------------------");
                Console.Write("Eingabe Zahl zwischen 1-100: ");
                do
                {
                    try
                    {
                        UserGuess = Convert.ToInt32(Console.ReadLine());
                        if (UserGuess < 1 || UserGuess > 100)
                        {
                            throw new Exception();
                        }
                        AttemptCounter = 0;
                        AttemptCounter = AttemptCounter + 1;
                        stopWatch.Start();
                        UserGuessTest = true;

                    }
                    catch
                    {
                        Console.WriteLine("Ihre Eingabe ist ungültig.");
                        Console.WriteLine("-------------------------------");
                        Console.Write("Eingabe Zahl zwischen 1-100: ");
                        UserGuessTest = false;

                    }
                } while (!UserGuessTest);


                while (UserGuess != RandomNumber)
                {
                    try
                    {

                        if (RandomNumber > UserGuess && (UserGuess > 0 && UserGuess < 101))
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Sie denken zu klein, versuchen Sie es nochmal.");
                            Console.Write("Eingabe Zahl zwischen 1-100: ");
                            UserGuess = Convert.ToInt32(Console.ReadLine());
                            AttemptCounter++;
                        }
                        else
                        {
                            if (RandomNumber < UserGuess && (UserGuess > 0 && UserGuess < 101))
                            {
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Sie denke zu gross, versuchen Sie es nochmal.");
                                Console.Write("Eingabe Zahl zwischen 1-100: ");
                                UserGuess = Convert.ToInt32(Console.ReadLine());
                                AttemptCounter++;
                            }
                            else
                            {
                                if (RandomNumber == AttemptCounter)
                                {

                                }
                                else
                                {
                                    Console.WriteLine("----------------------------------------------");
                                    Console.WriteLine("Ihre Eingabe ist ungültig.");
                                    Console.Write("Bitte geben Sie eine Natrüliche Zahl zwischen 1-100 ein: ");
                                    UserGuess = Convert.ToInt32(Console.ReadLine());
                                    AttemptCounter++;
                                }
                            }
                        }
                    }
                    catch
                    {
                        AttemptCounter--;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Ihre Eingabe ist ungültig.");
                        Console.Write("Bitte geben Sie eine Natrüliche Zahl zwischen 1-100 ein: ");
                        UserGuess = Convert.ToInt32(Console.ReadLine());
                        AttemptCounter++;
                    }
                }

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Herzlichen Glückwunsch Sie haben die Zahl richtig geraten.");
                stopWatch.Stop();

                ts = stopWatch.Elapsed;
                elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine("Anzahl Ihrer Versuche: " + AttemptCounter);
                Console.WriteLine("Zeit die Sie gebraucht haben: " + elapsedTime);
                Console.Write("Wollen Sie noch eine Runde spielen?(ja/nein) ");
                round = Console.ReadLine();
                if (round == "ja")
                {
                    RandomNumber = rand.Next(1, 101);
                }

            }
        }
    }
}

