﻿using Encryption;
using System;
using static Encryption.TarajiEncryption;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the encryption class
            TarajiEncryption encryption = new TarajiEncryption();
            var cryptographer = encryption.MakeCryptographer();

            string encryptedString = cryptographer.Encrypt("stringorpasswordtoencrypt");
            string plainString = cryptographer.Decrypt("IwUXysKfykPHGBOXUEiPwKzim1CUz53m26JDZGLghBs=");

            Console.WriteLine(encryptedString);
            Console.WriteLine(plainString);
            Console.ReadLine();
        }
    }
}
