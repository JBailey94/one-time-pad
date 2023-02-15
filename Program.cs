namespace otp
{
    public class Program
    {
        public static Dictionary<char, int> LetterMap;
        static void Main(string[] args)
        {

            ConsoleKeyInfo keyPress;
            do
            {
                Console.WriteLine("Choose an option!");
                Console.WriteLine("Press E to Encrypt\nPress D to Decrypt \nPress Q to Quit:");
                
                keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.E)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter plain text to encrypt: ");
                    string plainText = Console.ReadLine();
                    Console.WriteLine("Enter key: ");
                    string key = Console.ReadLine();
                    Crypto crypto = new Crypto();
                    Console.WriteLine("Encrypted text: \n" + crypto.Encrypt(plainText, key));
                }
                else if (keyPress.Key == ConsoleKey.D)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter ciphertext to decrypt: ");
                    string cipherText = Console.ReadLine();
                    Console.WriteLine("Enter key: ");
                    string key = Console.ReadLine();
                    Crypto crypto = new Crypto();
                    Console.WriteLine("Decrypted text: \n" + crypto.Decrypt(cipherText, key));
                }
                else if (keyPress.Key == ConsoleKey.Q)
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            } while (keyPress.Key != ConsoleKey.Q);
        }
    }
}