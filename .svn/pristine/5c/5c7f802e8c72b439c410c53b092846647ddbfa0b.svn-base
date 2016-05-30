using System;
using System.Security.Cryptography;
using System.Text;

namespace SeenTechnology.Domain.Util
{
    public static class ExtendSecurity
    {
        private static RijndaelManaged GetRijndaelManaged(string secretKey)
        {
            var keyBytes = new byte[16];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
            return new RijndaelManaged { Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, KeySize = 128, BlockSize = 128, Key = keyBytes, IV = keyBytes };
        }

        private static byte[] Encrypt(byte[] plainBytes, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateEncryptor().TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        }

        private static byte[] Decrypt(byte[] encryptedData, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        }

        public static string Encrypt(this string plainText)
        {
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(Encrypt(plainBytes, GetRijndaelManaged(GetEncryptionKey())));

        }

        public static string Decrypt(this string encryptedText)
        {
            try
            {
                var encryptedBytes = Convert.FromBase64String(encryptedText);
                return Encoding.UTF8.GetString(Decrypt(encryptedBytes, GetRijndaelManaged(GetEncryptionKey())));
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public static string GetEncryptionKey()
        {
            return "FcrpMtddcVeeVVsF/siYF2hdieqlZ036286duMqV2x1nFYl+0OK2Jtxkitx4K9HN";
        }
    }
}
