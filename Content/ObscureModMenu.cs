using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace ObscuriaMod.Content
{
    public sealed class ObscureModMenu : ModMenu
    {
        public override ModSurfaceBackgroundStyle MenuBackgroundStyle => ModContent.Find<ModSurfaceBackgroundStyle>("ObscuriaMod/ObscureSurfaceBackgroundStyle");
        
        public override Asset<Texture2D> Logo => Mod.Assets.Request<Texture2D>("Assets/Textures/ObscureLogo");

        public override int Music => MusicLoader.GetMusicSlot("ObscuriaMod/Assets/Sounds/Music/MainTheme");

        public override string DisplayName => "Obscure Menu";

        public override void OnSelected() {
            SoundEngine.PlaySound(SoundID.Thunder); 
        }
    }
}