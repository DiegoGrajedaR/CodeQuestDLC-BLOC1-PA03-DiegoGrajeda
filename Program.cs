using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    public static void Main()
    {
        //English syntax made with the translator

        //GENERAL variables and constants
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

        //Variables and constants created for CHAPTER 1
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


        //Variables and constants created for CHAPTER 2
        const string Ch2Title = "===== Chapter 2: Increase LVL ⚔️ =====";
        const string Ch2MaxLevelMsg = "You have already reached the maximum level, but you can continue battling monsters.";
        const string Ch2NotMaxLevelMsg = "You haven't reached the maximum level yet, keep defeating monsters.";
        const string Ch2MonsterAppearsMsg = "A {0} appears! Rolling dice to determine the outcome of the battle...";
        const string Ch2MonsterHpMsg = "The {0} has {1} HP.";
        const string Ch2DiceNum = "You rolled a {0}";
        const string Ch2PressKeyToRollDice = "Press any key to roll the dice...";
        const string Ch2HitMonster = "The monster takes damage!";
        const string Ch2MonsterDefeated = "Monster defeated!";
        const int Ch2MaxWizardLevel = 5;

        string monsterAppears = "";
        string monsterActualHp = "";
        string rollDice = "";

        int diceNum = 0;
        int monsterNameHpOption = 0;
        int monsterMaxHp = 0;
        bool defeatedMonster = false;
        string[] monstersArray = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Iron Golem 🤖", "Giant Spider 🕷️", "Lost Necromancer 🧝‍♂️", "Ancient Dragon 🐉" };
        int[] hpMonstersArray = {3, 5, 10, 11, 15, 18, 20, 50};
        string[] diceArray = {   "            ________\n" +
                                 "           /       /|\n" +
                                 "          /_______/ |\n" +
                                 "          |       | |\n" +
                                 "          |   o   | /\n" +
                                 "          |       |/\n" +
                                 "          '-------'\n",

                                 "            ________\n" +
                                 "           /       /|\n" +
                                 "          /_______/ |\n" +
                                 "          | o     | |\n" +
                                 "          |       | /\n" +
                                 "          |     o |/\n" +
                                 "          '-------'\n",

                                 "            ________\n" +
                                 "           /       /|\n" +
                                 "          /_______/ |\n" +
                                 "          | o     | |\n" +
                                 "          |   o   | /\n" +
                                 "          |     o |/\n" +
                                 "          '-------'\n",

                                 "            ________\n" +
                                 "           /       /|\n" +
                                 "          /_______/ |\n" +
                                 "          | o   o | |\n" +
                                 "          |       | /\n" +
                                 "          | o   o |/\n" +
                                 "          '-------'\n",

                                 "            ________\n" +
                                 "           /       /|\n" +
                                 "          /_______/ |\n" +
                                 "          | o   o | |\n" +
                                 "          |   o   | /\n" +
                                 "          | o   o |/\n" +
                                 "          '-------'\n",

                                 "            ________\n" +
                                 "           /       /|\n" +
                                 "          /_______/ |\n" +
                                 "          | o   o | |\n" +
                                 "          | o   o | /\n" +
                                 "          | o   o |/\n" +
                                 "          '-------'\n" };

        //This command will make the emotes/emojis visible
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

                                //Iteration that will be repeated 5 times and in each iteration the power achieved in a day will be added to the total
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

                                //Conditional that depending on the total power will give you a certain message
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
                        defeatedMonster = false;
                        Console.WriteLine(Ch2Title);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(wizardLevel == 5 ? Ch2MaxLevelMsg : Ch2NotMaxLevelMsg);
                        Console.ResetColor();

                        monsterNameHpOption = random.Next(0, 8);
                        monsterMaxHp = hpMonstersArray[monsterNameHpOption];

                        monsterAppears = string.Format(Ch2MonsterAppearsMsg, monstersArray[monsterNameHpOption]);
                        monsterActualHp = string.Format(Ch2MonsterHpMsg, monstersArray[monsterNameHpOption], monsterMaxHp);
                        rollDice = string.Format(Ch2DiceNum, diceNum+1);

                        Console.WriteLine($"{monsterAppears} \n{monsterActualHp}");

                        while (!defeatedMonster)
                        {
                            diceNum = random.Next(0, 6);
                            monsterMaxHp -= diceNum + 1;
                            rollDice = string.Format(Ch2DiceNum, diceNum + 1);
                            monsterActualHp = string.Format(Ch2MonsterHpMsg, monstersArray[monsterNameHpOption], monsterMaxHp);

                            Console.WriteLine(Ch2PressKeyToRollDice);
                            Console.ReadKey();
                            Console.WriteLine($"{rollDice} \n {diceArray[diceNum]}" + LineBreak);

                            if (monsterMaxHp <= 0)
                            {
                                Console.WriteLine($"{Ch2HitMonster} \nThe {monstersArray[monsterNameHpOption]} has 0 HP.");
                                Console.WriteLine(Ch2MonsterDefeated);
                                defeatedMonster = true;
                                wizardLevel++;

                                if (wizardLevel > Ch2MaxWizardLevel)
                                {
                                    welcomeWizard = $"===== Welcome, {wizardName} the {wizardRange} with level {Ch2MaxWizardLevel} =====";
                                }
                                else if (wizardName.Equals("")) 
                                {
                                    welcomeWizard = "";
                                }
                                else
                                {
                                    welcomeWizard = $"===== Welcome, {wizardName} the {wizardRange} with level {wizardLevel} =====";
                                }
                            }
                            else 
                            {
                                Console.WriteLine($"{Ch2HitMonster} \n{monsterActualHp}");
                            }
                        }

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