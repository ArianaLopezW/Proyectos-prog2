using System;
using System.Collections.Generic;

namespace morse
{
    public class Program
    {
        public static Dictionary<char, string> morseAlphabetDic;
        static void Main (string[] args)
        {
            const int dot = 250;
            const int dash = dot * 3;

            morseAlphabetDic = new Dictionary<char, string>()
            {
                 {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };
            String word;
            char letters;
            try
            {
        for (int i = 0; i < args.Length; i++)
        {
            word = args[i].ToUpper();
            Console.WriteLine(word);
            for (int j = 0; j < word.Length; j++)
            {
                try {
                letters = word[j];
                Console.Write(morseAlphabetDic[letters]);

                foreach (var ch in morseAlphabetDic[letters]){
                    if (ch == '.'){
                        Console.Beep(550, dot);
                        }
                        else
                        {
                            Console.Beep(550, dash);
                        }
                        System.Threading.Thread.Sleep(dot * 7);
                
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            System.Threading.Thread.Sleep(dot * 7);
        }
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
