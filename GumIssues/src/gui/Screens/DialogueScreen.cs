using Gum.Managers;
using Gum.Wireframe;
using Microsoft.Xna.Framework.Graphics;
namespace GumIssues.Screens
{
    partial class DialogueScreen
    {
        partial void CustomInitialize()
        {
            // ButtonContinue.IsVisible = false;
            ButtonContinue.ButtonCategoryState = Components.ButtonIcon.ButtonCategory.Focused;
        }

        public Texture2D DialogueWindowTexture
        {
            get => DialogueWindow.Texture;
            set => DialogueWindow.Texture = value;
        }

        public Texture2D SpeakerNameTexture
        {
            get => SpeakerName.Texture;
            set => SpeakerName.Texture = value;
        }

        public Texture2D SpeakerPortraitTexture
        {
            get => SpeakerPortrait.Texture;
            set => SpeakerPortrait.Texture = value;
        }
    }
}
