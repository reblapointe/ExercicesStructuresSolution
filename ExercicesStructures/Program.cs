namespace ExercicesStructures
{
    internal class Program
    {
        public struct Appartement
        {
            public int nbChambres;
            public double nbSdB;
            public bool animaux;
            public int prixParMois;
        }

        public struct Point
        {
            public double x;
            public double y;
        }

        /*public struct Etudiant
        {
            string nom;
            string prenom;
            string numDA;
            Etudiant mentor;
            Adresse adresse;
            Date dateNaissance;
            Date dateInscription;
        }*/


        static bool RepondBesoinsCote(Appartement apt)
        {
            return apt.nbChambres >= 3 && apt.nbSdB >= 2;
        }

        static void ImprimerDescriptionAppartement(Appartement apt)
        {
            Console.WriteLine("Nombre de chambres : " + apt.nbChambres);
            Console.WriteLine("Nombre de salles de bain : " + apt.nbSdB);
            if (apt.animaux)
                Console.WriteLine("Droits aux animaux");
            Console.WriteLine("Loyer : " + apt.prixParMois);
        }

        static Point SymetrieAxeDesX(Point coord)
        {
            return new Point()
            {
                x = -coord.x,
                y = coord.y
            };
        }

        static Point AppliquerTranslation(Point coord, Point translation)
        {
            return new Point()
            {
                x = coord.x + translation.x,
                y = coord.y + translation.y
            };
        }

        static void AugmenterLoyer(Appartement appart)
        {
            Console.WriteLine("AVANT " + appart.prixParMois);
            appart.prixParMois += 50;
            Console.WriteLine("APRÈS " + appart.prixParMois);
        }

        static void Exercice1()
        {
            Appartement[] apts = new Appartement[5];

            apts[0].nbChambres = 2;
            apts[0].nbSdB = 1;
            apts[0].animaux = false;
            apts[0].prixParMois = 1000;

            apts[1].nbChambres = 1;
            apts[1].nbSdB = 1;
            apts[1].animaux = false;
            apts[1].prixParMois = 1200;

            apts[2].nbChambres = 1;
            apts[2].nbSdB = 1;
            apts[2].animaux = false;
            apts[2].prixParMois = 900;

            apts[3].nbChambres = 3;
            apts[3].nbSdB = 2;
            apts[3].animaux = true;
            apts[3].prixParMois = 2000;

            apts[4].nbChambres = 2;
            apts[4].nbSdB = 2;
            apts[4].animaux = true;
            apts[4].prixParMois = 1500;

            for (int i = 0; i < apts.Length; i++)
            {
                Console.WriteLine("Appartement #" + i);
                ImprimerDescriptionAppartement(apts[i]);
                if (RepondBesoinsCote(apts[i]))
                {
                    Console.WriteLine("Répond aux besoins de la famille Côté");
                }
                Console.WriteLine();
            }
        }

        static void Exercice2()
        {
            Point p = new Point()
            {
                x = 1,
                y = 2
            };
            Point t = new Point()
            {
                x = -10,
                y = 100
            };

            Point symetrie = SymetrieAxeDesX(p);
            Console.WriteLine($"Symétrie de ({p.x},{p.y}) par rappot à l'axe des X : " +
                $"({symetrie.x}, {symetrie.y})");
            Point translation = AppliquerTranslation(p, t);
            Console.WriteLine($"Translation de ({p.x},{p.y}) par ({t.x},{t.y}) : " +
                $"({translation.x}, {translation.y})");
            Console.WriteLine();
        }
        static void Exercice3()
        {
            Appartement a = new Appartement
            {
                nbChambres = 2,
                animaux = true,
                nbSdB = 1,
                prixParMois = 1200
            };
            Console.WriteLine("AVANT " + a.prixParMois);
            AugmenterLoyer(a);
            Console.WriteLine("APRÈS " + a.prixParMois);
        }


        static void Main(string[] _)
        {
            Exercice1();
            Exercice2();
            Exercice3();
        }
    }
}