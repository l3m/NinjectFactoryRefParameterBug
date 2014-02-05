using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace CompositionRoot
{
    public class DemoModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDemo>().To<Demo>();
            Bind<IDemoFactory>().ToFactory();
        }
    }
}
