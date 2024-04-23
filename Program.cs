
using SecurityAPI.configuration;
using SecurityAPI.endpoint;
using Academico.System.Configuration;

var builder = WebApplication.CreateBuilder(args);
{
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
    //app.AddPlataformEndpoint();
    //app.AddApplicationEndpoint();
    //app.AddOrganizationEndpoint();    
    //app.AddRouterEndpoint();
    //app.AddRoleEndpoint();
    //app.AddServiceEndpoint();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    //app.UseAuthentication();
    //app.UseAuthorization();
    app.UseHttpsRedirection();

}

await app.RunAsync();
