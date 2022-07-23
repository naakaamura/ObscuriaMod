using ObscuriaMod.Common.Systems;
using Terraria;
using Terraria.Graphics.Capture;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Biomes.Obscure
{
    public sealed class ObscureSurfaceBiome : ModBiome
    {
        public override ModSurfaceBackgroundStyle SurfaceBackgroundStyle => ModContent.Find<ModSurfaceBackgroundStyle>("ObscuriaMod/ObscureSurfaceBackgroundStyle");

        public override CaptureBiome.TileColorStyle TileColorStyle => CaptureBiome.TileColorStyle.Corrupt;

        public override int Music => MusicLoader.GetMusicSlot("ObscuriaMod/Assets/Sounds/Music/MainTheme");

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Obscure Badlands");
        }

        public override bool IsBiomeActive(Player player) {
            bool onSurface = player.ZoneSkyHeight || player.ZoneOverworldHeight;
            bool onBiome = ObscuriaTileCountSystem.ObscureBadlandsTileCount > 100;
            return onBiome && onSurface;
        }
    }
}