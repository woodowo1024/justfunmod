using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace justfun.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class RUSHcode666 : ModItem
    {
        public new string LocalizationCategory => "Items.Accessories.Wings";
        public override void SetStaticDefaults()
        {
            ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(361, 11.5f, 2.9f);
        }
        public override void SetDefaults() 
        {
            Item.width = 40;
            Item.height = 40;
            Item.damage = 262144;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 50);
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 32768;
        }

        public override void UpdateAccessory(Player player, bool hideVisual){
            player.luck += 16f;
            player.wingTimeMax += 131072;
            player.fishingSkill += 256;
            player.pickSpeed -= 0.9f;
            player.endurance += 0.3f;
            player.maxRunSpeed = 6f;
            player.accRunSpeed = 9f;
            player.autoReuseGlove = true;
            player.meleeScaleGlove = true;
            player.lavaImmune = true;
            player.waterWalk2 = true;
            player.noFallDmg = true;
            player.noKnockback = true;
            player.empressBrooch = true;
            player.moveSpeed += 2f;
            player.maxFallSpeed += 5f;
            if (player.controlJump && player.wingTime > 0f && player.jump == 0 && player.velocity.Y != 0f && !hideVisual)
            {
                int dustXOffset = 4;
                if (player.direction == 1)
                {
                    dustXOffset = -40;
                }
                int flightDust = Dust.NewDust(new Vector2(player.position.X + (float)(player.width / 2) + (float)dustXOffset, player.position.Y + (float)(player.height / 2) - 15f), 30, 30, DustID.GemDiamond, 0f, 0f, 100, default, 2.4f);
                Main.dust[flightDust].noGravity = true;
                Main.dust[flightDust].velocity *= 0.3f;
                if (Main.rand.NextBool(10))
                {
                    Main.dust[flightDust].fadeIn = 2f;
                }
                Main.dust[flightDust].shader = GameShaders.Armor.GetSecondaryShader(player.cWings, player);
            }
        }
        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.5f;
            ascentWhenRising = 0.3f;
            maxCanAscendMultiplier = 2f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.5f;
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.Register();
		}
    } 
}