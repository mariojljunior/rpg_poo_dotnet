using System;
using RPG.src.Entities;

namespace RPG
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero("Arus", 42, "Knight");
      Wizard wizard = new Wizard("Jenica", 42, "White Wizard");

      Console.WriteLine(hero.Attack());
      Console.WriteLine(wizard.Attack(1));
    }
  }
}