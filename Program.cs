using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    public static void Main()
    {
        //Sintaxi en anglès feta amb el traductor

        //Variables i constants GENERALS
        const string MenuTitle = "===== MAIN MENU - CODEQUEST🧙‍♂️ =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Increse LVL";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancient Scroll";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 7.";
        const string LineBreak = " ";

        int op = 0;
        bool validInput;
        int wizardLevel = 1;

        Random random = new Random();

        //Variables i constants creades per al CHAPTER 1
        const string Ch1Title = "===== Chapter 1: Train Wizard 🪄 =====";
        const string Ch1StartTrainingMsg = "Let's start the trining";
        const string Ch1DayTrainingMsg = "Day {0} --> {1}, you have now meditated for {2} hours and your power is now {3} points!";
        const string Ch1ErrorMsg = "Error: Name cannot be empty.";
        const string Ch1InputName = "Enter your name, wizard:";
        const string Ch1RangeRaoden = "You repeat at the second call. \n{0} your wizard range is Raoden the Elantrian with a total power of {1}!";
        const string Ch1RangeZyn = "You still confuse the wand with a spoon. \n{0} your wizard range is Zyn the Buggued with a total power of {1}!";
        const string Ch1RangeArka = "You are a Summoner of Magical Breezes. \n{0} your wizard range is Arka Nullpointer with a total power of {1}!";
        const string Ch1RangeElarion = "Wow! You can summon dragons without burning down the lab! \n{1} your wizard range is Elarion of the Embers with a total power of {1}!";
        const string Ch1RangeITB = "You have achieved the rank of Master of the Arcane!. \n{0} your wizard range is ITB-Wizard the Grey with a total power of {1}!";


        string wizardName = "";
        string welcomeWizard = "";
        string wizardRange = "";
        string dayTrainMsg = "";
        string rangeMsg = "";
        int dayPower = 0;
        int totalPower = 0;
        int daymeditionHours = 0;
        int day = 1;


        //Aquesta comanda farà que es poguin veure el emotes/emojis
        Console.OutputEncoding = Encoding.UTF8;

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(MenuTitle);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(welcomeWizard);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOption7);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);
            Console.ResetColor();

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

                if (op < 0 || op > 7)
                {
                    Console.WriteLine(InputErrorMessage);
                    validInput = false;

                }

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
                op = -1;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine($"Option selected: {op}");
                switch (op)
                {
                    //FUNCIONALITAT CHAPTER 1
                    case 1:
                        Console.WriteLine(Ch1Title);

                        try
                        {
                            Console.WriteLine(Ch1InputName);
                            wizardName = Console.ReadLine();

                            if (wizardName.Equals(""))
                            {
                                Console.WriteLine(Ch1ErrorMsg);
                            }
                            else
                            {
                                wizardLevel = 1;
                                totalPower = 0;
                                day = 1;
                                wizardName = char.ToUpper(wizardName[0]) + wizardName.Substring(1).ToLower();

                                Console.WriteLine(Ch1StartTrainingMsg);

                                //Iteració que es repetirà 5 cops i en cada iteració el poder aconseguit en un dia es sumarà al total
                                for (int i = 1; i <= 5; i++)
                                {
                                    daymeditionHours = random.Next(1, 24);
                                    dayPower = random.Next(1, 11);
                                    totalPower += dayPower;

                                    dayTrainMsg = string.Format(Ch1DayTrainingMsg, day, wizardName, daymeditionHours, totalPower);
                                    Console.WriteLine(dayTrainMsg);
                                    Thread.Sleep(1000);
                                    day++;
                                }

                                //Condicional que depenent del poder total et donarà cert missatge
                                if (totalPower < 20)
                                {
                                    rangeMsg = string.Format(Ch1RangeRaoden, wizardName, totalPower);
                                    wizardRange = "Raoden the Elantrian";
                                }
                                else if (totalPower >= 20 && totalPower < 30)
                                {
                                    rangeMsg = string.Format(Ch1RangeZyn, wizardName, totalPower);
                                    wizardRange = "Zyn the Buggued";
                                }
                                else if (totalPower >= 30 && totalPower < 35)
                                {
                                    rangeMsg = string.Format(Ch1RangeArka, wizardName, totalPower);
                                    wizardRange = "Arka Nullpointer";
                                }
                                else if (totalPower >= 35 && totalPower < 40)
                                {
                                    rangeMsg = string.Format(Ch1RangeElarion, wizardName, totalPower);
                                    wizardRange = "Elarion of the Embers";
                                }
                                else
                                {
                                    rangeMsg = string.Format(Ch1RangeITB, wizardName, totalPower);
                                    wizardRange = "ITB-Wizard the Grey";
                                }

                                Console.WriteLine(rangeMsg);
                                Console.WriteLine(LineBreak);
                                welcomeWizard = $"===== Welcome, {wizardName} the {wizardRange} with level {wizardLevel} =====";
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected Error." + ex);
                        }
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 0:
                        Console.WriteLine("Exiting game...");
                        break;
                }
            }
        } while (op != 0);
    }
}