using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public class DocGenerator
    {
        private IGenerator _generator;

        public DocGenerator(IGenerator generator) => SetGenerator(generator);

        public void SetGenerator(IGenerator generator) => _generator = generator;

        public void CreateSimpleJsonGenerator(List<string> content, string path)
        {
            _generator.Reset();
            _generator.SetContent(content);
            _generator.SetPath(path);
            _generator.SetFormat(TypeDoc.Json);
        }

        public void CreateSimplePipeGenerator(List<string> content, string path)
        {
            _generator.Reset();
            _generator.SetContent(content);
            _generator.SetPath(path);
            _generator.SetFormat(TypeDoc.Pipes);
            _generator.SetCase(TypeChar.Uppercase);
        }

    }
}
