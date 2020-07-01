using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
