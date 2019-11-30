using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions.DependecyReselvor.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new FunctionsModule());
            return kernel.Get<T>();
        }
    }
}
