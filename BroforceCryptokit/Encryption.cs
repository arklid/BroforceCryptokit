using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BroforceCryptokit
{
    static class Encryption
    {
        public static byte[] DecryptBlob(byte[] blob, string md5)
        {
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider
            {
                Key = Encoding.ASCII.GetBytes(md5.Substring(0, 8)),
                IV = new byte[] { 0x05, 0x02, 0xb1, 0x03, 0x01, 0x1c, 0x13, 0x45 }
            };
            return provider.CreateDecryptor().TransformFinalBlock(blob, 0, blob.Length);
        }

        public static byte[] EncryptBlob(byte[] blob, string md5)
        {
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider
            {
                Key = Encoding.ASCII.GetBytes(md5.Substring(0, 8)),
                IV = new byte[] { 0x05, 0x02, 0xb1, 0x03, 0x01, 0x1c, 0x13, 0x45 }
            };
            return provider.CreateEncryptor().TransformFinalBlock(blob, 0, blob.Length);
        }
    }
}
