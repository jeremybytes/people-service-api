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
    public IEnumerable<Person> Get()
    {
        return provider.GetPeople();
    }

    [HttpGet("{id}")]
    public Person? Get(int id)
    {
        return provider.GetPerson(id);
    }

    [HttpGet("ids")]
    public List<int> GetIds()
    {
        return provider.GetPeople().Select(p => p.Id).ToList();
    }
}
