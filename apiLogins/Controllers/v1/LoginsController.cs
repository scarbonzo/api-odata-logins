using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Produces("application/json")]
[Route("api/v1/[controller]")]
public class LoginsController : ControllerBase
{
    private readonly LoginTrackingContext _context;

    public LoginsController(LoginTrackingContext context)
    {
        _context = context;
    }

    [HttpGet]
    [EnableQuery]
    public IEnumerable<TblLoginsV2> Get()
    {
        return _context.TblLoginsV2;
    }
}
