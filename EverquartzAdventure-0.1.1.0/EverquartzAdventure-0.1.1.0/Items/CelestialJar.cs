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
	public class CelestialJar : ModItem
	{
		public override void SetStaticDefaults() {			
            DisplayName.SetDefault("Celestial Jar");
			DisplayName.AddTranslation(7, "我们把她放在罐子里。 你知道这意味着什么。..");
			Tooltip.SetDefault("The child of the rock and the worm, just \nin your hands, in this jar! Wow!.");
			Tooltip.AddTranslation(7, "贾拉特? \n间谍讨厌它");
		}
		public override void SetDefaults() {
			Item.width = 20; 
			Item.height = 26; 
			Item.maxStack = 1; // so you tell me that provi and dog fucked over 9999 times? No. I am not going to imagine this. Neither let this stay in the cannon. - blitz
			Item.value = Item.buyPrice(gold: 1); 
            Item.rare = ItemRarityID.Expert;
		}
		public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(Item.type);
            recipe.AddIngredient<DeimosFumo>(1);
            recipe.Register();
        }
    }
}