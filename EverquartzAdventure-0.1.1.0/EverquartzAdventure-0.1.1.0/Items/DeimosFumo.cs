using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent;

namespace EverquartzAdventure.Items
{
	public class DeimosFumo : ModItem
	{
		public override void SetStaticDefaults() {			
            DisplayName.SetDefault("Deimos Plushie"); // fumo and plushie is kinda different. - blitz
			DisplayName.AddTranslation(7, "戴莫斯玩偶");
			Tooltip.SetDefault("A plushie. Thats it. Wait dont put it in a jar st-");
			Tooltip.AddTranslation(7, "把它放进罐子里.");
		}
		public override void SetDefaults() {
			Item.width = 40; 
			Item.height = 64; 
			Item.maxStack = 24; 
			Item.value = Item.buyPrice(gold: 1); 
            Item.rare = ItemRarityID.Cyan;
		}
    }
}