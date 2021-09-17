using System;
using System.Collections.Generic;
using System.Text;

namespace Buchstabenkiste
{
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Geben sie ihren Zeichenpool ein: ");
            String zpool = Console.ReadLine().ToLower();
            Dictionary<char, int> dict1 = machdictionary(zpool);



            Console.WriteLine("Geben sie ihre Suche ein: ");
            String wort = Console.ReadLine().ToLower();
            Dictionary<char, int> dict2 = machdictionary(wort);



            foreach (char key in dict2.Keys) // dict.Keys returns [a, b, c, d]-array for a word aabcccdddd
            {
                if (!(dict1.ContainsKey(key) && dict1[key] >= dict2[key])) // dict1[key] and dict2[key] return values (each value IS amount of numbers) for each key of the dictionary (each key IS a letter that we have in the word / in the stones collection)
                {
                    Console.WriteLine("Kann nicht gebildet werden!");
                    return;
                }
            }
            Console.WriteLine("Kann gebildet werden!");
        }
        public Dictionary<char, int> machdictionary(String s)
        {
            List<char> pool = new List<char>(s.ToCharArray());
            Dictionary<char, int> zeichen = new Dictionary<char, int>();
            for (int i = 0; i < pool.Count; i++)
            {
                zeichen[pool[i]] = zeichen.GetValueOrDefault(pool[i], 0) + 1;
            }
            return zeichen;
        }
    }
}

// For a word FULFILLMENT the KEY: VALUE pairs of the char/int dictionary look like: F: 2, U: 1, L: 3, I: 1, M: 1, N: 1, T: 1