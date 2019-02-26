using Terraria.ID;
using Terraria.ModLoader;

namespace ShittyDestruction.Items
{
	public class Shit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shit");
			Tooltip.SetDefault("This is the ultimate Weapon! A Sword with magic Damage.");
		}
		public override void SetDefaults()
		{
			item.damage = 1000;
			item.magic = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.knockBack = 100;
			item.value = 1000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumOre);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.PlatinumCoin, 5);
			recipe.AddRecipe();
		}
	}
}
