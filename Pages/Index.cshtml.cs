using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoursesWebApp.Pages;

public class CoursesAndModulesModel : PageModel
{
    private readonly ILogger<CoursesAndModulesModel> _logger;

    public CoursesAndModulesModel(ILogger<CoursesAndModulesModel> logger)
    {
        _logger = logger;
    }

    // TODO: Create a DataAccessController object

    // TODO: Create a collection for holding CoursesAndModules object

    public void OnGet()
    {
            // TODO: Retrieve the data using the DataAccessController object and populate the CoursesAndModules object

    }
}
