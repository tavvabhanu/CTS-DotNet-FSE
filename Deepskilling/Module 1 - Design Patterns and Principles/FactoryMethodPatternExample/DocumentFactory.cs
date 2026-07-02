namespace FactoryMethodPatternExample
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();

        public void OpenDocument()
        {
            IDocument document = CreateDocument();
            document.Open();
        }
    }
}