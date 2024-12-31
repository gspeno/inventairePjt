using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventairePjt
{
    partial class Program
    {
        static void menu()
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Saisir les articles");
            Console.WriteLine("2. Afficher tous les articles et leurs stocks");
            Console.WriteLine("3. Calculer et afficher le prix total de l'inventaire");
            Console.WriteLine("4. Trouver et afficher l'article le plus cher.");
            Console.WriteLine("5. Rechercher un article par son nom et afficher son prix");
            Console.WriteLine("6. Mettre à jour le stock d'un article");
            Console.WriteLine("7. Afficher les articles en rupture de stock");
            Console.WriteLine("8. Quitter");
            Console.Write("Choisissez une option : ");
       
            }
    }
}
