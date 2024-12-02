using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace justfun.Content.Items.Accessories
{
    public class Extralargedronehangar : ModItem
    {
        public override void SetDefaults() 
        {
            Item.width = 60;
            Item.height = 60;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 70);
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 65536;
        }
        public override void UpdateAccessory(Player player, bool hideVisual){
            player.GetAttackSpeed<SummonDamageClass>() += 60f;
            player.GetDamage<SummonDamageClass>() += 1000;
            player.maxMinions += 64;
            player.maxTurrets += 32;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.Register();
		}
    }

}