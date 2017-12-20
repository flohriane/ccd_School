using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class View
    {
        private Model model;
        public View(Model model)
        {
            this.model = model;
        }

        private int height = 0;
        private bool star;

        /// <summary>
        /// lets user decide to put a star on top of the tree or not
        /// </summary>
        public void GetStar()
        {
            Console.Write("\nSoll der Baum einen Stern bekommen? (gib J oder N ein) ");
            string starSelect = Console.ReadLine().ToUpper();

            if (starSelect == "J")
            {
                star = true;
            }
            else if (starSelect == "N")
            {
                star = false;
            }
            else
            {
                Console.WriteLine("\nFalsche Eingabe!   Bitte gib J oder N ein");
                GetStar();
            }
        }
        /// <summary>
        /// user input for height of tree
        /// </summary>
        public void GetNumberOfLines()
        {
            Console.Write("Wie hoch soll der Tannenbaum werden? (zwischen 3-15 Zeilen): ");
            string value = Console.ReadLine();
            CheckValidValue(value);
        }
        /// <summary>
        /// Console stays open until user presses any key
        /// </summary>
        public void EndProgramm()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// check user input
        /// </summary>
        /// <param name="value"></param>
        private void CheckValidValue(string value)
        {
            bool validValue = Int32.TryParse(value, out height);
            if (validValue)
            {
                CheckInputNumberOfLines(height);
            }
            else
            {
                Console.WriteLine("\nbitte gib eine gültige Zahl ein!!!\n");
                // do again input by user
                GetNumberOfLines();
            }
        }
        /// <summary>
        /// prints * by demand of user
        /// prints tree body
        /// prints trunk
        /// </summary>
        public void PrintTannenbaum()
        {
            Console.WriteLine();

            if (star)
            {
                PutStarOnTop();
            }

            for (int i = 1; i <= height; i++)
            {
                int numberOfX = i + (i - 1);
                PrintTannenbaumBody(numberOfX);
            }

            PrintTrunk();
        }       
        /// <summary>
        /// check if number of lines ist between 3 an 12
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
        /// prints line of tree body
        /// </summary>
        /// <param name="numberOfX"></param>
        private void PrintTannenbaumBody(int numberOfX)
        {
            PrintBlanks(height-(numberOfX/2)-1);
            PrintX(numberOfX);
            Console.WriteLine();
        }
        /// <summary>
        /// prints blanks depending on height
        /// </summary>
        private void PrintBlanks(int numberOfBlanks)
        {
            for (int i = 0; i < numberOfBlanks; i++)
            {
                Console.Write(" ");
            }
        }
        /// <summary>
        /// prints X depending on height
        /// </summary>
        /// <param name="numberOfX"></param>
        private void PrintX(int numberOfX)
        {
            for (int i = 0; i < numberOfX; i++)
            {
                Console.Write("X");
            }
        }
        /// <summary>
        /// prints star first depending on user input selection
        /// </summary>
        private void PutStarOnTop()
        {
            PrintBlanks(height-1);
            Console.Write("*\n");
        }
        /// <summary>
        /// prints trunk in the middle under the tree body
        /// </summary>
        private void PrintTrunk()
        {
                PrintBlanks(height-1);
                Console.Write("I\n\n");
        }
    }
}
