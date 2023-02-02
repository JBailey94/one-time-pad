using System.Xml.Serialization;

namespace otp
{
    public class Program
    {
        public static Dictionary<char, int> LetterMap;
        static void Main(string[] args)
        {
            using (Stream reader = new FileStream("crypto.xml", FileMode.Open))
            {
                Crypto? crypto = new XmlSerializer(typeof(Crypto)).Deserialize(reader) as Crypto;
                Console.WriteLine($"Plaintext: {crypto.PlainText}");
                Console.WriteLine($"Ciphertext: {crypto.CipherText}");
                Console.WriteLine($"DecryptedText: {crypto.DecryptText}"); 
            }       
        }
    }
}