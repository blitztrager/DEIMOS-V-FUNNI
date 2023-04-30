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
	public class DivineCore : ModItem
	{
		public override void SetStaticDefaults() {			
            DisplayName.SetDefault("The Center Of The Sun");
			DisplayName.AddTranslation(7, "神圣核心");
			Tooltip.SetDefault("You feel like you drank lots of alchogol, whitout getting drunk...\nYou are feeling the power of sex from it.");
			Tooltip.AddTranslation(7, "来源的核心。");
		}
		public override void SetDefaults() {
			Item.width = 42; 
			Item.height = 102; 
			Item.maxStack = 10; 
			Item.value = Item.buyPrice(platinum: 5); 
            Item.rare = ItemRarityID.Lime;
		}
    }
}