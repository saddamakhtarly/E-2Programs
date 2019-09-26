using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {

            return word.Max(c => h[(int)c - 97]) * word.Length;
        }
        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
       ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
