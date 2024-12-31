namespace inventairePjt
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Déclaration de variables
            int choixMenu;

            //Déclaration des tableaux grâce au nb d'articles saisis
            string[] articles = new string[20];
            int[] stocks = new int[20];

            //Affichage du menu
            menu();

            //Saisie du choix de l'utilisateur
            choixMenu = Convert.ToInt32(Console.ReadLine());

        }
    }
}
