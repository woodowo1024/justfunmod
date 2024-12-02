using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace justfun.Content.Items.Weapons.Ranged
{
    public class Thestarhunter : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 165;
            Item.height = 48;
            Item.damage = 420000;
            Item.knockBack = 12.5f;
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = 180;
            Item.useAnimation =180;
            Item.shoot = ProjectileID.BulletHighVelocity;
            Item.shootSpeed = 50f;
            Item.useAmmo = AmmoID.Bullet;
            Item.autoReuse = false;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.value = Item.sellPrice(platinum: 100);
            Item.rare = ItemRarityID.Master;
        }
        public override Vector2? HoldoutOffset() => new Vector2(-56, 0);
        public override void ModifyWeaponCrit(Player player, ref float crit) => crit += 80;
        public override void HoldItem(Player player) => player.scope = true;
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.Register();
		}
    }
}