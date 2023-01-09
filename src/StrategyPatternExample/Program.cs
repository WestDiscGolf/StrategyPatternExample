using StrategyPatternExample.Operators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMathStrategy, MathStrategy>();
builder.Services.AddScoped<IMathOperator, AddOperator>();
builder.Services.AddScoped<IMathOperator, SubtractOperator>();
builder.Services.AddScoped<IMathOperator, MultipleOperator>();
builder.Services.AddScoped<IMathOperator, DivideOperator>();

var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/", (IMathStrategy strategy) =>
{
    int a = 10;
    int b = 5;
    int result = strategy.Calculate(a, b, Operator.Add);
    return Results.Ok(result.ToString());
});

app.Run();