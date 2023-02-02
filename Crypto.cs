using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace otp
{
    public class Crypto
    {
        public string PlainText { get; set; }
        public string Key { get; set; }
        [XmlIgnore]
        public string CipherText
        {
            get
            {
                List<int> keyNums = Key.Split(',').Select(item => int.Parse(item)).ToList();
                string cipherString = "";

                int index = 0;
                foreach (char c in PlainText)
                {
                    if (Char.IsLetter(c))
                    {
                        LetterMap.TryGetValue(Char.ToLower(c), out int newValue);
                        newValue += keyNums[index];

                        if (newValue >= 26)
                        {
                            newValue -= 26;
                        }

                        keyNums[index] = newValue;
                        char newKeyChar = LetterMap.FirstOrDefault(x => x.Value == newValue).Key;
                        cipherString += newKeyChar;
                        index++;
                    } 
                    else
                    {
                        cipherString += c;
                    } 

                }
                return cipherString;
            }
        }
        [XmlIgnore]
        public String DecryptText
        {
            get
            {
                List<int> keyNums = Key.Split(',').Select(item => int.Parse(item)).ToList();
                string decryptText = "";

                int index = 0;

                foreach (char c in CipherText)
                {
                    if (Char.IsLetter(c))
                    {
                        LetterMap.TryGetValue(Char.ToLower(c), out int newValue);
                        newValue -= keyNums[index];

                        if (newValue < 0)
                        {
                            newValue += 26;
                        }

                        keyNums[index] = newValue;
                        char newKeyChar = LetterMap.FirstOrDefault(x => x.Value == newValue).Key;
                        decryptText += newKeyChar;
                        index++;
                    }
                    else
                    {
                        decryptText += c;
                    }

                }
                return decryptText;
            }
        }
        [XmlIgnore]
        public Dictionary<char, int> LetterMap;

        public Crypto()
        {
            LetterMap = new Dictionary<char, int>();
            InitLetterMap();
        }
        
        /**
         * Initializes the letter map
         */
        private void InitLetterMap()
        {
            LetterMap = new Dictionary<char, int>();
            LetterMap.Add('a', 0);
            LetterMap.Add('b', 1);
            LetterMap.Add('c', 2);
            LetterMap.Add('d', 3);
            LetterMap.Add('e', 4);
            LetterMap.Add('f', 5);
            LetterMap.Add('g', 6);
            LetterMap.Add('h', 7);
            LetterMap.Add('i', 8);
            LetterMap.Add('j', 9);
            LetterMap.Add('k', 10);
            LetterMap.Add('l', 11);
            LetterMap.Add('m', 12);
            LetterMap.Add('n', 13);
            LetterMap.Add('o', 14);
            LetterMap.Add('p', 15);
            LetterMap.Add('q', 16);
            LetterMap.Add('r', 17);
            LetterMap.Add('s', 18);
            LetterMap.Add('t', 19);
            LetterMap.Add('u', 20);
            LetterMap.Add('v', 21);
            LetterMap.Add('w', 22);
            LetterMap.Add('x', 23);
            LetterMap.Add('y', 24);
            LetterMap.Add('z', 25);
        }
    }
}
