using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public class Generator : IGenerator
    {
        private Document _document;

        public Generator()
        {
            Reset();
        }

        public void Reset() => _document = new Document();

        public void SetCase(TypeChar typeChar) => _document.Case = typeChar;

        public void SetContent(List<string> content) => _document.Content = content;

        public void SetFormat(TypeDoc typeDoc) => _document.Format = typeDoc;

        public void SetPath(string path) => _document.Path = path;

        public Document GetDocument() => _document;
    }
}
