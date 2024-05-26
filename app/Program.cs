var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => 
{
    context.Response.ContentType = "text/html";
    return "<h1>I can now deploy applications to Beanstalk Envs. Thanks to JOMACS!</h1>";
});

app.Run();
