using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Dream_Housing.Controllers
{
    public class LandingPageController : Controller
    {
		// GET: LandingPage
		//[Authorize]
		public ActionResult Index()
        {
            return View();
        }
		[Authorize]
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Services()
		{
			ViewBag.Message = "Your services page.";

			return View();
		}

		public ActionResult Project()
		{
			ViewBag.Message = "Your project page.";

			return View();
		}

		public ActionResult Testimonial()
		{
			ViewBag.Message = "Your testimonial page.";

			return View();
		}

		[HttpGet]
		public ActionResult Login()
		{
			//ViewBag.Message = "Your Login page.";
			//ViewBag.AlertType = "alert-danger";
			//ViewBag.AlertTitle = "Error!";
			//ViewBag.AlertMessage = "Invalid username or password.";

			return View();
		}

		[HttpPost]
		public ActionResult Login(string Email, string Password)
		{
			// Check if the email and password match the patterns
			if (!IsValidEmail(Email))
			{
				ViewBag.AlertType = "alert-danger";
				ViewBag.AlertTitle = "Error!";
				ViewBag.AlertMessage = "Invalid Email.";
				return View();
			}

			if (!IsValidPassword(Password))
			{
				ViewBag.AlertType = "alert-danger";
				ViewBag.AlertTitle = "Error!";
				ViewBag.AlertMessage = "Invalid Password.";
				return View();
			}

			// Check if the email and password are correct
			bool emailCorrect = (Email == "test1@gmail.com");
			bool passwordCorrect = (Password == "0testPass@");

			if (!emailCorrect && !passwordCorrect)
			{
				ViewBag.AlertType = "alert-danger";
				ViewBag.AlertTitle = "Error!";
				ViewBag.AlertMessage = "Invalid Email and Password.";
				Console.WriteLine("Both Email And Password are wrong");
			}
			else if (!emailCorrect)
			{
				ViewBag.AlertType = "alert-danger";
				ViewBag.AlertTitle = "Error!";
				ViewBag.AlertMessage = "Wrong Email.";
			}
			else if (!passwordCorrect)
			{
				ViewBag.AlertType = "alert-danger";
				ViewBag.AlertTitle = "Error!";
				ViewBag.AlertMessage = "Wrong Password.";
			}
			else
			{
				// Perform user existence check in the database
				dynamic userExists = null;

				if (userExists != null)
				{
					ViewBag.AlertType = "alert-success";
					ViewBag.AlertTitle = "Success!";
					ViewBag.AlertMessage = "Login Successful.";
				}
				else
				{
					ViewBag.AlertType = "alert-danger";
					ViewBag.AlertTitle = "Error!";
					ViewBag.AlertMessage = "Login Failed.";
					Console.WriteLine("Login Failed because User not found in the 'user' table from the database");
				}
			}

			return View();
		}















		private bool IsValidEmail(string email)
		{
			// Implement your email validation logic here
			// Example: use regular expressions to validate email format

			// Regular expression pattern for validating email addresses
			string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

			// Use Regex.IsMatch to check if the email matches the pattern
			bool validationResult = Regex.IsMatch(email, emailPattern);

			return validationResult;
		}

		private bool IsValidPassword(string password)
		{
			// Implement your password validation logic here
			// Example: check minimum length, at least one uppercase letter, and at least one digit

			if (string.IsNullOrEmpty(password))
			{
				return false;
			}

			// Check minimum length (e.g., 8 characters)
			if (password.Length < 6 && password.Length > 255)
			{
				return false;
			}

			return true;
		}

	}
}