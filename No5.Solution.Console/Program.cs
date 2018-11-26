using System;
using System.Collections.Generic;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentPart boldText = new BoldText() { Text = "Test Visitor pattern" };
            DocumentPart plainText = new PlainText() { Text = "Test" };
            DocumentPart hyperLink = new Hyperlink() { Text = "Huperlink", Url = @"http://en.wikipedia.org" };

            IEnumerable<DocumentPart> documentPart = new List<DocumentPart>() { boldText, plainText, hyperLink };

            foreach(var item in documentPart)
            {
                System.Console.WriteLine(item.ToHtml()); 
            }

            System.Console.WriteLine(Environment.NewLine);

            foreach (var item in documentPart)
            {
                System.Console.WriteLine(item.ToLaTexText());
            }

            System.Console.WriteLine(Environment.NewLine);

            foreach (var item in documentPart)
            {
                System.Console.WriteLine(item.ToPlainText());
            }

            System.Console.ReadLine();
        }
    }
}
