using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace justfun.Content.Items.Accessories
{
    public class Whitefoodstallplasticchair : ModItem
    {
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
            player.GetDamage<GenericDamageClass>() += 256f;
            player.GetCritChance<GenericDamageClass>() += 512;
            player.GetArmorPenetration<GenericDamageClass>() += 16384;
            player.GetAttackSpeed<MeleeDamageClass>() += 2f;
            player.GetAttackSpeed<GenericDamageClass>() += 3f;
            player.luck += 256f;
            player.luckMaximumCap = 50;
            player.thorns += 256f;
            player.statLifeMax2 += 299500;
            player.lifeRegen += 65536;
            player.pickSpeed -= 0.9f;
            player.endurance += 0.95f;
            player.autoReuseGlove = true;
            player.meleeScaleGlove = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.PotionSickness] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.Horrified] = true;
            player.buffImmune[BuffID.TheTongue] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Suffocation] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Blackout] = true;
            player.buffImmune[BuffID.ManaSickness] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.MoonLeech] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.Dazed] = true;
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
            player.buffImmune[BuffID.BoneJavelin] = true;
            player.buffImmune[BuffID.WindPushed] = true;
            player.buffImmune[BuffID.WitheredArmor] = true;
            player.buffImmune[BuffID.WitheredWeapon] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.buffImmune[BuffID.NoBuilding] = true;
            player.buffImmune[BuffID.OnFire3] = true;
            player.buffImmune[BuffID.Frostburn2] = true;
            player.buffImmune[BuffID.Hunger] = true;
            player.buffImmune[BuffID.Starving] = true;
            player.buffImmune[BuffID.BloodButcherer] = true;
            player.buffImmune[BuffID.Shimmer] = true;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.Register();
		}
    }

}