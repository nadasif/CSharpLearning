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
          ShowManageBooksMenu();
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

  private static void ShowManageBooksMenu(){
    string message = "";
    string choice = "";
    do {
      ShowTitle();
      Console.WriteLine("Manage Books");
      Console.WriteLine("---------");
      Console.WriteLine("1. List Books");
      Console.WriteLine("2. Add Book");
      Console.WriteLine("3. Remove Book");
      Console.WriteLine("0. Exit");
      Console.WriteLine("");
      Console.Write(message);
      Console.Write("Choice [0-3]? ");
      choice = Console.ReadLine();
      message = "";
      switch(choice){
        case "0":
          break;
        case "1": // List books 
          message = "Not available yet...\n";
          break;
        case "2": // Add books 
          AddBooks();
          break;
        case "3":
          message = "Not available yet...\n";
          break;
        default:
          message = "Invalid choice, try again...\n";
          break;
      }
    } while(choice != "0");

  }

  private static void AddBooks(){
    ShowTitle();
    Console.WriteLine("Book ID: ");
    string bookId = Console.ReadLine();
    Console.WriteLine("Title  : ");
    string title = Console.ReadLine();
    StreamWriter writer = new StreamWriter("books.txt", true);
    writer.WriteLine($"{bookId},{title}");
    writer.Flush();
    writer.Close();
  }

}
