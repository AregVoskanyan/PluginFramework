using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework
{
    public class Image
    {
        public string FileName { get;}
        public List<string> AppliedChanges { get; set; }

        public Image(string fileName)
        {
            FileName = fileName;
            AppliedChanges = new List<string>();
        }

        public override string ToString()
        {
            return $"Changes applied to {FileName}: {string.Join(",", AppliedChanges)}";
        }
    }
}
