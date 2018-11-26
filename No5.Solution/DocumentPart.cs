using No5.Solution.Visitor;

namespace No5
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }
    }

    public static class DocumentExtension
    {
        public static string ToHtml(this DocumentPart documentPart)
        {
            IVisitor<DocumentPart, string> visitor = new ToHtmlVisitor();
            return visitor.DynamicVisit(documentPart);
        }

        public static string ToLaTexText(this DocumentPart documentPart)
        {
            IVisitor<DocumentPart, string> visitor = new ToLaTeXVisitor();
            return visitor.DynamicVisit(documentPart);
        }

        public static string ToPlainText(this DocumentPart documentPart)
        {
            IVisitor<DocumentPart, string> visitor = new ToPlainTextVisior();
            return visitor.DynamicVisit(documentPart);
        }
    }
}
