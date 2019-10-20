using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace smurfis.util
{
    public class HashPassword
    {
        private byte[] salted;
        private String Hash;

        public HashPassword() { }
        public HashPassword(String Password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            salted = salt;

            Hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
             password: Password,
salt: salt,
prf: KeyDerivationPrf.HMACSHA1,
iterationCount: 10000,
numBytesRequested: 256 / 8));
        }

        public Boolean isPasswordValid(String Password, byte[] salt, String SaltedHash)
        {
            String pass = Convert.ToBase64String(KeyDerivation.Pbkdf2(
    password: Password,
   salt: salt,
   prf: KeyDerivationPrf.HMACSHA1,
   iterationCount: 10000,
   numBytesRequested: 256 / 8));

            if (pass.Equals(SaltedHash))
                return true;

            return false;
        }

        public byte[] getSalted()
        {
            return salted;
        }
        public String getHash()
        {
            return Hash;
        }



    }




}