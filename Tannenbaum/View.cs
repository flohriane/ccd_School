using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class View
    {
        /// <summary>
        /// holt im 1. Schritt vom Benutzer die Höhe des Tannenbaums
        /// </summary>
        /// <returns> int height </returns>
        public int GetNumberOfLines()
        {
            int height;
            Console.Write("Wie hoch soll der Tannenbaum werden? (zwischen 3-15 Zeilen): ");
            string value = Console.ReadLine();
            return height = CheckValidValue(value); ;
        }

        /// <summary>
        /// holt im 2. Schritt vom Benutzer die Angabe, ob der Baum eine Spitze bekommen soll oder nicht
        /// ruft Prüfung für korrekte Eingabe auf
        /// </summary>
        /// <returns> bool star </returns>
        public bool GetStar()
        {
            bool star;
            Console.Write("\nSoll der Baum einen Stern bekommen? (gib J oder N ein) ");
            string starSelect = Console.ReadLine().ToUpper();
            return star = CheckStar(starSelect);
        }

        /// <summary>
        /// zeichnet entsprechend der Benutzereingabe für Zeilenhöhe den Baum
        /// </summary>
        /// <param name="height"></param>
        public void Zeichnen(int height)
        {
            Console.WriteLine();

            // aufgrund der eingegebenen Höhe ergibt sich die Anzahl der Schleifendurchläufe
            // die Anzahl der zu druckenden Leerzeichen und Xs ergibt sich aus der eingegebenen Höhe
            for (int i = 1; i <= height; i++)
            {
                int numberOfX = i + (i - 1);
                PrintTannenbaumBody(numberOfX, height);
            }

            PrintTrunk(height);
        }

        /// <summary>
        /// zeichnet entsprechend der Eingabe des Benutzers eine Sptize bevor der Baum gezeichnet wird
        /// </summary>
        /// <param name="height"></param>
        public void ZeichnenMitSpitze(int height)
        {
            Console.WriteLine();
            PutStarOnTop(height);
            Zeichnen(height);
        }

        /// <summary>
        /// prüft Benutzereingabe für Zeilenhöhe auf Richtigkeit
        /// bei falscher Eingabe wird der Aufruf zur Eingabe wiederholt
        /// </summary>
        /// <param name="value"></param>
        /// <returns> int height </returns>
        private int CheckValidValue(string value)
        {
            int height;
            bool validValue = Int32.TryParse(value, out height);
            if (validValue)
            {
                CheckInputNumberOfLines(height);
                return height;
            }
            else
            {
                Console.WriteLine("\nbitte gib eine gültige Zahl ein!!!\n");
                // do again input by user
                GetNumberOfLines();
                return 0;
            }
        }

        /// <summary>
        /// prüft, ob Benutzereingabe in sinnvollem Bereich zwischen 3 und 15 liegt
        /// bei falscher Eingabe wird der Aufruf zur Eingabe wiederholt
        /// </summary>
        /// <param name="height"></param>
        private void CheckInputNumberOfLines(int height)
        {
            if (height < 3 || height > 15)
            {
                Console.WriteLine("\nbitte gib eine gültige Zahl ein!!!\n");
                // do again input by user
                GetNumberOfLines();
            }
        }

        /// <summary>
        /// prüft die Benutzereingabe für Stern und fängt falsche Eingaben ab
        /// </summary>
        /// <param name="starSelect"></param>
        /// <returns> bool </returns>
        private bool CheckStar(string starSelect)
        {
            if (starSelect == "J")
            {
                return true;
            }
            else if (starSelect == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\nFalsche Eingabe!   Bitte gib J oder N ein");
                // do again input by user
                GetStar();
                return false;
            }
        }

        /// <summary>
        /// zeichnet 1 Zeile des Baums aus Leerzeichen und X entsprechend Parameterübergabe
        /// </summary>
        /// <param name="numberOfX"></param>
        private void PrintTannenbaumBody(int numberOfX, int height)
        {
            // Leerzeichen zeichnen
            PrintChar(height-(numberOfX/2)-1, " ");
            // X zeichnen
            PrintChar(numberOfX, "X");
            Console.WriteLine();
        }

        /// <summary>
        /// zeichnet einzelne Zeichen entsprechend Parameterübergabe 
        /// </summary>
        /// <param name="numberOfChars"></param>
        /// <param name="char1"></param>
        private void PrintChar(int numberOfChars, string char1)
        {
            for (int i = 0; i < numberOfChars; i++)
            {
                Console.Write(char1);
            }
        }
        
        /// <summary>
        /// zeichnet Leerzeichen und Stern
        /// </summary>
        /// <param name="height"></param>
        private void PutStarOnTop(int height)
        {
            // zeichnet Leerzeichen vor Stern
            PrintChar(height-1, " ");
            // zeichnet Stern an richtiger Position
            Console.Write("*");
        }

        /// <summary>
        /// zeichnet Leerzeichen und Stamm
        /// </summary>
        /// <param name="height"></param>
        private void PrintTrunk(int height)
        {
            // zeichnet Leerzeichen vor Stamm
            PrintChar(height-1, " ");
            // zeichnet Stamm an richtiger Position
            Console.Write("I\n\n");
        }
        /// <summary>
        /// hält Konsole offen
        /// </summary>
        public void EndProgramm()
        {
            Console.ReadKey();
        }
    }
}
