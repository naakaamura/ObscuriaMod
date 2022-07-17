using ObscuriaMod.Content.Tiles.ObscureBadlands;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Items.Placeables
{
    public sealed class ObscureStoneItem : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Obscure Stone");
        }

        public override void SetDefaults() {
            Item.maxStack = 999;

            Item.width = 16;
            Item.height = 16;

            Item.DefaultToPlaceableTile(ModContent.TileType<ObscureStoneTile>());
        }
    }
}