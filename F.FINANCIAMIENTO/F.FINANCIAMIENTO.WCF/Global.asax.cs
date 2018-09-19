using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Linq;
using System.Reflection;

namespace F.FINANCIAMIENTO.WCF
{
    public class MvcApplication : System.Web.HttpApplication
    {

    protected void Application_Start(object sender, EventArgs e)
    {
     
            var builder = new ContainerBuilder();
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).Where(a => a.Namespace.EndsWith("RDN"));
            builder.RegisterAssemblyTypes(assembly).Where(a => a.Namespace.EndsWith("SVC"));
            AutofacHostFactory.Container = builder.Build();
        }
    }
}
