using ObscuriaMod.Common.Systems;
using Terraria;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Biomes.ObscureBadlands
{
    public sealed class ObscureBadlandsSurfaceBiome : ModBiome
    {
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