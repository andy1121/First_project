using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    
    void Start()
    {
        var Greeting = "Ajay";
        Terminal.WriteLine(Greeting);
        ShowTheMenu();
    }
    void ShowTheMenu()
    {
        Terminal.WriteLine("welcome to jumblings");
        Terminal.WriteLine("select the game difficulty");
        Terminal.WriteLine("Easy");
        Terminal.WriteLine("Medium");
        Terminal.WriteLine("Difficult");
    }
   void OnUserInput(string input)
    {

        
        print(input);
        if (input == "1")
        {
            print("true");
        } else if (input=="7") { 

            Terminal.WriteLine("you accsed special");

        }else {
            Terminal.WriteLine("please enter the valid value");
        }
    }
  
}
