using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StoneBench : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 42;
			item.height = 16;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("StoneBench");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Bench");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3, 8);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
