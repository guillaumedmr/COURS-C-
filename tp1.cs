using System;

public class Application
{
	public void fonctionPrincipale ()
	{
		//DEBUT de votre programme
		Console.Clear();
		Console.WriteLine("Bonjour Joueur 1, entrez votre pseudo :");
		Player player1 = new Player();
		player1.pseudo = Utilisateur.saisirTexte();
		Console.Clear();
		Console.WriteLine($"Bienvenue {player1.pseudo} !");


		Bot botAttack1 = new Bot();
		botAttack1.force=1;
		botAttack1.vie=100;

		do {
		Console.Write("Appuis sur entrée pour lancer les dés !");
		string Valide = Utilisateur.saisirTexte();
		Console.Clear();
	
		Random random = new Random();
        int randomNumber1;
        randomNumber1 = random.Next(1, 6);
		int randomNumber2;
        randomNumber2 = random.Next(1, 6);
		Console.WriteLine($"Le résultat du premier dé est {randomNumber1} et du deuxième est {randomNumber2} !");

		
		


		botAttack1.vie = botAttack1.vie - (randomNumber1 + randomNumber2) * 10;

		if (botAttack1.vie > 0) {
		Console.WriteLine($"Le bot a {botAttack1.force} de force et sa vie est de {botAttack1.vie}% !");
		}

		if (botAttack1.vie < 0) {
			Console.WriteLine($"Vous avez tué le bot !");
		}

		if (botAttack1.vie == 0) {
			Console.WriteLine($"Vous avez tué le bot !");
		}

		} while (botAttack1.vie>0);




		//FIN de votre programme
	}

}


