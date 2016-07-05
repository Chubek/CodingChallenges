using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beale_s_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string myCipher = "";

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            using (System.IO.Stream myStream = myAssembly.GetManifestResourceStream("BealesCipher.Cipher.txt"))
            {
                using (System.IO.StreamReader myStreamReader = new System.IO.StreamReader(myStream))
                {
                    myCipher = myStreamReader.ReadToEnd();
                }
            }

            Console.WriteLine(DeCypher(myCipher));
            Console.ReadKey();
        }

        static string DeCypher(string cipher)
        {
            string DoI = "";
            string DeCypher = "";

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
           

            using (System.IO.Stream myStream = myAssembly.GetManifestResourceStream("BealesCipher.DoI.txt"))
            {
                using (System.IO.StreamReader myStreamReader = new System.IO.StreamReader(myStream))
                {
                    DoI = myStreamReader.ReadToEnd();
                }
            }
            

            char[] emptySpace = { ' ' };
            char[] commaAndEmptySpace = { ',', ' ' };

            string[] DoISplit = DoI.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries);
            string[] CipherSplit = cipher.Split(commaAndEmptySpace, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < CipherSplit.Length; i++)
            {
                string word = DoISplit[int.Parse(CipherSplit[i]) - 1];
                char[] wordChars = word.ToCharArray();

                DeCypher += wordChars[0].ToString();
            }

            return DeCypher;

        }

       

    }
}
