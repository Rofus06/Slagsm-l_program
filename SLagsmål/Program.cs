using System;
using System.Threading;

int heroHp = 150;
int villainHp = 150;

string HName = "The Hero";
string VName = "The Villan";

int heroMaxDamage = 40;
int villainMaxDamage = 35;

bool battleNealyFinished = false;

Random generator = new Random();

while (heroHp > 40 && villainHp > 40)
{
  Console.WriteLine("----Rundan Börjar Nu!----");
  Thread.Sleep(1);
  Console.WriteLine($"{HName}: {heroHp}  {VName}: {villainHp}\n");
  Thread.Sleep(1);

  int heroDamage = generator.Next(heroMaxDamage);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{HName} gör {heroDamage} skada på {VName}");
  Thread.Sleep(1);

  int villainDamage = generator.Next(villainMaxDamage);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{VName} gör {villainDamage} skada på {HName}");
  Thread.Sleep(1);

    if (heroHp < 40 && battleNealyFinished != true)
    {
      battleNealyFinished = true;
      Console.WriteLine("===== STRIDEN ÄR SNART SLUT =====");
      Console.WriteLine($"{HName} Använder sin superkraft!");
      heroMaxDamage = 60;
    }
    if (villainHp < 40)
    {
      Console.WriteLine($"{VName} Använder sin superkraft!");
      villainMaxDamage = 55;
    }
    if (heroHp <= 40 && villainHp <= 40)
    {
      Console.WriteLine("Båda använder sin superkraft samtidigt");
      heroMaxDamage = 60;
      villainMaxDamage = 55;
    }
  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadLine();
}

Console.WriteLine("===== STRIDEN ÄR SLUT =====");
if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (heroHp == 0 || heroHp < 0)
{
  Console.WriteLine($"{VName} vann!");
}
else
{
  Console.WriteLine($"{HName} vann!");
}
Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();