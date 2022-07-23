using ObscuriaMod.Content.Tiles.Obscure;
using System;
using Terraria.ModLoader;

namespace ObscuriaMod.Common.Systems
{
    public sealed class ObscuriaTileCountSystem : ModSystem
    {
        public static int ObscureBadlandsTileCount { get; private set; }

        public override void ResetNearbyTileEffects() {
            ObscureBadlandsTileCount = 0;
        }

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts) {
            ObscureBadlandsTileCount += tileCounts[ModContent.TileType<ObscureDirtTile>()];
            ObscureBadlandsTileCount += tileCounts[ModContent.TileType<ObscureStoneTile>()];
            ObscureBadlandsTileCount += tileCounts[ModContent.TileType<ObscureGrassTile>()];
            ObscureBadlandsTileCount += tileCounts[ModContent.TileType<ObscureFoliageTile>()];
        }
    }
}