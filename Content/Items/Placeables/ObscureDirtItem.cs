using ObscuriaMod.Content.Tiles.Obscure;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Items.Placeables
{
    public sealed class ObscureDirtItem : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Obscure Dirt");
        }

        public override void SetDefaults() {
            Item.maxStack = 999;

            Item.width = 16;
            Item.height = 16;

            Item.DefaultToPlaceableTile(ModContent.TileType<ObscureDirtTile>());
        }
    }
}