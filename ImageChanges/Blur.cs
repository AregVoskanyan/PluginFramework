using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.ImageChanges
{
    public class Blur : IImageChange
    {
        public string Name => "Blur";
        public void Apply(Image image, object parameter = null)
        {
            image.AppliedChanges.Add($"{Name}({parameter})");
        }
    }
}
