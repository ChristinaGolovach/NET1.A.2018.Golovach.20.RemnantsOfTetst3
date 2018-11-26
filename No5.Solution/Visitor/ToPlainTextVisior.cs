namespace No5.Solution.Visitor
{
    public class ToPlainTextVisior : ConvertVisitor
    {
        protected override string Visit(BoldText boldText) => "**" + boldText.Text + "**";

        protected override string Visit(PlainText plainText) => plainText.Text;

        protected override string Visit(Hyperlink hyperlink) => hyperlink.Text + " [" + hyperlink.Url + "]";

    }
}
