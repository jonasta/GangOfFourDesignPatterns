using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Document
    {
        protected Document()
        {
            CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();

        public abstract void CreatePages();
    }
}