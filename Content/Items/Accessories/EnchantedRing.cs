﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ValhallaMod;

namespace Vanilla.Content.Items.Accessories
{
    public class EnchantedRing : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Enchanted Ring");
            // Tooltip.SetDefault("Increases ValhallaMod aura radius by 10%\nIncreases aura buff duration by 3 seconds");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(silver: 50);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<AuraPlayer>().auraBuffTime5 = true;
            player.GetModPlayer<AuraPlayer>().auraRadius += 0.17f;
        }
    }
}
