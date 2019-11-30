using CoalescedAlgorithm.Business.Abstract;
using CoalescedAlgorithm.Business.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescedAlgorithm.Business.DependecyReselvor.Ninject
{
    public class FunctionModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IFunction>().To<Function>().InSingletonScope();

        }
    }
}
