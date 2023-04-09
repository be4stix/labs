using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Lab3._2ASD
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\ASD.Labs\Lab3.2ASD\Lab3.2ASD\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\ASD.Labs\Lab3.2ASD\Lab3.2ASD\outlet.txt";
            StreamWriter output = new StreamWriter(fout);

            String text = File.ReadAllText(fin);

            HashSet<char> zvon = new HashSet<char>() { 'б', 'Б', 'в', 'В', 'г', 'Г', 'д', 'Д', 'ж', 'Ж', 'з', 'З', 'л', 'Л', 'м', 'М', 'н', 'Н', 'й', 'Й', 'р', 'Р' };
            HashSet<char> glux = new HashSet<char>() { 'п', 'П', 'ф', 'Ф', 'к', 'К', 'т', 'Т', 'ш', 'Ш', 'с', 'С', 'ч', 'Ч', 'щ', 'Щ', 'х', 'Х', 'ц', 'Ц' };

            HashSet<char> zvonInText = new HashSet<char>();
            HashSet<char> gluxNotInAll = new HashSet<char>();
            HashSet<char> gluxInFirst = new HashSet<char>();

            String[] words = text.Split(',', '.');

            char[] word0 = words[0].ToCharArray();
            for (int i = 0; i < word0.Length; i++)
            {
                if (glux.Contains(word0[i]))
                {
                    gluxInFirst.Add(word0[i]);
                }
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                HashSet<char> gluxInWord = new HashSet<char>();
                char[] word = words[i].ToCharArray();
                for (int j = 0; j < word.Length; j++)
                {
                    if (zvon.Contains(word[j]))
                    {
                        zvonInText.Add(word[j]);
                    }
                    if (glux.Contains(word[j]))
                    {
                        glux.Remove(word[j]);
                        // gluxInWord.Add(word[j]);
                    }
                }
                /*
                                if (gluxInFirst.Count > gluxInWord.Count)
                                {
                                    foreach (char s in gluxInFirst.Except(gluxInWord))
                                    {
                                        gluxNotInAll.Add(s);
                                    }
                                }
                                else if (gluxInFirst.Count < gluxInWord.Count)
                                {
                                    foreach (char s in gluxInWord.Except(gluxInFirst))
                                    {
                                        gluxNotInAll.Add(s);
                                    }
                                }

                            }
                             */
                foreach (char s in glux)
                {
                    output.Write(s.ToString() + ' ');
                }
                output.WriteLine();
                foreach (char s in zvonInText)
                {
                    output.Write(s.ToString() + ' ');
                }
                output.Close();
            }
        }
    }
}
