using System.Runtime.CompilerServices;
using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities.Enemies;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items;
using TheGreatAdventureGame.Models.Items.Consumables.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;
using TheGreatAdventureGame.State;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

//Add Sessions 
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache(); // required for session storage


// Add game state
builder.Services.AddSingleton<GameState>();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

//quick testing TODO: test inventory functions
//Player player = new Player();
Monk enemyMonk = new Monk();

Sword sword = new Sword();
Crossbow crossbow = new Crossbow();
Apple apple = new Apple(Rarity.Rare);
Apple apple2 = new Apple(Rarity.Rare);
Apple apple3 = new Apple(Rarity.Rare);
Apple apple4 = new Apple(Rarity.Rare);
Apple apple5 = new Apple(Rarity.Rare);
Apple apple6 = new Apple(Rarity.Rare);

Player player = new Player();

player.PickUpItem(sword);
player.PickUpItem(apple);
player.PickUpItem(apple2);
player.PickUpItem(apple3);
player.PickUpItem(apple4);
player.PickUpItem(apple5);
player.PickUpItem(apple6);

player.EquiptItem(apple2);
player.Consume();
player.EquiptItem(apple2);
player.DropItem(apple);

Console.WriteLine($"Monk Health: {enemyMonk.Health.ToString()}");
Console.WriteLine($"Player Health: {player.Health.ToString()}");
player.EquiptItem(sword);
player.DealWeaponEffect(enemyMonk);

enemyMonk.DealWeaponEffect(player);
Console.WriteLine($"Monk Health: {enemyMonk.Health.ToString()}");
Console.WriteLine($"Player Health: {player.Health.ToString()}");
player.Consume();
Console.WriteLine($"Player Health: {player.Health.ToString()}");
//player.EquiptItem(sword.Name);


//enemyMonk.DealWeaponEffect(player);

//Console.WriteLine($"{player.Name} Health: {player.Health.ToString()}");

//end testing 

// Enable Sessions 
app.UseSession();

app.Run();
