using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.ImageChanges
{
    public class Resize : IImageChange
    {
        public string Name => "Resize";
        public void Apply(Image image, object parameter = null)
        {
            image.AppliedChanges.Add($"{Name}({parameter})");
        }
    }
}
