using Functions.Abstract;
using Functions.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions.DependecyReselvor.Ninject
{
    public class FunctionsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFunction>().To<Function>().InSingletonScope();
            
        }
    }
}
