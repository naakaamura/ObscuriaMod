using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace ObscuriaMod.Content.Biomes.Obscure
{
    public sealed class ObscureSurfaceBackgroundStyle : ModSurfaceBackgroundStyle
    {
        public override void ModifyFarFades(float[] fades, float transitionSpeed) {
            for (var i = 0; i < fades.Length; i++) {
                if (i == Slot) {
                    fades[i] += transitionSpeed;
                }
                else {
                    fades[i] -= transitionSpeed;
                }

                fades[i] = MathHelper.Clamp(fades[i], 0f, 1f);
            }
        }

        public override int ChooseFarTexture() {
            return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ObscureBiomeSurfaceFar");
        }

        public override int ChooseMiddleTexture() {
            return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ObscureBiomeSurfaceMiddle");
        }

        public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b) {
            return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ObscureBiomeSurfaceClose");
        }
    }
}