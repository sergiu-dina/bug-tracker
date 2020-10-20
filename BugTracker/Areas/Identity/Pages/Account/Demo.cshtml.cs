using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BugTracker.Areas.Identity.Pages.Account
{
    public class DemoModel : PageModel
    {
        private readonly UserManager<BugTrackerUser> _userManager;
        private readonly SignInManager<BugTrackerUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public DemoModel(SignInManager<BugTrackerUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<BugTrackerUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]

        public InputModel Input1 { get; set; } = new InputModel();
        public InputModel Input2 { get; set; } = new InputModel()
        {
            Email = "manager@demo.com",
            Password = "manager1",
            RememberMe=false
        };
        public InputModel Input3 { get; set; } = new InputModel()
        {
            Email = "developer@demo.com",
            Password = "developer1",
            RememberMe=true
        };
        public InputModel Input4 { get; set; } = new InputModel()
        {
            Email = "submitter@demo.com",
            Password = "submitter1",
            RememberMe=false
        };
        public List<InputModel> Inputs { get; set; } = new List<InputModel>
        {
            new InputModel()
            {
                Email = "admin@demo.com",
                Password = "admin1",
                RememberMe=true
            },
            new InputModel()
            {
                Email = "manager@demo.com",
                Password = "manager1"
            },
            new InputModel()
            {
                Email = "developer@demo.com",
                Password = "developer1"
            },
            new InputModel()
            {
                Email = "submitter@demo.com",
                Password = "submitter1"
            }
        };

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; } = "admin@demo.com";

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = "admin1";

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; } = false;
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("/");
            }
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            foreach(var input in Inputs)
            {
                int i = 0;
            }
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true 
                for(int i=0;i<Inputs.Count;i++)
                {
                    if (Inputs[i].RememberMe == true)
                    {
                        var result = await _signInManager.PasswordSignInAsync(Inputs[i].Email, Inputs[i].Password, Inputs[i].RememberMe, lockoutOnFailure: false);
                        if (result.Succeeded)
                        {
                            _logger.LogInformation("User logged in.");
                            return LocalRedirect(returnUrl);
                        }
                        if (result.RequiresTwoFactor)
                        {
                            return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Inputs[i].RememberMe });
                        }
                        if (result.IsLockedOut)
                        {
                            _logger.LogWarning("User account locked out.");
                            return RedirectToPage("./Lockout");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                            return Page();
                        }
                    }
                }
            }
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
