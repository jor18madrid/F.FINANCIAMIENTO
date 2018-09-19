using Autofac;
using Autofac.Integration.Mvc;
using F.FINANCIAMIENTO.INTERFACES;
using F.FINANCIAMIENTO.WEB.Modules;
using System.Web.Mvc;

namespace F.FINANCIAMIENTO.WEB.App_Start
{
    public class AutoFacConfig
    {
        public static void RegisterConfig()
        {
            var builder = new ContainerBuilder();
            //Se registran los Controladores 
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule(new ServiceModule<ISAS_GRUPO_FILTRO_INTERFACE>("BasicHttpBinding_F_FINANCIAMIENTO"));
            //    builder.RegisterModule(new ServiceModule<INTERFACES.ISAS_Origen_Destino_INTERFACE>("BasicHttpBinding_SasTools"));

            //         builder.RegisterModule(new ServiceModule<INTERFACES.ITGR1_RECIBO_DETALLES_INTERFACE>("BasicHttpBinding_SasTools"));//nuevo
            //opcional
            //OpcionalRegister(builter)
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        public static void OpcionalRegister(ContainerBuilder builder)
        {
            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();
        }
    }
}