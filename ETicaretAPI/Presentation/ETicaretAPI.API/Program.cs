
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceServices();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod()
));

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
                .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>())
                .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

/*
 * Asp.net core da hazýr gelen filterla deðilde benim yazdýðýmla kontrol et demek.
 ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true
 */

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();