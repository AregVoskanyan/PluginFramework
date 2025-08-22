using PluginFramework.ImageChanges;

namespace PluginFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var handler = new PluginHandler();

            handler.Register(new Resize());
            handler.Register(new Blur());
            handler.Register(new Grayscale());

            var img1 = new Image("Image#1");
            var img2 = new Image("Image#2");
            var img3 = new Image("Image#3");

            //examples from the task
            handler.Apply("Resize", img1, 100);
            handler.Apply("Blur", img1, 2);

            handler.Apply("Resize", img2, 100);

            handler.Apply("Resize", img3, 150);
            handler.Apply("Blur", img3, 5);
            handler.Apply("Grayscale", img3);

            Console.WriteLine(img1);
            Console.WriteLine(img2);    
            Console.WriteLine(img3);

        }
    }
}
