using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AweCoreDemo.Models;
using DemoHms;
using DemoHms.Areas.Identity.Pages.Account;
using DemoHms.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AweCoreDemo.Pages.HospitalEntity.Users
{
    public class EditUserModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public EditUserModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, ApplicationDbContext context)
        {
            userManager.Options.SignIn.RequireConfirmedAccount = false;
            userManager.Options.SignIn.RequireConfirmedEmail = false;
            userManager.Options.SignIn.RequireConfirmedPhoneNumber = false;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            this._context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public bool IsPasswordReset { get; set; }
        }
        public bool IsPasswordReset { get; set; }
        [BindProperty]
        public ApplicationUser AppUser { get; set; }
        public async Task OnGetAsync(string id, bool isPasswordReset)
        {
           Db.IsPasswordReset = IsPasswordReset = isPasswordReset;
            ApplicationUser = AppUser = await _context.AppUsers
               .Include(h => h.EmployeeGroup)
                .Include(h => h.Hospital)
               .Include(h => h.Department)
               .Include(h => h.Department.Branch).FirstOrDefaultAsync(A => A.Id == id);

            ViewData["EmployeeGroupID"] = new SelectList(_context.EmployeeGroups, "EmployeeGroupID", "Name");
            ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "Name");
            ViewData["HospitalId"] = new SelectList(_context.Hospitals, "HospitalID", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _context.AppUsers.Include(a => a.EmployeeGroup).FirstOrDefaultAsync(A=>A.Id.Equals(ApplicationUser.Id));
            var loggeduser = await _context.AppUsers.Include(a => a.EmployeeGroup).FirstOrDefaultAsync(U => U.Email.Equals(User.Identity.Name));
            var group = loggeduser.EmployeeGroup;
            var permissions = await _context.Permissions.Include(a => a.Activity).Include(a => a.EmployeeGroup).Where(p => p.EmployeeGroupID == group.EmployeeGroupID).ToListAsync();

            user.FirstName = ApplicationUser.FirstName;
            user.LastName = ApplicationUser.LastName;
            user.HospitalId = ApplicationUser.HospitalId;
            if (permissions.FirstOrDefault(P => P.Activity.Name == "Employee Data" && P.CanEdit) != null || group.Name.Equals("Root"))
            {
                user.EmployeeGroupID = ApplicationUser.EmployeeGroupID;
                user.DepartmentID = ApplicationUser.DepartmentID;
            }
            if(loggeduser.Id == ApplicationUser.Id && Db.IsPasswordReset)
            {
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var Code=Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
                var result2 = await _userManager.ResetPasswordAsync(user, Code, Input.Password);
                Db.IsPasswordReset = false;
            }

            var result = await _userManager.UpdateAsync(user);
              
            if (result.Succeeded )
            {
                if(Db.IsPasswordReset)
                {
                    await _signInManager.SignOutAsync();
                    return LocalRedirect("/?page=%2F");
                }
                return Page();
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}