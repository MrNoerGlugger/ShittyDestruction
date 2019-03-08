using Terraria.ID;
using Terraria.ModLoader;

namespace ShittyDestruction.Items
{
	public class Poop : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Poop");
			Tooltip.SetDefault("The Shittiest of 'em all!");
		}
		
		public override void SetDefaults() {
			item.maxStack = 999999;
			item.value = 1000000;
			item.rare = 13;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 250);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(mod.ItemType("Shit"));
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumOre);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.PlatinumCoin, 5);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldOre);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.GoldCoin, 500);
			recipe.AddRecipe();
		}
	}
}