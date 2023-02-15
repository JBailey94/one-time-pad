namespace otp
{
    public class Program
    {
        public static Dictionary<char, int> LetterMap;
        static void Main(string[] args)
        {
            Console.WriteLine("Encrypt or Decrypt? (e or d): ");
            ConsoleKeyInfo keyPress = Console.ReadKey();
            if (keyPress.Key == ConsoleKey.E)
            {
                Console.WriteLine();
                Console.WriteLine("Enter plain text to encrypt: ");
                string plainText = Console.ReadLine();
                Console.WriteLine("Enter key: ");
                string key = Console.ReadLine();
                Crypto crypto = new Crypto();
                Console.WriteLine("Encrypted text: " + crypto.Encrypt(plainText, key));
            }
            else if (keyPress.Key == ConsoleKey.D)
            {
                Console.WriteLine();
                Console.WriteLine("Enter ciphertext to decrypt: ");
                string cipherText = Console.ReadLine();
                Console.WriteLine("Enter key: ");
                string key = Console.ReadLine();
                Crypto crypto = new Crypto();
                Console.WriteLine("Decrypted text: " + crypto.Decrypt(cipherText, key));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}