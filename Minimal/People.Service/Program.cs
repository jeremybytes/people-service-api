using People.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IPeopleProvider, HardCodedPeopleProvider>();
builder.Services.ConfigureHttpJsonOptions(options => options.SerializerOptions.WriteIndented = true);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/people", (IPeopleProvider provider) => provider.GetPeople())
    .WithName("GetPeople");

app.MapGet("/people/{id}", (IPeopleProvider provider, int id) =>
    {
        var result = provider.GetPerson(id);
        return result switch
        {
            null => Results.NoContent(),
            _ => Results.Json(result)
        };
    })
    .WithName("GetPersonById");

app.MapGet("/people/ids",
    (IPeopleProvider provider) => provider.GetPeople().Select(p => p.Id).ToList())
    .WithName("GetAllPersonIds");

app.Run();
