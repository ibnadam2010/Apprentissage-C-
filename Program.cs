using System;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // manière 1 de décalarer un tableau 
            int[] monTab = new int[5];
            monTab[0] = 10; monTab[1] = 20; monTab[2] = 30; monTab[3] = 40;monTab[4] = 50;

            // manière 2 de décalarer un tableau 
            string[] couleur = new string[] { "vert", "jaune", "rouge" };


            // manière 3 de décalarer un tableau 
            char[] lettre = { 'a', 'b', 'c' };


            // manière 1 de décalarer un tableau multidimension
            int[,] tabMultiple = new int[2, 2];

            // remplissage de la ligne 1 du tableau multidimension
            tabMultiple[0, 0] = 1;
            tabMultiple[0, 1] = 2;

            // remplissage de la ligne 2 du tableau multidimension
            tabMultiple[1, 0] = 3;
            tabMultiple[1, 1] = 4;


            // manière de décalarer et assigner un tableau multidimension
            int[,] tabMultiple2 = new int[3, 2] { { 1, 2 }, { 1, 4 }, { 1, 16 } };


            // manière 1 de décalarer un tableau colonne varié
            int[][] tabColonneV1 = new int[3][];
            tabColonneV1[0] = new int[1] { 0};
            tabColonneV1[1] = new int[2] { 1, 2 };
            tabColonneV1[2] = new int[4] { 1, 2,3,4 };

            // manière 2 de décalarer un tableau colonne varié
            int[][] tabColonneV2 = new int[][]
            {
               new int[]{1,2},
               new int[]{2,1,4,7},
               new int[]{1}
            };


            // manière 3 de décalarer un tableau colonne varié
            int[][] tabColonneV3 = 
            {
               new int[]{1,2},
               new int[]{2,1,4,7},
               new int[]{1}
            };


            Console.WriteLine("Taper votre nom...");
            string leNom = Console.ReadLine();
            Console.WriteLine("Bonjour " + leNom);
            Console.WriteLine("La taille du tableau monTab est " + monTab.Length);
            Console.WriteLine("La longeur du tableau tabMultiple est " + tabMultiple.Length);

            //Les chaines de caractère
            string chaine1 = "formation c# Adamou";
            Console.WriteLine(chaine1);

            //Chaine de caractère vide
            string chaineVide = string.Empty;

            char[] tableauDe = new char[] 
            { 'f', 'o', 'r', 'm', 'a', 't', 'i', 'o', 'n',' ', 'c','#',' ', 'A', 'd', 'a', 'm', 'o', 'u', ' ','S' };
            string tbleau = new string(tableauDe);
            Console.WriteLine("Votre tableau de caractère donne la chaine-> "+tbleau);

            //Concatenation de chaine
            StringBuilder sb = new StringBuilder();
            sb.Append("Bienvenu");
            sb.Append("au cours de programation");
           
            Console.WriteLine(sb);
            sb.Insert(17, " Chapitre 20 ");
            Console.WriteLine(sb);

            
            string strb = "partie 1";
            strb += " partie 2";

            Console.WriteLine("La longueur de partie1 partie2 est "+ strb.Length);
            Console.WriteLine(strb.Insert(17, " partie 3"));
            Console.WriteLine(strb.Substring(0,8));
            

            


            //formatage de date

            DateTime dt = DateTime.Now;
            Console.WriteLine("Date du jour " + dt);
            Console.WriteLine("Date du jour annee seule " + dt.ToString("yyyy"));
            Console.WriteLine("Nous somme le : {0:D}" ,dt);
            Console.WriteLine("Nous somme le : {0:d}", dt);

            Console.WriteLine("Saisissez votre age ");

            int age = int.Parse(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("vous etes un mineur");
            }
            else
            {
                Console.WriteLine("Bravo! vous etes majeur");
            }

            Console.WriteLine("entrez un lettre..");
            char alpha = char.Parse(Console.ReadLine());

            if (char.IsNumber(alpha)) 
            {
                Console.WriteLine("La valeur saisie doit etre une lettre");
            }
            else 
            {
            switch (alpha)
                {
                    case 'a':
                        Console.WriteLine("adam");
                        break;
                    case 'b':
                        Console.WriteLine("boris");
                        break;
                    case 'c':
                        Console.WriteLine("charles");
                        break;
                    default:
                        Console.WriteLine("Aucune correspondance détectée");
                        break;
                }
                    
            }

        }
    }
}
