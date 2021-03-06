﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace spellchecker
{
    public class Spellchecker
    {
        public static string[] Text_in_Wörter_zerlegen(string text)
        {
            var prüfwörter = text.Split(new [] {'.', ',', ';', '!', '?', ' ', '\t', '\n', '\r', '\b', '\v'}, StringSplitOptions.RemoveEmptyEntries);

            return prüfwörter;
        }

        public static List<string> Wörter_auf_Fehler_überprüfen(string[] wörter, HashSet<string> lexikon)
        {
            var fehlerliste = new List<string>();

            foreach (var wort in wörter)
                if (!lexikon.Contains(wort))
                    fehlerliste.Add(wort);

            return fehlerliste;
        }
    }
}
