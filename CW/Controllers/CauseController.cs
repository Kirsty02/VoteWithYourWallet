using CW.Data;
using CW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace CW.Controllers
{
    
    public class CauseController : Controller
    {
        // Declare a private read-only variable for the database context
        private readonly MyDbContext _db;

        
        public CauseController(MyDbContext db)
        {
            // Assign the passed MyDbContext object to the private _db variable
            _db = db;
        }

        // Define the CreateCause action with HttpGet attribute
        [HttpGet]
        public IActionResult CreateCause()
        {
            // Redirect the user to the Index action in the Home controller
            return RedirectToAction("Index", "Home");
        }

        // Define the CreateCause action with HttpPost attribute, which takes title, description, image, and category as parameters
        [HttpPost]
        public async Task<IActionResult> CreateCause(string title, string description, IFormFile image, string category)
        {
            // Check if the ModelState is valid
            if (ModelState.IsValid)
            {
                // Create a new Cause object
                Cause new_cause = new Cause();
                new_cause.Title = title;
                new_cause.Description = description;
                new_cause.Category = category;

                // Save the uploaded image as a byte array in the Cause object
                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    new_cause.Image = ms.ToArray();
                }

                // Add the new cause to the Causes DbSet and save changes to the database
                _db.Add(new_cause);
                await _db.SaveChangesAsync();

                
                return RedirectToAction("Index", "Home");
            }

            
            return RedirectToAction("Index", "Home");
        }

        // Define the Sign action, which takes causeId and signature as parameters
        public async Task<IActionResult> Sign(int causeId, string signature)
        {
            // Find the cause with the specified causeId in the database
            var cause = await _db.Causes.FindAsync(causeId);

            // Check if the cause exists
            if (cause != null)
            {
                // Initialize the Signatures list if it's null, and add the signature
                cause.Signatures ??= new List<string>();
                cause.Signatures.Add(signature);

                // Save changes to the database
                await _db.SaveChangesAsync();

                // Calculate the total number of signatures for the cause
                var signatureCount = cause.Signatures.Count;

                // Return a JSON object with success status, signature, and count
                return Json(new { success = true, signature = signature, count = signatureCount });
            }
            else
            {
                // Return a JSON object with an error message if the cause is not found
                return Json(new { success = false, error = "Cause not found." });
            }
        }

        // Define the Delete action with HttpPost attribute, which takes CauseId as a parameter
        [HttpPost]
        public async Task<IActionResult> Delete(int CauseId) // Fix the typo in the parameter name
        {
            // Find the cause with the specified CauseId in the database
            var cause = await _db.Causes.FindAsync(CauseId);

            // Check if the cause exists
            if (cause == null)
            {
                // Return a NotFound result if the cause is not found
                return NotFound();
            }

            // Remove the cause from the Causes DbSet
            _db.Causes.Remove(cause);

            // Save changes to the database
            await _db.SaveChangesAsync();

            // Redirect to the view where you want to show the success message (e.g., the list of causes)
            return RedirectToAction("Index", "Home");
        }
    }
}