using CompositionRoot;

namespace njfbug
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new ModuleConfig();
            var df = mc.Root;

            int x = 1;
            var demo = df.CreateDemo(ref x);
        }
    }
}
