using System.IO;
using System;

class MainClass {
  public static void Main (string[] args) {
    ShowMainMenu();
  }

  private static void ShowTitle(){
    Console.Clear();
    Console.WriteLine("Lib sys");
    Console.WriteLine();
  }
  private static void ShowMainMenu(){
    string message = "";
    string choice = "";
    do {
      ShowTitle();
      Console.WriteLine("Main Menu");
      Console.WriteLine("---------");
      Console.WriteLine("1. Book Issue");
      Console.WriteLine("2. Book Return");
      Console.WriteLine("3. Books Manangement");
      Console.WriteLine("4. Member Manangement");
      Console.WriteLine("0. Exit");
      Console.WriteLine("");
      Console.Write(message);
      Console.Write("Choice [0-4]? ");
      choice = Console.ReadLine();
      message = "";
      switch(choice){
        case "0":
          break;
        case "1": 
          message = "Not available yet...\n";
          break;
        case "2":
          message = "Not available yet...\n";
          break;
        case "3":
          message = "Not available yet...\n";
          break;
        case "4":
          message = "Not available yet...\n";
          break;
        default:
          message = "Invalid choice, try again...\n";
          break;
      }
    } while(choice != "0");

  }


}
