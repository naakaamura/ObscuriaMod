using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Tiles.ObscureBadlands
{
    public sealed class ObscureStoneTile : ModTile
    {
        public override void SetStaticDefaults() {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            HitSound = SoundID.Tink;
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = fail ? 1 : 3;
        }
    }
}