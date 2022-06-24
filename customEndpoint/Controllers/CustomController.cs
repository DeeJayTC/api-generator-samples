using Microsoft.AspNetCore.Mvc;
using TCDev.APIGenerator.Data;

namespace remote_api.Controllers;

public class CustomController : Controller
{

    private GenericDbContext genericDb;
    
    public CustomController(GenericDbContext data)
    {
        genericDb = data;
    }


    public IActionResult GetCustomEntry(int id)
    {
        // Run a custom query
        var data = genericDb.Set<Student>().Where(p => p.Id == id);
        
        
        return View();
    }
}
