
using System;
using System.IO;

namespace Countries
{
    class Program
    {

        readonly string[] northAfrican = { "Algeria", "Egypt", "Libya", "Morocco", "South Sudan", "Sudan", "Tunisia", "Western Sahara" };

        readonly string[] eastAfrican = {"Burundi", "Comoros", "Djibouti", "Eritrea", "Ethiopia", "Kenya", "Madagascar",
                                "Malawi","Mauritius", "Mayotte", "Mozambique", "Reunion", "Rwanda", "Seychelles", "Somalia",
                                "Tanzania","Uganda", "Zambia", "Zimbabwe"};

        readonly string[] westAfrican = { "Benin", "Burkina Faso", "Cape Verde", "Cote d'Ivoire (Ivory Coast)", "Gambia", "Ghana",
                                 "Guinea", "Guinea-Bissau", "Liberia", "Mali", "Mauritania", "Niger", "Nigeria", "Saint Helena",
                                 "Senegal", "Sierra Leone",  "Togo"};

        readonly string[] centralAfrican = { "Angola", "Cameroon", "Central African Republic", "Chad", "Congo",
                                    "Democratic Republic of the Congo", "Equatorial Guinea", "Gabon","Sao Tome and Principe"};

        readonly string[] southAfrican = { "Botswana", "Lesotho", "Namibia", "South Africa", "Swaziland" };

        readonly string[] interestingFacts = {"Algeria is the largest African country and the tenth-largest country in the world. " +
                                    "\nThis country measures 919,595 square miles (2,381,741 square kilometers).",
                                    "The 115-island country of Seychelles, located in the Indian Ocean, is the smallest African country. " +
                                    "\nThis country measures 176 square miles (455 square kilometers).",
                                    "Mount Kilimanjaro in Tanzania is the highest point in Africa. \nIt is 19,336 feet (5,894 meters) high. " +
                                    "\nThe lowest point is Lake Asal in Djibouti it is 502 feet (153 meters) below sea level.",
                                    "Egypt is home to the world's first great civilization.",
                                    "Ethiopia is Africa's oldest independent country.",
                                    "Approximately ninety percent of Algeria is desert.",
                                    "The Libyan desert is one of the most arid places in the world. This desert covers most of Libya.",
                                    "Sudan was once the largest country in Africa (measured by total area), " +
                                    "\nhowever when it split into Sudan and South Sudan in 2011 it became the third largest country in Africa. " +
                                    "Algeria and the Democratic Republic of the Congo are now larger.",
                                    "Tunisia is the northern most country on the African continent.",
                                    "The African country Western Sahara has a very small population and is mostly desert flatlands.",
                                    "The country of Madagascar is the fourth largest island in the world.",
                                    "In the 1950s African countries began to gain their independence from control by the Major European powers. " +
                                    "\nIn 1951 Libya gained independence from Italy; " +
                                    "\nin 1956 both Tunisia and Morocco broke away from France; followed by Ghana in 1957. " +
                                    "\nThis became possible due to the weakened state of the major European powers after World War 2.",
                                    "South Africa has become the African continents richest economy due to the abundance of mineral deposits found there. " +
                                    "\nAlong with such minerals as gold and platinum, diamonds are also mined there.",
                                    "For decades a horrible civil war raged in Sudan which, in 2011, resulted in South Sudan gaining its independence. " +
                                    "\nApproximately two and a half million people lost their lives during this conflict.",
                                };

        readonly string[] allCountries = {"Algeria", "Egypt", "Libya", "Morocco", "South Sudan", "Sudan", "Tunisia", "Western Sahara",
                                "Burundi", "Comoros", "Djibouti", "Eritrea", "Ethiopia", "Kenya", "Madagascar",
                                "Malawi","Mauritius", "Mayotte", "Mozambique", "Reunion", "Rwanda", "Seychelles", "Somalia",
                                "Tanzania","Uganda", "Zambia", "Zimbabwe",
                                "Benin", "Burkina Faso", "Cape Verde", "Cote d'Ivoire (Ivory Coast)", "Gambia", "Ghana",
                                 "Guinea", "Guinea-Bissau", "Liberia", "Mali", "Mauritania", "Niger", "Nigeria", "Saint Helena",
                                 "Senegal", "Sierra Leone",  "Togo",
                                 "Angola", "Cameroon", "Central African Republic", "Chad", "Congo",
                                 "Democratic Republic of the Congo", "Equatorial Guinea", "Gabon","Sao Tome and Principe",
                                 "Botswana", "Lesotho", "Namibia", "South Africa", "Swaziland"};



        public static void Main(string[] args)
        {
            Program p = new Program();
            p.DisplayMenu();


        }


        public void DisplayMenu()
        {
            try
            {
                MethodLibrary ml = new MethodLibrary();

                int det;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Welcome to the African countries game Main page");
                Console.WriteLine("========================================================\n");
                Console.WriteLine("Enter the associated number to choose an option\n");
                Console.WriteLine("1. Play African countries game");
                Console.WriteLine("2. Randomized Fact page");
                Console.WriteLine("3. Learn the countries");

                ml.PrintColor(ConsoleColor.DarkCyan, "4. Play Countries of the world");
                ml.PrintColor(ConsoleColor.DarkCyan, "5. Check Highest score");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("6. About us");
                Console.WriteLine("7. Quit");

                det = Convert.ToInt32(Console.ReadLine());

                if (det > 7 || det == 0)
                {
                    ml.IfState(7);
                    DisplayMenu();
                }

                switch (det)
                {
                    case 1:
                        AfConGame();
                        break;
                    case 2:
                        RanFctPg();
                        break;
                    case 3:
                        PracticeCountries();
                        break;
                    case 4:
                        ml.proVersionMessage();
                        DisplayMenu();
                        break;
                    case 5:
                        ml.proVersionMessage();
                        DisplayMenu();
                        break;
                    case 6:
                        AboutUs();
                        break;
                    case 7:
                        ml.Exit();
                        break;

                }
            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchFormat();
                DisplayMenu();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchAll();
                DisplayMenu();
            }


        }  // Displays the main menu

        public void AfConGame()
        {

            try
            {
                MethodLibrary ml = new MethodLibrary();

                int det;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                //PrintColor(ConsoleColor.Magenta,"Welcome to the African countries game",resetFcolor:true,
                //returnFcolor:ConsoleColor.Cyan);

                Console.WriteLine("Welcome to the African countries game");
                Console.WriteLine("=============================================\n");
                Console.WriteLine("Enter the associated number to choose an option\n");
                Console.WriteLine("1. Play all African countries");
                Console.WriteLine("2. Play all North African countries");
                Console.WriteLine("3. Play all East African countries");
                Console.WriteLine("4. Play all West African countries");
                Console.WriteLine("5. Play all South African countries");
                Console.WriteLine("6. Play all Central African countries");
                Console.WriteLine("7. Return to Menu");

                det = Convert.ToInt32(Console.ReadLine());

                if (det > 7 || det == 0)
                {
                    ml.IfState(7);
                    DisplayMenu();
                }

                switch (det)
                {
                    case 1:
                        AfricanCon();
                        break;
                    case 2:
                        NorthAfricanCon();
                        break;
                    case 3:
                        EastAfricanCon();
                        break;
                    case 4:
                        WestAfricanCon();
                        break;
                    case 5:
                        SouthAfricanCon();
                        break;
                    case 6:
                        CentralAfricanCon();
                        break;
                    case 7:
                        DisplayMenu();
                        break;



                }
            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchFormat();
                AfConGame();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchAll();
                AfConGame();
            }

        }   // starts the african countries game menu

        public void RanFctPg()
        {
            try
            {
                MethodLibrary ml = new MethodLibrary();
                int det;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Welcome to the Random Facts page");
                Console.WriteLine("=========================================\n");
                Console.WriteLine("Enter the associated number to choose an option\n");
                Console.WriteLine("1. Give me an African fact");
                Console.WriteLine("2. Return to Main page");
                Console.WriteLine("3. Quit");

                det = Convert.ToInt32(Console.ReadLine());

                if (det > 3 || det == 0)
                {
                    ml.IfState(3);
                    RanFctPg();
                }

                switch (det)
                {
                    case 1:
                        AfFactGame();
                        break;
                    case 2:
                        DisplayMenu();
                        break;
                    case 3:
                        ml.Exit();
                        break;

                }
            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchFormat();
                RanFctPg();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchAll();
                RanFctPg();
            }

        }   // opens the random facts menu

        public void AboutUs()
        {
            try
            {

                Console.Clear();
                Console.WriteLine("\n\n This Console Application was Developed by Emmanuel Oluyale \n");
                Console.WriteLine(" An initiative of Mr Moshood \n");
                Console.WriteLine(" NIIT.\n\n");
                Console.WriteLine(" Press any key to return to main page");
                Console.ReadKey();
                DisplayMenu();

            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchFormat();
                AboutUs();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchAll();
                AboutUs();
            }



        }   // opens the about us page

        public void AfricanCon()
        {
            CountriesGamer afri = new CountriesGamer();

            afri.Arrayer = allCountries;
            afri.namer = "Africa";
            afri.PlayGame();

        }   // opens the all African countries game

        public void NorthAfricanCon()
        {
            CountriesGamer afri = new CountriesGamer();

            afri.Arrayer = northAfrican;
            afri.namer = "North Africa";
            afri.PlayGame();

        }

        public void EastAfricanCon()
        {
            CountriesGamer afri = new CountriesGamer();

            afri.Arrayer = eastAfrican;
            afri.namer = "East Africa";
            afri.PlayGame();

        }

        public void WestAfricanCon()
        {
            CountriesGamer afri = new CountriesGamer();

            afri.Arrayer = westAfrican;
            afri.namer = "West Africa";
            afri.PlayGame();

        }

        public void CentralAfricanCon()
        {
            CountriesGamer afri = new CountriesGamer();

            afri.Arrayer = centralAfrican;
            afri.namer = "Central Africa";
            afri.PlayGame();


        }

        public void SouthAfricanCon()
        {

            CountriesGamer afri = new CountriesGamer();

            afri.Arrayer = southAfrican;
            afri.namer = "South Africa";
            afri.PlayGame();
        }

        public void AfFactGame()
        {
            try
            {
                MethodLibrary ml = new MethodLibrary();

                Console.Clear();
                ml.PrintColor(ConsoleColor.Yellow, "Welcome to the Facts page");
                ml.PrintColor(ConsoleColor.Yellow, "=========================================\n");


                Random rand = new Random();

                int factNo = rand.Next(interestingFacts.Length);
                string fact = interestingFacts[factNo];

                ml.PrintColor(ConsoleColor.Cyan, "\n\n\n" + fact);
                ml.PrintColor(ConsoleColor.Yellow, "\n\n\n Press any key to return to the Random facts menu");
                Console.ReadKey();
                RanFctPg();



            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchFormat();
                RanFctPg();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchAll();
                RanFctPg();
            }

        }

        public void PracticeCountries()
        {
            try
            {
                MethodLibrary ml = new MethodLibrary();

                int det;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                //ml.PrintColor(ConsoleColor.Magenta,"Welcome to the African countries game",resetFcolor:true,
                //returnFcolor:ConsoleColor.Cyan);

                Console.WriteLine("Welcome to the Practice African countries menu");
                Console.WriteLine("========================================================\n");
                Console.WriteLine("Enter the associated number to choose an option\n");
                Console.WriteLine("1. Learn all African countries");
                Console.WriteLine("2. Learn all North African countries");
                Console.WriteLine("3. Learn all East African countries");
                Console.WriteLine("4. Learn all West African countries");
                Console.WriteLine("5. Learn all South African countries");
                Console.WriteLine("6. Learn all Central African countries");
                Console.WriteLine("7. Return to Main Menu");

                det = Convert.ToInt32(Console.ReadLine());

                if (det > 7 || det == 0)
                {
                    Console.Clear();
                    ml.PrintColor(ConsoleColor.Red, "Only Numbers 1 through 7 are allowed as input");
                    ml.PrintColor(ConsoleColor.Magenta, "Press any key to return to the Menu ");
                    Console.ReadKey();
                    DisplayMenu();
                }

                string[] regionArr = allCountries;
                string regionName = "all the Countries in Africa";

                switch (det)
                {
                    case 1:
                        regionArr = allCountries;
                        regionName = "all the Countries in Africa";
                        break;
                    case 2:
                        regionArr = northAfrican;
                        regionName = "all the North African Countries in Africa";
                        break;
                    case 3:
                        regionArr = eastAfrican;
                        regionName = "all the East African Countries in Africa";
                        break;
                    case 4:
                        regionArr = westAfrican;
                        regionName = "all the West African Countries in Africa";
                        break;
                    case 5:
                        regionArr = southAfrican;
                        regionName = "all the South African Countries in Africa";
                        break;
                    case 6:
                        regionArr = centralAfrican;
                        regionName = "all the Central African Countries in Africa";
                        break;
                    case 7:
                        DisplayMenu();
                        break;

                }

                if (det < 7)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nThese are " + regionName);
                    Console.WriteLine("=====================================================\n\n");

                    for (int i = 0; i < regionArr.Length; i++)
                    {
                        ml.PrintColor(ConsoleColor.Cyan, i + ". " + regionArr[i]);

                    }

                    ml.PrintColor(ConsoleColor.Yellow, "\n\n press any key to return to the Menu");
                    Console.ReadKey();
                    PracticeCountries();

                }

            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchFormat();
                AfConGame();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                ml.CatchAll();
                AfConGame();
            }

        }






    }



    public class MethodLibrary
    {
        public void PrintColor(ConsoleColor fcolor, string message, ConsoleColor bcolor = ConsoleColor.Black,
                              bool writeway = false, ConsoleColor returnFcolor = ConsoleColor.Gray,
                              ConsoleColor returnBcolor = ConsoleColor.Black, bool resetFcolor = false,
                              bool resetBcolor = false)
        {
            Console.ForegroundColor = fcolor;
            Console.BackgroundColor = bcolor;

            if (!writeway)
            {
                Console.WriteLine(message);
            }
            else if (writeway)
            {
                Console.Write(message);
            }
            Console.ResetColor();

            if (resetFcolor)
            {
                Console.ForegroundColor = returnFcolor;
            }
            if (resetBcolor)
            {
                Console.BackgroundColor = returnBcolor;
            }

            Console.ResetColor();
        }

        public void proVersionMessage()
        {
            Console.Clear();
            PrintColor(ConsoleColor.Gray, "THIS FEATURE IS ONLY AVAILABLE IN THE FUTURE VERSION");
            PrintColor(ConsoleColor.Gray, " PRESS ANY KEY TO GO TO THE MAIN MENU");
            Console.ReadKey();

        }



        public void IfState(int num)
        {
            Console.Clear();
            PrintColor(ConsoleColor.Red, "Only Numbers 1 through " + num + " are allowed as input");
            PrintColor(ConsoleColor.Magenta, "Press any key to return to the Menu ");
            Console.ReadLine();
        }

        public void CatchFormat()
        {
            Console.Clear();
            PrintColor(ConsoleColor.Red, "Only valid Numbers are allowed");
            PrintColor(ConsoleColor.Magenta, "Press any key to return to the Menu ");
            Console.ReadKey();
        }

        public void CatchAll()
        {
            Console.Clear();
            PrintColor(ConsoleColor.Red, "An Error occurred ");
            PrintColor(ConsoleColor.Magenta, "Press any key to return to the Menu ");
            Console.ReadKey();
        }


        public void Exit()
        {
            Program p = new Program();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nThank you For using our app\n\n\n");
            Console.Write("Press Enter to Exit . . . ");
            PrintColor(ConsoleColor.Red, "Press r to return to the main menu");
            string det = Console.ReadLine();

            if (det == "R" || det == "r") p.DisplayMenu();


        }   // exits the application with a thank you message	


    }







    public class CountriesGamer
    {
        public string[] Arrayer;
        public string namer;

        public CountriesGamer()
        {
        }

        public void PlayGame()
        {
            try
            {
                MethodLibrary ml = new MethodLibrary();
                Program p = new Program();

                bool det = false;
                int score = 0;
                bool c = false;
                string wordUp;
                string word;
                string[] ArrayerUp = new string[Arrayer.Length];
                string[] compare = new string[Arrayer.Length];

                Console.Clear();

                do
                {
                    det = false;

                    ml.PrintColor(ConsoleColor.Cyan, " Enter the name of a Country in " + namer + " or press \"quit\" to resign\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    word = Console.ReadLine();
                    Console.ResetColor();

                    wordUp = word.ToUpper();

                    if (wordUp == "QUIT")
                    {
                        break;
                    }

                    for (int i = 0; i < compare.Length; i++)// To verify that user don't entered any word more than once.
                    {
                        if (wordUp == compare[i])
                        {
                            c = true;
                        }
                    }

                    if (c)
                    {
                        ml.PrintColor(ConsoleColor.Magenta, "You have already entered: " + word);

                    }

                    for (int i = 0; i < Arrayer.Length; i++)
                    {
                        ArrayerUp[i] = Arrayer[i].ToUpper();

                    }


                    foreach (string country in ArrayerUp)
                    {
                        if (wordUp == country)
                        {

                            if (!c)
                            {
                                score += 5;

                                for (int i = 0; i < compare.Length; i++)
                                {

                                    //if ((compare[i] == "" || compare[i] == null))
                                    if (string.IsNullOrEmpty(compare[i]))
                                    {

                                        compare[i] = wordUp;
                                        ml.PrintColor(ConsoleColor.Green, "CORRECT");
                                        ml.PrintColor(ConsoleColor.Yellow, word + " is in " + namer +
                                                      "\n\n");
                                        break;

                                    }
                                }


                            }

                            det = true;

                        }

                    }

                    if (!det)
                    {
                        ml.PrintColor(ConsoleColor.Red, "INCORRECT");
                        ml.PrintColor(ConsoleColor.Yellow, word + " is not in " + namer + "\n\n");
                    }



                } while (true);

                Console.Clear();
                ml.PrintColor(ConsoleColor.Cyan, "\nYour Total Score is: " + score);
                ml.PrintColor(ConsoleColor.Cyan, "Enter any key to return to African Countries Game menu");
                Console.ReadKey();
                p.AfConGame();

            }
            catch (FormatException)
            {
                MethodLibrary ml = new MethodLibrary();
                Program p = new Program();
                ml.CatchFormat();
                p.AfricanCon();
            }
            catch
            {
                MethodLibrary ml = new MethodLibrary();
                Program p = new Program();
                ml.CatchAll();
                p.AfricanCon();

            }

        }   // opens the all African countries game
    }

    /*
    public class Dbase
    {
        string curPath = Directory.GetCurrentDirectory();
        string path = curPath + "\\Dbase.DB";

        public void SaveScore(int score, string playerName, string arrayName)
        {
            string[] lines = File.ReadAllLines(filePath);
        }
    }
    */
}