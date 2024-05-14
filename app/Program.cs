var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "I can now deploy applications to Beanstalk Envs. Thanks to JOMACS!");

app.Run();
