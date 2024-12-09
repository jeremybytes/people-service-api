using Microsoft.AspNetCore.Mvc;

namespace People.Service.Controllers;

[Route("[controller]")]
[ApiController]
public class PeopleController : ControllerBase
{
    private IPeopleProvider provider;

    public PeopleController(IPeopleProvider provider)
    {
        this.provider = provider;
    }

    [HttpGet]
    public async Task<IEnumerable<Person>> Get()
    {
        await Task.Delay(3000);
        return provider.GetPeople();
    }

    [HttpGet("{id}")]
    public async Task<Person?> Get(int id)
    {
        await Task.Delay(1000);
        return provider.GetPerson(id);
    }

    [HttpGet("ids")]
    public List<int> GetIds()
    {
        return provider.GetPeople().Select(p => p.Id).ToList();
    }
}
