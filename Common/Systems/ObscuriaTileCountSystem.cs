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
            
        }
    }
}