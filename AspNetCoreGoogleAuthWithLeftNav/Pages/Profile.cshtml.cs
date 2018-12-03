using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreGoogleAuthWithLeftNav.Pages
{
    public class ProfileModel : PageModel
    {
        public async Task OnGet(string returnUrl = "/")
        {
	        await HttpContext.ChallengeAsync("Google", new AuthenticationProperties() { RedirectUri = System.Net.WebUtility.UrlEncode(returnUrl) });
        }
		public async Task OnPostLogin(string returnUrl = "/")
	    {
		    await HttpContext.ChallengeAsync("Google", new AuthenticationProperties() { RedirectUri = returnUrl });
	    }

	}
}