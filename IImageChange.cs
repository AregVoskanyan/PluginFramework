using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework
{
    public interface IImageChange
    {
        string Name { get; }

        void Apply(Image image, object parameter = null);
    }
}
