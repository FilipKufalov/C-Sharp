using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Methods
    {
        public char[] Encrypt(string param)
        {
            char[] proc;
            proc = param.ToCharArray();
            char[] encryptedData = new char[proc.Length];
            for (int i = 0; i < proc.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int data = proc[i] + 10;
                    encryptedData[i] = (char)data;
                }
                else if (i % 3 == 0)
                {
                    int data = proc[i] + 5;
                    encryptedData[i] = (char)data;
                }
                else
                {
                    int data = proc[i] + 3;
                    encryptedData[i] = (char)data;
                }
            }
            return encryptedData;
        }

        public char[] Decrypt(string param)
        {
            char[] proc;
            proc = param.ToCharArray();
            char[] deEncryptedData = new char[proc.Length];
            for (int i = 0; i < proc.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int data = proc[i] - 10;
                    deEncryptedData[i] = (char)data;
                }
                else if (i % 3 == 0)
                {
                    int data = proc[i] - 5;
                    deEncryptedData[i] = (char)data;
                }
                else
                {
                    int data = proc[i] - 3;
                    deEncryptedData[i] = (char)data;
                }
            }
            return deEncryptedData;
        }
    }
}
