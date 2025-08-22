using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework
{
    public class PluginHandler
    {

        private readonly Dictionary<string, IImageChange> _plugins = new();

        public void Register(IImageChange plugin)
        {
            _plugins[plugin.Name] = plugin;
        }

        public void Apply(string pluginName, Image image, object parameter = null)
        {
            if(_plugins.TryGetValue(pluginName, out var plugin))
            {
                plugin.Apply(image, parameter);
            }
            else
            {
                Console.WriteLine($"Plugin {pluginName} not found.");
            }
        }
    }
}
