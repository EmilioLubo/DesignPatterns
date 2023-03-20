using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public enum TypeDoc
    {
        Json,
        Pipes
    }
    public enum TypeChar
    {
        Normal,
        Uppercase,
        Lowercase
    }
    public interface IGenerator
    {
        public void Reset();
        public void SetContent(List<string> content);
        public void SetPath(string path);
        public void SetFormat(TypeDoc typeDoc);
        public void SetCase(TypeChar typeChar = TypeChar.Normal);
    }
}
