﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Стомотология
{
    internal class PasswordHash
    {
        private const int SALT_LENGTH = 24;
        private const int DERIVED_KEY_LENGTH = 24;

        public static string CreatePasswordHash(string password, int iterationCount = 15013)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));

            byte[] salt = GenerateRandomSalt(SALT_LENGTH);
            byte[] hashValue = GenerateHashValue(password, salt, iterationCount);
            byte[] iterationCountByteArr = BitConverter.GetBytes(iterationCount);
            var valueToSave = new byte[SALT_LENGTH + DERIVED_KEY_LENGTH + iterationCountByteArr.Length];
            Buffer.BlockCopy(salt, 0, valueToSave, 0, SALT_LENGTH);
            Buffer.BlockCopy(hashValue, 0, valueToSave, SALT_LENGTH, DERIVED_KEY_LENGTH);
            Buffer.BlockCopy(iterationCountByteArr, 0, valueToSave, salt.Length + hashValue.Length, iterationCountByteArr.Length);
            return Convert.ToBase64String(valueToSave);
        }

        private static byte[] GenerateRandomSalt(int saltLength)
        {
            using (var csprng = new RNGCryptoServiceProvider())
            {
                var salt = new byte[saltLength];
                csprng.GetBytes(salt);
                return salt;
            }
        }

        private static byte[] GenerateHashValue(string password, byte[] salt, int iterationCount)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterationCount))
            {
                return pbkdf2.GetBytes(DERIVED_KEY_LENGTH);
            }
        }

        public static bool VerifyPassword(string passwordGuess, string passwordHash)
        {
            //интеграция обычного пароля в хешированный
            var salt = new byte[SALT_LENGTH];

            //интеграция хеширования в пароль
            var actualPasswordByteArr = new byte[DERIVED_KEY_LENGTH];

            //конверт
            byte[] actualSavedHashResultsBtyeArr = Convert.FromBase64String(passwordHash);

            //реализация
            int iterationCountLength = actualSavedHashResultsBtyeArr.Length - (salt.Length + actualPasswordByteArr.Length);
            byte[] iterationCountByteArr = new byte[iterationCountLength];
            Buffer.BlockCopy(actualSavedHashResultsBtyeArr, 0, salt, 0, SALT_LENGTH);
            Buffer.BlockCopy(actualSavedHashResultsBtyeArr, SALT_LENGTH, actualPasswordByteArr, 0, actualPasswordByteArr.Length);
            Buffer.BlockCopy(actualSavedHashResultsBtyeArr, (salt.Length + actualPasswordByteArr.Length), iterationCountByteArr, 0, iterationCountLength);
            byte[] passwordGuessByteArr = GenerateHashValue(passwordGuess, salt, BitConverter.ToInt32(iterationCountByteArr, 0));
            return ConstantTimeComparison(passwordGuessByteArr, actualPasswordByteArr);
        }

        private static bool ConstantTimeComparison(byte[] passwordGuess, byte[] actualPassword)
        {
            uint difference = (uint)passwordGuess.Length ^ (uint)actualPassword.Length;
            for (var i = 0; i < passwordGuess.Length && i < actualPassword.Length; i++)
            {
                difference |= (uint)(passwordGuess[i] ^ actualPassword[i]);
            }

            return difference == 0;
        }

        internal static bool VerifyPassword(string password, object passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}
