using System;
using System.Collections.Generic;
using System.Text;
using Spire.Pdf;
using Spire.Pdf.Exporting.Text;

namespace ExtractImageText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> _contentList = new List<string>();
            //create a pdf document
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"D:\Repos\Temp\DotNet\ConsoleApp\Notas\NotaNegociacao_379057_20200831.pdf");

            StringBuilder buffer = new StringBuilder();

            SimpleTextExtractionStrategy strategy = new SimpleTextExtractionStrategy();



            foreach (PdfPageBase page in doc.Pages)
            {
                System.Console.WriteLine(page.ExtractText());
                var texts = page.FindAllText();
                texts = page.
                var word = page.FindText("Data pregão");
                // foreach (char line in page.ExtractText(strategy))
                // {
                //       System.Console.WriteLine(line);  
                //       _contentList.Add(line);   
                // }

                // System.Console.WriteLine(page.ExtractText(strategy).IndexOf("Data pregão"));
                // int indexDataPregaoValor = page.ExtractText(strategy).IndexOf("Data pregão") + 1;
                // System.Console.WriteLine(page.ExtractText(strategy).Ind);
                System.Console.WriteLine(word.Finds[0].SearchText);
                System.Console.WriteLine(texts.ToString());
            }



            // var index = _contentList.FindIndex(e => e == "                                                                                                                             Nr. nota     Folha       Data pregão") + 1;
            // int.TryParse(_contentList[index], out var value);
            // Console.WriteLine(value);

            // doc.Close();

            //print text
            // System.Console.WriteLine(buffer.ToString());

        }
    }
}