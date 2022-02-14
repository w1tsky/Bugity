using Bugity.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bugity.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BugsController : ControllerBase
{
    AppDbContext dbContext;

    public BugsController(AppDbContext ctx)
    {
        dbContext = ctx;
        if (!dbContext.Bugs.Any())
        {
            dbContext.Bugs.Add(new Bug { Title = "Test Bug", Description = "Test Description", Status = BugStatus.Open });
            dbContext.SaveChanges();
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bug>>> Get()
    {
        return await dbContext.Bugs.ToListAsync();
    }

    // GET api/users/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Bug>> Get(int id)
    {
        Bug bug = await dbContext.Bugs.FirstOrDefaultAsync(x => x.Id == id);
        if (bug == null)
            return NotFound();
        return new ObjectResult(bug);
    }

}