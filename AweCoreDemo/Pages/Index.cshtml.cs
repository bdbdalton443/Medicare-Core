using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using DemoHms;
using DemoHms.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AweRazorPages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<IndexModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public IndexModel(SignInManager<ApplicationUser> signInManager,
            ILogger<IndexModel> logger,
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }
            InitializeDatabase();
            returnUrl = returnUrl ?? Url.Content("~/");
            if (await _userManager.FindByEmailAsync("bdbdalton443@gmail.com") == null)
            {
                var group = new EmployeeGroup { Name = "Root", Groupcode = "ROT" };
                _context.EmployeeGroups.Add(group);
                _context.SaveChanges();

                var user = new ApplicationUser { FirstName = "Bwambale", LastName = "Dalton", UserName = "bdbdalton443@gmail.com", Email = "bdbdalton443@gmail.com" };
                if (_context != null)
                    user.EmployeeGroupID = group.EmployeeGroupID;
                var result = await _userManager.CreateAsync(user, "T3rr1613@2023");
                await _userManager.AddClaimsAsync(user, new List<Claim> { new Claim("Id", user.Id), new Claim("Email", user.Email) });
            }

            //// Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        private void InitializeDatabase()
        {
            var activities = _context.Activity.ToList();
            if (activities.FirstOrDefault(a => a.Name.Equals("Employee Data")) == null) _context.Activity.Add(new Activity() { Name = "Employee Data" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Permissions Settings")) == null) _context.Activity.Add(new Activity() { Name = "Permissions Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Doctors Prescriptions")) == null) _context.Activity.Add(new Activity() { Name = "Doctors Prescriptions" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Patient Receiptions")) == null) _context.Activity.Add(new Activity() { Name = "Patient Receiptions" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Patient Registry")) == null) _context.Activity.Add(new Activity() { Name = "Patient Registry" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Bill Payments")) == null) _context.Activity.Add(new Activity() { Name = "Bill Payments" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Laboratory Tests")) == null) _context.Activity.Add(new Activity() { Name = "Laboratory Tests" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Dispensory Data")) == null) _context.Activity.Add(new Activity() { Name = "Dispensory Data" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Stock Management")) == null) _context.Activity.Add(new Activity() { Name = "Stock Management" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Stock Allocation")) == null) _context.Activity.Add(new Activity() { Name = "Stock Allocation" });
            if (activities.FirstOrDefault(a => a.Name.Equals("General Stock")) == null) _context.Activity.Add(new Activity() { Name = "General Stock" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Opening Stock")) == null) _context.Activity.Add(new Activity() { Name = "Opening Stock" });
            if (activities.FirstOrDefault(a => a.Name.Equals("New Stock")) == null) _context.Activity.Add(new Activity() { Name = "New Stock" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Finance Settings")) == null) _context.Activity.Add(new Activity() { Name = "Finance Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Examinations Settings")) == null) _context.Activity.Add(new Activity() { Name = "Examinations Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Organisation Settings")) == null) _context.Activity.Add(new Activity() { Name = "Organisation Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Logistic Settings")) == null) _context.Activity.Add(new Activity() { Name = "Logistic Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Medical Management")) == null) _context.Activity.Add(new Activity() { Name = "Medical Management" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Logistics Management")) == null) _context.Activity.Add(new Activity() { Name = "Logistics Management" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Human Resource Management")) == null) _context.Activity.Add(new Activity() { Name = "Human Resource Management" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Settings")) == null) _context.Activity.Add(new Activity() { Name = "Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Accounts Management")) == null) _context.Activity.Add(new Activity() { Name = "Accounts Management" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Item Registry")) == null) _context.Activity.Add(new Activity() { Name = "Item Registry" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Patient Settings")) == null) _context.Activity.Add(new Activity() { Name = "Patient Settings" });
            if (activities.FirstOrDefault(a => a.Name.Equals("Human Resource Settings")) == null) _context.Activity.Add(new Activity() { Name = "Human Resource Settings" });

            //Bill Statuses
            var statuses = _context.BillStatus.ToList();
            if (statuses.FirstOrDefault(a => a.Name.Equals("Pending Lab")) == null) _context.BillStatus.Add(new BillStatus() { Name = "Pending Lab" });
            if (statuses.FirstOrDefault(a => a.Name.Equals("Pending Dispense")) == null) _context.BillStatus.Add(new BillStatus() { Name = "Pending Dispense" });
            if (statuses.FirstOrDefault(a => a.Name.Equals("Completed Lab")) == null) _context.BillStatus.Add(new BillStatus() { Name = "Completed Lab" });
            if (statuses.FirstOrDefault(a => a.Name.Equals("Completed Dispense")) == null) _context.BillStatus.Add(new BillStatus() { Name = "Completed Dispense" });
            _context.SaveChanges();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(Input.Email);
                    user = await _context.AppUsers.Include(i => i.EmployeeGroup).FirstOrDefaultAsync(E => E.EmployeeGroupID == user.EmployeeGroupID);

                    if (user.EmployeeGroup.Name == "Root")
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToPage("./RootDashboard");
                    }
                    else
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToPage("./Dashboard");
                    }
                    //return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
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

            // If we got this far, something failed, redisplay form
            return Page();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Verification email sent. Please check your email.");
            }

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = userId, code = code },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(
                Input.Email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            ModelState.AddModelError(string.Empty, "Verification email sent. Please check your email.");
            return Page();
        }
    }
}
