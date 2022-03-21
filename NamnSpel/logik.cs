using System;
using System.Collections.Generic;

public class Logic{
public static string [] names = {"Bowser", "Doctor Robotnik", "King Krool", "Dr Wily", "Sephiroth", "Ganon", "Captain LeChuck", "Alice", "Maja", "Vera", "Alma", "Selma", "Gustafsson", "Svensson", "Johansson", "Noah", "William", "Liam", "Hugo", "Lucas"};
    public static void Start(){
        System.Console.WriteLine("Skriv en sifra mellan 3 och 10 Det får inte vara en bokstav, för att få ett namn med den längden");
    }
    public static void DoingStuff (){
        int nameLength;
        bool check = true;

        List<string> queList = new List<string>();

        //chekar input och aryen 
        while(check == true){
            if(int.TryParse(System.Console.ReadLine(), out nameLength) == true){
                if(nameLength > 3 && nameLength < 10){
                    for(int i = 0;i < names.Length;i++){
                        if(names[i].Length == nameLength){
                            queList.Add(names[i]);
                        }
                    }
                    check = false;
                }
            }
        }

        //random från listan

    }



}