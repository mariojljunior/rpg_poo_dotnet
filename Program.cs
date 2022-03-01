using System;
using RPG.src.Entities;

namespace RPG
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight hero = new Knight("Arus", 42, "Knight", 749, 469, 72, 72, 300, 300);
      Ninja ninja = new Ninja("Wedge", 42, "Ninja", 574, 292, 89, 89, 250, 250);
      Wizard whiteWizard = new Wizard("Jenica", 42, "White Wizard", 606, 325, 482, 474, 50, 50);
      Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 385, 106, 641, 611, 90, 90);
      

      // Console.WriteLine(hero.ToString());
      // Console.WriteLine(ninja.ToString());
      // Console.WriteLine(whiteWizard.ToString());
      // Console.WriteLine(blackWizard.ToString());

      Console.WriteLine(hero.Attack(20));
      // Console.WriteLine(hero.Defend());
      // Console.WriteLine(ninja.Attack());
      // Console.WriteLine(ninja.Defend());
      Console.WriteLine(whiteWizard.Attack(60));
      // Console.WriteLine(whiteWizard.Defend());
      // Console.WriteLine(blackWizard.Attack());
      // Console.WriteLine(blackWizard.Defend());
    }
  }
}