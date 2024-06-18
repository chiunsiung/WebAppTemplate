using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace DAL
{


    public class clsHSM
    {
        private static TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();
        private static string secrekey = "IVD88!";
        private static byte[] TruncateHash(string key, int length)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            // Hash the key.
            byte[] keyBytes = System.Text.Encoding.Unicode.GetBytes(key);
            byte[] hash = sha1.ComputeHash(keyBytes);
            var oldHash = hash;
            hash = new byte[length - 1 + 1];

            // Truncate or pad the hash.
            if (oldHash != null)
                Array.Copy(oldHash, hash, Math.Min(length - 1 + 1, oldHash.Length));
            return hash;
        }
        public static string DecryptData(string encryptedtext)
        {
            // Convert the encrypted text string to a byte array.
            TripleDes.Key = TruncateHash(secrekey, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
            byte[] encryptedBytes = Convert.FromBase64String(encryptedtext);

            // Create the stream.
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Create the decoder to write to the stream.
            CryptoStream decStream = new CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write);

            // Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            decStream.FlushFinalBlock();

            // Convert the plaintext stream to a string.
            return System.Text.Encoding.Unicode.GetString(ms.ToArray());
        }
        public static string EncryptData(string plaintext)
        {
            TripleDes.Key = TruncateHash(secrekey, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
            // Convert the plaintext string to a byte array.
            byte[] plaintextBytes = System.Text.Encoding.Unicode.GetBytes(plaintext);

            // Create the stream.
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Create the encoder to write to the stream.
            CryptoStream encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);

            // Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
            encStream.FlushFinalBlock();

            // Convert the encrypted stream to a printable string.
            return Convert.ToBase64String(ms.ToArray());
        }

        public static bool ValidatePassword( string pinBlock, string userPassword)
        {
            if ((pinBlock == EncryptData(userPassword)))
                // Compare the pin block
                return true;
            else
                return false;
        }

        public static string EncryptPassword(string newPassword)
        {
            return EncryptData(newPassword);
        }

        public static bool GeneratePassword( ref string PinBlock, ref string PIN)
        {
            PIN = "";
            PinBlock = "";
            // Dim randomNumber As Integer

            Random RandomClass = new Random();
            HashSet<int> RememberSet = new HashSet<int>();

            int RandomNumber;

            while (RememberSet.Count < 4)
            {
                RandomNumber = RandomClass.Next(0, 10);
                RememberSet.Add(RandomNumber);
            }
            PIN = string.Join("", RememberSet.ToArray());
            PinBlock = EncryptData(PIN);
            return true;
        }
    }

}
