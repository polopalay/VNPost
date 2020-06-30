using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using VNPost.DataAccess.Repository.IRepository;

namespace VNPost.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        protected readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IdentityUser _identityUser = null;
        private IdentityRole _identityRole = null;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public IActionResult OnGet(string returnUrl = null)
        {
            if (!CheckAdmin())
            {
                return Forbid();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!CheckAdmin())
            {
                return Forbid();
            }
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(_identityUser.Email, _identityUser.PasswordHash, false, lockoutOnFailure: false);
                    return Redirect("/Admin/RegisterTypeUser");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }

        private bool CheckAdmin()
        {
            if (User != null)
            {
                if (_signInManager.IsSignedIn(User))
                {
                    _identityUser = _unitOfWork.IdentityUser.GetAll(filter: i => i.UserName == User.Identity.Name).ToList()[0];
                }
            }
            if (_identityUser != null)
            {
                if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id).ToList().Count() > 0)
                {
                    string roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id).ToList()[0].RoleId;
                    _identityRole = _unitOfWork.IdentityRole.Get(roleId);
                }
            }
            if (_identityRole == null)
            {
                return false;
            }
            else
            {
                if (_identityRole.Id != "13d23c51-re38-4831-wqa2-2e3f21c23ewd") return false;
                else return true;
            }
        }
    }
}
