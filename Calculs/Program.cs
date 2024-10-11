using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilisateur

            // boucle sur le menu
            choix = 1;
            while (true) // boucle infinie jusqu'à ce que l'utilisateur choisisse de quitter
            {
                // affiche le menu et saisie du choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");

                // tentative de conversion de la saisie en entier
                string saisie = Console.ReadLine();

                // Vérification de la saisie
                if (!int.TryParse(saisie, out choix))
                {
                    Console.WriteLine("Erreur : La saisie ne doit pas être une lettre ou un nombre réel. Veuillez entrer un nombre entier.");
                    continue; // retour au début de la boucle si la saisie est incorrecte
                }

                // traitement des choix
                if (choix == 0) // Quitter
                {
                    break; // sortir de la boucle
                }
                else if (choix == 1)
                {
                    // choix de l'addition
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    // saisie de la réponse
                    Console.Write(val1 + " + " + val2 + " = ");
                    if (int.TryParse(Console.ReadLine(), out reponse)) // Vérifie la réponse de l'utilisateur
                    {
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erreur : La réponse doit être un nombre entier.");
                    }
                }
                else if (choix == 2)
                {
                    // choix de la multiplication
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    // saisie de la réponse
                    Console.Write(val1 + " x " + val2 + " = ");
                    if (int.TryParse(Console.ReadLine(), out reponse)) // Vérifie la réponse de l'utilisateur
                    {
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erreur : La réponse doit être un nombre entier.");
                    }
                }
                else
                {
                    // saisie incorrecte (différente de 0, 1 et 2)
                    Console.WriteLine("Erreur de saisie, veuillez écrire un nombre entier entre 0 et 2.");
                }
            }
        }
    }
}