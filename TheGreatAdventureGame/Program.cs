using System.Runtime.CompilerServices;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items;
using TheGreatAdventureGame.Models.Items.Consumables.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Add Sessions 
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache(); // required for session storage

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

//quick testing TODO: test inventory functions
Player player = new Player();
Monk enemyMonk = new Monk();

Sword sword = new Sword();
Crossbow crossbow = new Crossbow();
Apple apple = new Apple();

player.EquiptItem(sword.Name);


enemyMonk.DealWeaponEffect(player);

Console.WriteLine($"{player.Name} Health: {player.Health.ToString()}");

//end testing 

// Enable Sessions 
app.UseSession();

app.Run();
