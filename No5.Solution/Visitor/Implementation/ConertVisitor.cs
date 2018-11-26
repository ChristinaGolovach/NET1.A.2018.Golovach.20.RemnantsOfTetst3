using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No5.Solution.Visitor;


namespace No5.Solution
{
    public abstract class ConvertVisitor : IVisitor<DocumentPart, string>
    {
        public string DynamicVisit(DocumentPart documentPart) => Visit((dynamic)documentPart);

        protected abstract string Visit(BoldText boldText);
        protected abstract string Visit(PlainText plainText);
        protected abstract string Visit(Hyperlink hyperlink);
    }
}
