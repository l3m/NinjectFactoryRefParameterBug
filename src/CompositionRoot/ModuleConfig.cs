using System.Linq;
using Library;
using Ninject;
using Ninject.Modules;

namespace CompositionRoot
{
    public class ModuleConfig
    {
        private static IKernel _kernel;

        static ModuleConfig()
        {
            _kernel = new StandardKernel(new INinjectModule[] {new DemoModule()});
        }

        public IDemoFactory Root
        {
            get { return _kernel.Get<IDemoFactory>(); }
        }
    }
}