namespace No5.Solution.Visitor
{
    public class ToHtmlVisitor : ConvertVisitor
    {
        protected override string Visit(BoldText boldText)  => "<b>" + boldText.Text + "</b>";

        protected override string Visit(PlainText plainText) => plainText.Text;

        protected override string Visit(Hyperlink hyperlink) => "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";

    }
}
