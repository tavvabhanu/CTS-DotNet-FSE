using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            wordFactory.OpenDocument();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            pdfFactory.OpenDocument();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            excelFactory.OpenDocument();

            Console.ReadLine();
        }
    }
}