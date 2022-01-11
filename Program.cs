using System;
using System.Data;
using Autofac;

namespace DIAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new();
            DataSet dataSet1 = new();

            //var build=new ConfigurationBuilder()

            var container = ContainerConfig.Configure();
            using(var scope=container.BeginLifetimeScope())
            {
                var svc = scope.Resolve<IRptService>();
                dataSet = svc.Write("Test", "Test");
                var svc1 = scope.Resolve<IRptRepository>();
                dataSet1 = svc1.Writedata("test", "test");
            }
        }
    }
}
