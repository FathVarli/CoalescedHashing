using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescedAlgorithm.Business.DependecyReselvor.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new FunctionModule());
            return kernel.Get<T>();
        }
    }
}
