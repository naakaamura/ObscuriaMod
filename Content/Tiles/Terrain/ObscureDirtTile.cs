using Microsoft.Xna.Framework;
using ObscuriaMod.Content.Items.Terrain;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Tiles.Terrain
{
    public sealed class ObscureDirtTile : ModTile
    {
        public override void SetStaticDefaults() {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            AddMapEntry(new Color(126, 77, 166));

            HitSound = SoundID.Dig;
            ItemDrop = ModContent.ItemType<ObscureDirtItem>();
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = fail ? 1 : 3;
        }
    }
}