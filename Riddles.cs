using System;

class Program
{
  static void Main()
  {
      string[] riddles = {"Voiceless it cries, wingless flutters, toothless bites, mouthless mutters. What am I?"};
      string[] answers = {"the wind"};
      for(int location = 0; location < riddles.Length; location++){
          bool keepGoing = askRiddle(riddles[location], answers[location]);
          if(!keepGoing){
              Console.WriteLine("The Sphinx eats you.");
              break;
          } else if(location == (riddles.Length-1)){
            Console.WriteLine("You defeated the Sphinx. It has no more riddles.");
          }
      }
      
      
  }

  static bool askRiddle(string riddle, string answer){
      bool keepGoing = true;
      Console.WriteLine(riddle);
      string userInput = Console.ReadLine().ToLower();
      if(userInput != answer){
          keepGoing = false; 
      }
      return keepGoing;
  }
}
