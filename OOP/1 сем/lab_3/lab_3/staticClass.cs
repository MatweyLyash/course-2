using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace lab_3
{
    public static class staticClass
    {
       static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public int Diff(int[] arr)
        {
            return arr.Max()-arr.Min();
        }
        static public int Shchot(int[] arr) 
        {
            return arr.Length;
        }

        public static string EncryptString(this Lab_3.Set<string> set)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in set)
            {
                sb.Append(item);
            }

            string totalStr = sb.ToString();

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(totalStr));
                StringBuilder sb_2 = new StringBuilder();
                sb_2.Append(BitConverter.ToString(hashedBytes).Replace("-", ""));
                return sb_2.ToString();
            }
        }

    }
}
