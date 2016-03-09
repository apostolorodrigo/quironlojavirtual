using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo
{
    public class AdministrativoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administrativo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administrativo_default",
                "Administrativo/{controller}/{action}/{id}",
                new { Controller="Produto", action = "Index", id = UrlParameter.Optional },
                //serve para diferenciar os namespace, se NÂO colocar dessa forma,
                //posso ter problema com o mesmo no de controller por ex do projeto principal
                new [] { "Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers" }
            );
        }
    }
}