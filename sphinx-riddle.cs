using System;
using System.Collections.Generic;

class SphinxRiddle
{
  public static Dictionary<string, string> riddles = new Dictionary<string, string>();

  public static int RandomNum(int max) 
  {
    Random random = new Random();
    return random.Next(max);
  }
  static void Main()
  {
    riddles.Add("What has roots as nobody sees, Is taller than trees, Up, up it goes, And yet never grows?", "A mountain");
    riddles.Add("Voiceless it cries, Wingless flutters, Toothless bites, Mouthless mutters.", "Wind");
    riddles.Add("It cannot be seen, cannot be felt,Cannot be heard, cannot be smelt. It lies behind stars and under hills, And empty holes it fills. It comes first and follows after, Ends life, kills laughter.", "Dark");

    List<string> keyList = new List<string>(riddles.Keys);

    string randomKey = keyList[RandomNum(keyList.Count)];

    Console.WriteLine(randomKey);

    string answer = Console.ReadLine();
    if(answer == riddles[randomKey]) {
      Console.WriteLine("Correct! The Sphinx has been defeated!");
    } else {
      Console.WriteLine("You have failed and the Sphinx eats you...");
    }

  }
}