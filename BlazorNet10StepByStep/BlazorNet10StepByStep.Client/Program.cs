using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//Establish one instance per browser section
builder.Services.AddScoped<ProductService>();//Provide services to component with DI

await builder.Build().RunAsync();
