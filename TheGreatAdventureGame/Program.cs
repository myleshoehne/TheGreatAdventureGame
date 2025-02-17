using System.Runtime.CompilerServices;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Items;
using TheGreatAdventureGame.Models.Items.Food;
using TheGreatAdventureGame.Models.Items.Weapons;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//quick testing
Sword sword = new Sword();
Monk monk = new Monk();
Apple apple = new Apple();



Console.WriteLine(monk.Health.ToString());

Console.WriteLine(sword.Rarity);
sword.DealDamage(monk);


Console.WriteLine(monk.Health.ToString());

apple.Consume(monk);
Console.WriteLine(apple.Rarity);

Console.WriteLine(monk.Health.ToString());


//end testing 

app.Run();
