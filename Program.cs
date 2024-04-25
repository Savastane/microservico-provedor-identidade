
using SecurityAPI.configuration;
using SecurityAPI.endpoint;
using Academico.System.Configuration;

var builder = WebApplication.CreateBuilder(args);
{

    // Configuração manual do Swagger para agrupar os endpoints
    var endpointGroups = new Dictionary<string, string[]>
            {
                { "User Operations", new[] { "user/v1/autenticar", "user/v1/autenticar/ambiente", "user/v1/insert", "user/v1/update/{id:guid}" } }
            };

    


    var services = builder.Services;
    services.AddEndpointsApiExplorer();    
    services.AddSweggerConfiguration();
    services.AddInjectConfiguration();   
    services.AddSystemContextConfiguration();
    services.AddFluentValidationConfiguration();
    services.AddMediatorConfiguration();
    services.AddOptions();
}
await using var app = builder.Build();
{
    app.AddUserEndpoint();
    app.AddPlataformEndpoint();
    //app.AddApplicationEndpoint();
    //app.AddOrganizationEndpoint();    
    //app.AddRouterEndpoint();
    //app.AddRoleEndpoint();
    //app.AddServiceEndpoint();

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");

        // Configuração manual do Swagger para agrupar os endpoints
        var endpointGroups = new Dictionary<string, string[]>
            {
                { "User Operations", new[] { "user/v1/autenticar", "user/v1/autenticar/ambiente", "user/v1/insert", "user/v1/update/{id:guid}" } }
            };

        foreach (var group in endpointGroups)
        {
            foreach (var endpoint in group.Value)
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", group.Key);
            }
        }
    });
    //app.UseAuthentication();
    //app.UseAuthorization();
    app.UseHttpsRedirection();

}

await app.RunAsync();
