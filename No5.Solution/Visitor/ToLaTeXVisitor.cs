namespace No5.Solution.Visitor
{
    public class ToLaTeXVisitor : ConvertVisitor
    {
        protected override string Visit(BoldText boldText) => "\\textbf{" + boldText.Text + "}";

        protected override string Visit(PlainText plainText) => plainText.Text;

        protected override string Visit(Hyperlink hyperlink) => "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";

    }
}
