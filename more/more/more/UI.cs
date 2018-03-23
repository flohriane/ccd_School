using System;

namespace more
{
    class UI
    {
        public void Ausgeben(Seite[] seiten)
        {
            for(var i=0; i<seiten.Length; i++){
                foreach(var z in seiten[i].Zeilen)
                    Console.WriteLine(z);

                if (i == seiten.Length-1) break;
                Console.WriteLine("---Press space to continue or ESC to quit---");
                var isEsc = Console.ReadKey(true).Key == ConsoleKey.Escape;
                if (isEsc) break;
            }
        }
    }
}