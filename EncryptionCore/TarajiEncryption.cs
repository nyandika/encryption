using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionCore
{
    public class TarajiEncryption
    {
        //Ideally to pass a parameter in this method to specify the algorithm.
        //Using only one algorithm right now, i.e AES
        public ICrypto MakeCryptographer()
        {
            //Redirect to the specified algorithm, the only one currently
            return new TarajiAlgorithm();
        }

        public interface ICrypto
        {
            string Decrypt(string encryptedString);
            string Encrypt(string plainString);
        }

        public class TarajiAlgorithm : ICrypto
        {
            // Fields
            private byte[] _iv = new byte[] { 0x53, 0x47, 0x1a, 0x3a, 0x36, 0x23, 0x16, 11, 0x53, 0x47, 0x1a, 0x3a, 0x36, 0x23, 0x16, 11 };
            private byte[] _key = new byte[] { 0x84, 0x2a, 0x35, 0x7c, 0x4b, 0x38, 0x57, 0x26, 9, 10, 0xa1, 0x84, 0xb7, 0x5b, 0x69, 0x10,
            0x75, 0xda, 0x95, 230, 0xdd, 0xd4, 0xeb, 0x40
        };

            public string Decrypt(string encryptedString)
            {
                string plainString;
                try
                {
                    byte[] buffer = Convert.FromBase64String(encryptedString);
                    MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length);
                    var managed = Aes.Create();
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, managed.CreateDecryptor(_key, _iv), CryptoStreamMode.Read);
                    plainString = new StreamReader(cryptoStream).ReadToEnd();
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                return plainString;
            }

            public string Encrypt(string plainWord)
            {
                string encryptedWord;
                try
                {
                    byte[] bytes = new UTF8Encoding().GetBytes(plainWord);
                    MemoryStream memoryStream = new MemoryStream();
                    var managed = Aes.Create();
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, managed.CreateEncryptor(_key, _iv), CryptoStreamMode.Write);
                    cryptoStream.Write(bytes, 0, bytes.Length);
                    cryptoStream.FlushFinalBlock();
                    ArraySegment<byte> buffer = new ArraySegment<byte>();
                    memoryStream.TryGetBuffer(out buffer);
                    byte[] bufferArray = buffer.ToArray();
                    encryptedWord = Convert.ToBase64String(bufferArray, 0, Convert.ToInt32(memoryStream.Length.ToString()));
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                return encryptedWord;
            }
        }
    }
}
