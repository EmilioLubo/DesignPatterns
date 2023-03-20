using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public class Document
    {
        public List<string> Content { get; set; }
        public string Path { get; set; }
        public TypeDoc Format { get; set; }
        public TypeChar Case { get; set; }


        public void Save()
        {
            string result = "";
            result = Format == TypeDoc.Json ? GetJson() : GetPipe();
            
            if (Case == TypeChar.Uppercase)
                result = result.ToUpper();
            if (Case == TypeChar.Lowercase)
                result = result.ToLower();

            File.WriteAllText(Path, result);
        }

        private string GetJson() => JsonSerializer.Serialize(Content);
        private string GetPipe() => Content.Aggregate((acc, el) => acc + "|" + el);
    }
}
