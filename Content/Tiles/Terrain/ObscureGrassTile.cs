using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Tiles.ObscureBadlands
{
    public sealed class ObscureGrassTile : ModTile
    {
        public override void SetStaticDefaults() {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            TileID.Sets.Grass[Type] = true;
            TileID.Sets.Conversion.Grass[Type] = true;
            TileID.Sets.NeedsGrassFraming[Type] = true;

            HitSound = SoundID.Dig;
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = fail ? 1 : 3;
        }

        public override void RandomUpdate(int i, int j) {
            if (Framing.GetTileSafely(i, j - 1).HasTile || !Main.rand.NextBool(40)) {
                return;
            }

            int style = Main.rand.Next(23);

            if (PlaceObject(i, j - 1, ModContent.TileType<ObscureFoliageTile>(), false, style) && Main.rand.NextBool(10)) {
                NetMessage.SendObjectPlacment(-1, i, j - 1, ModContent.TileType<ObscureFoliageTile>(), style, 0, -1, -1);
            }
        }

        private static bool PlaceObject(int x, int y, int type, bool mute = false, int style = 0, int random = -1,
            int direction = -1) {

            if (!TileObject.CanPlace(x, y, type, style, direction, out TileObject toBePlaced)) {
                return false;
            }

            toBePlaced.random = random;

            if (TileObject.Place(toBePlaced) && !mute) {
                WorldGen.SquareTileFrame(x, y);
            }

            return false;
        }
    }
}