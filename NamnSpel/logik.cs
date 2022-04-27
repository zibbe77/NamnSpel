using System;
using System.Collections.Generic;

public class Logic
{
    //Den är en array eftersom jag inte planerar att ändra den utan avänder den som en statisk data base
    public static string[] names = { "Bowser", "Doctor Robotnik", "King Krool", "Dr Wily", "Sephiroth", "Ganon", "Captain LeChuck", "Alice", "Maja", "Vera", "Alma", "Selma", "Gustafsson", "Svensson", "Johansson", "Noah", "William", "Liam", "Hugo", "Lucas", "leo" };
    public static void Start()
    {
        System.Console.WriteLine("Skriv en sifra mellan 3 och 10 Det får inte vara en bokstav, för att få ett namn med den längden.");
    }
    public static void DoingStuff()
    {
        int nameLength;
        bool check = true;

        // jag har valt en list här eftersom jag vill läga till saker. Om jag hade använt en array skulle jag beöva bestäm stolken i början men jag orkar inte räkna hur många av varje namn det fins. 
        List<string> queList = new List<string>();

        //chekar input och aryen 
        while (check == true)
        {
            if (int.TryParse(System.Console.ReadLine(), out nameLength) == true)
            {
                if (nameLength >= 3 && nameLength <= 10)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i].Length == nameLength)
                        {
                            queList.Add(names[i]);
                        }
                    }
                    check = false;
                }
            }
            else
            {
                Cleanstuff();
                System.Console.WriteLine("Du måste skriva ett tal mellan 3 och 10. (Inga desimaler).");
            }
        }

        //random från listan
        //foreach (string name in queList) { System.Console.WriteLine($"!!debug!!{name}"); }
        Random generator = new Random();
        int r = generator.Next(queList.Count);
        System.Console.WriteLine($"Du fick nament {queList[r]}.");
        System.Console.WriteLine("klicka enter för att forsäta");
    }

    public static void Cleanstuff()
    {
        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine(" ");
        }
    }

    public static bool PlayAgain()
    {
        bool playAgain = false;
        bool answer = false;
        while (answer == false)
        {
            Cleanstuff();
            System.Console.WriteLine("Vill du köra igen? (Vid nej stängs spelet)");
            System.Console.WriteLine("Skriv Ja eller Nej");
            string input = Console.ReadLine();

            if (input == "ja" || input == "Ja" || input == "JA")
            {
                playAgain = true;
                answer = true;
            }
            else if (input == "nej" || input == "Nej" || input == "NEJ")
            {
                playAgain = false;
                answer = true;
            }
        }
        return playAgain;
    }

}