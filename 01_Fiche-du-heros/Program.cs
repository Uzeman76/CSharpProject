Console.WriteLine("Bienvenue dans l'Arène !");
Console.Write("Votre nom : ");
string nom = Console.ReadLine();
Console.WriteLine($"Bienvenue, {nom} !");


int pvHero = 100;
int pvMaxh = 100;
int attHero = 30;
int defHero = 10;
int potionHero = 3;
int heal = 20;
bool fuite = false;
int tailleBarreH = 10;

Console.WriteLine("Vous êtes un Guerrier");
Console.WriteLine($"Vous avez {pvHero} PV, {attHero} d'attaque, {defHero} de défense\n");

for (int vague = 1; vague <= 3; vague++)
{
    string nomEnnemi = "";
    int pvEnm = 0;
    int pvMaxenm = 0;
    int attEnm = 0;
    int defEnm = 0;
    int pvShield = 0;
    int bonusEnm = 0;
    int potionEnm = 0;
    int tailleBarreGEnm = 0;

    switch (vague)
    {
        case 1:
            nomEnnemi = "Gobelin";
            pvEnm = 80;
            attEnm = 15;
            defEnm = 5;
            pvShield = 5;
            bonusEnm = 6;
            potionEnm = 3;
            tailleBarreGEnm = 10;
            pvMaxenm = 80;
            break;
        case 2:
            nomEnnemi = "Orq";
            pvEnm = 120;
            attEnm = 20;
            defEnm = 7;
            pvShield = 8;
            bonusEnm = 6;
            potionEnm = 2;
            tailleBarreGEnm = 10;
            pvMaxenm = 120;
            break;
        case 3:
            nomEnnemi = "Dragon";
            pvEnm = 200;
            attEnm = 30;
            defEnm = 10;
            pvShield = 10;
            bonusEnm = 6;
            potionEnm = 0;
            tailleBarreGEnm = 20;
            pvMaxenm = 200;
            break;
    }

    Thread.Sleep(2000);
    int pvMaxEnm = pvEnm;
    Console.WriteLine($"\n========================================");
    Console.WriteLine($"   VAGUE {vague} : Un {nomEnnemi} apparaît !");
    Console.WriteLine($"========================================");
    Console.WriteLine("Le combat commence dans :");

    for (int i = 3; i >= 1; i--)
    {
        Console.WriteLine($"{i}...");
        Thread.Sleep(1000);
    }

    int tour = 0;

    while (pvEnm > 0 && pvHero > 0 && !fuite)
    {
        tour++;
        Console.WriteLine($"\n==================== TOUR {tour} ====================");
        Console.WriteLine("Qu'allez-vous faire ?");
        Console.WriteLine($"1) Attaquer  |  2) Potion ({potionHero} restante(s))  |  3) Fuir");

        int choix;
        while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 3)
        {
            Console.WriteLine("Choix invalide. Veuillez entrer 1, 2 ou 3 :");
        }

        if (choix == 1)
        {
            int shield = Random.Shared.Next(1, 101);
            int degatBase = attHero - defEnm;
            if (degatBase < 0) degatBase = 0;

            if (shield <= 10)
            {
                int degatReel = degatBase - pvShield;
                if (degatReel < 0) degatReel = 0;

                pvEnm -= degatReel;
                Console.WriteLine($"Le {nomEnnemi} utilise son bouclier ! Il subit {degatReel} dégâts.");
            }
            else
            {
                pvEnm -= degatBase;
                Console.WriteLine($"Tous les dégâts passent ! Le {nomEnnemi} subit {degatBase} dégâts.");
            }
        }
        else if (choix == 2)
        {
            if (potionHero > 0)
            {
                pvHero += heal;
                if (pvHero > pvMaxh) pvHero = pvMaxh;
                potionHero--;
                Console.WriteLine($"Vous buvez une potion (+{heal} PV). Il vous reste {potionHero} potion(s).");
            }
            else
            {
                Console.WriteLine("Vous n'avez plus de potions ! Tour perdu.");
            }
        }
        else if (choix == 3)
        {
            fuite = true;
            Console.WriteLine("Vous prenez la fuite !");
        }

        if (pvEnm <= 0 || fuite) break;

        Thread.Sleep(1500);

        Console.WriteLine("\n--- Tour de votre adversaire ---");
        int jetTour = Random.Shared.Next(1, 101);

        if (jetTour <= 15)
        {
            int degatGob = attEnm + bonusEnm - defHero;
            if (degatGob < 0) degatGob = 0;

            pvHero -= degatGob;
            Console.WriteLine($"Coup critique du {nomEnnemi} ! Vous subissez {degatGob} dégâts.");
        }
        else if (jetTour <= 80)
        {
            int degatGob = attEnm - defHero;
            if (degatGob < 0) degatGob = 0;

            pvHero -= degatGob;
            Console.WriteLine($"Le {nomEnnemi} vous attaque et inflige {degatGob} dégâts.");
        }
        else
        {
            if (potionEnm > 0)
            {
                pvEnm += heal;
                if (pvEnm > pvMaxenm) pvEnm = pvMaxenm;
                potionEnm--;
                Console.WriteLine($"Le {nomEnnemi} boit une potion et récupère {heal} PV !");
            }
            else
            {
                int degatGob = attEnm - defHero;
                if (degatGob < 0) degatGob = 0;
                pvHero -= degatGob;
                Console.WriteLine($"Le {nomEnnemi} n'a plus de potion et vous attaque pour {degatGob} dégâts.");
            }
        }

        Console.WriteLine("\n[ État du combat ]");

        int carresPleinsh = (pvHero * tailleBarreH) / pvMaxh;
        if (carresPleinsh < 0) carresPleinsh = 0;

        Console.Write("Vie Héro    : [");
        for (int i = 0; i < tailleBarreH; i++)
        {
            Console.Write(i < carresPleinsh ? "■" : "□");
        }

        Console.WriteLine($"] {pvHero}/{pvMaxh} PV");

        int carresPleinsg = (pvEnm * tailleBarreGEnm) / pvMaxenm;
        if (carresPleinsg < 0) carresPleinsg = 0;

        Console.Write("Vie Gobelin : [");
        for (int i = 0; i < tailleBarreGEnm; i++)
        {
            Console.Write(i < carresPleinsg ? "■" : "□");
        }

        Console.WriteLine($"] {pvEnm}/{pvMaxenm} PV");

        Thread.Sleep(2000);
    }

    Console.WriteLine("\n========================================");
    if (fuite)
    {
        Console.WriteLine("Vous vous êtes enfui du combat.");
    }
    else if (pvHero <= 0)
    {
        Console.WriteLine($"Défaite... Vous avez été vaincu par le {nomEnnemi}.");
    }
    else
    {
        Console.WriteLine($"Victoire ! Vous avez vaincu le {nomEnnemi} !");
    }

    Console.WriteLine("========================================");
}