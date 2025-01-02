using Microsoft.AspNetCore.Mvc;

namespace E_CommerceUI.ViewComponents.AdminDashboard
{
	public class _NavbarComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
