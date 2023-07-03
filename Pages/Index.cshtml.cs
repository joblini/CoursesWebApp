using CoursesWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoursesWebApp.Pages;

public class CoursesAndModulesModel : PageModel
{
    private readonly ILogger<CoursesAndModulesModel> _logger;

    public CoursesAndModulesModel(ILogger<CoursesAndModulesModel> logger)
    {
        _logger = logger;
    }

    // Create a DataAccessController object
    DataAccessController dac = new DataAccessController();

    // Create a collection for holding CoursesAndModules object
    public List<CoursesAndModules> CoursesAndModules;

    public void OnGet()
    {
            // Retrieve the data using the DataAccessController object and populate the CoursesAndModules object
            CoursesAndModules = dac.GetAllCoursesAndModules().ToList();
    }
}
