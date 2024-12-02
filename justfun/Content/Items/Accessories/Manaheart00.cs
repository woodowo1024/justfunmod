using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace justfun.Content.Items.Accessories
{
    public class Manaheart00 : ModItem
    {
        public override void SetDefaults() 
        {
            Item.width = 60;
            Item.height = 60;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 50);
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 4;
        }
        public override void UpdateAccessory(Player player, bool hideVisual){
            player.GetAttackSpeed<MagicDamageClass>() += 7f;
            player.GetDamage<MagicDamageClass>() += 1000;
            player.statManaMax2 += 65536;
            player.manaRegen += 4096;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.Register();
		}
    }

}