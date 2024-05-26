var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "<h1>I can now deploy applications to Beanstalk Envs. Thanks to JOMACS!</h1>");

app.Run();
