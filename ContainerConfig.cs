using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DIAutofac
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<RptRepository>().As<IRptRepository>();
            builder.RegisterType<RptService>().As<IRptService>();
            return builder.Build();
        }
    }
}
