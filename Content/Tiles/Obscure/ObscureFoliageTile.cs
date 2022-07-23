using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ObscuriaMod.Content.Tiles.Obscure
{
    public sealed class ObscureFoliageTile : ModTile
    {
        public override void SetStaticDefaults() {
            Main.tileCut[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileLighted[Type] = false;
            Main.tileMergeDirt[Type] = true;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);

            TileObjectData.newTile.LavaDeath = true;
            TileObjectData.newTile.WaterDeath = false;

            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinateHeights = new[] {
                20
            };

            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.newTile.Style = 0;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.UsesCustomCanPlace = true;

            for (var i = 0; i < 23; i++) {
                TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
                TileObjectData.addSubTile(TileObjectData.newSubTile.Style);
            }

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(126, 77, 166));

            HitSound = SoundID.Grass;
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = 2;
        }
    }
}