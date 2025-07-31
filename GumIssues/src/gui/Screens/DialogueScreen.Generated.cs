//Code for DialogueScreen
using GumRuntime;
using MonoGameGum;
using MonoGameGum.GueDeriving;
using GumIssues.Components;
using Gum.Managers;
using Gum.Wireframe;
namespace GumIssues.Screens;
partial class DialogueScreen : MonoGameGum.Forms.Controls.FrameworkElement
{
    [System.Runtime.CompilerServices.ModuleInitializer]
    public static void RegisterRuntimeType()
    {
        var template = new MonoGameGum.Forms.VisualTemplate((vm, createForms) =>
        {
            var visual = new MonoGameGum.GueDeriving.ContainerRuntime();
            var element = ObjectFinder.Self.GetElementSave("DialogueScreen");
            element.SetGraphicalUiElement(visual, RenderingLibrary.SystemManagers.Default);
            if(createForms) visual.FormsControlAsObject = new DialogueScreen(visual);
            visual.Width = 0;
            visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
            visual.Height = 0;
            visual.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
            return visual;
        });
        MonoGameGum.Forms.Controls.FrameworkElement.DefaultFormsTemplates[typeof(DialogueScreen)] = template;
        ElementSaveExtensions.RegisterGueInstantiation("DialogueScreen", () => 
        {
            var gue = template.CreateContent(null, true) as InteractiveGue;
            return gue;
        });
    }
    public SpriteRuntime SpeakerPortrait { get; protected set; }
    public NineSliceRuntime DialogueWindow { get; protected set; }
    public TextRuntime DialogueText { get; protected set; }
    public TextRuntime SpeakerNameText { get; protected set; }
    public NineSliceRuntime SpeakerName { get; protected set; }
    public ButtonIcon ButtonContinue { get; protected set; }

    public string DialogueTextField
    {
        get => DialogueText.Text;
        set => DialogueText.Text = value;
    }

    public string SpeakerNameTextField
    {
        get => SpeakerNameText.Text;
        set => SpeakerNameText.Text = value;
    }

    public DialogueScreen(InteractiveGue visual) : base(visual) { }
    public DialogueScreen() : base(new ContainerRuntime())
    {


        InitializeInstances();

        ApplyDefaultVariables();
        AssignParents();
        CustomInitialize();
    }
    protected virtual void InitializeInstances()
    {
        base.ReactToVisualChanged();
        SpeakerPortrait = new SpriteRuntime();
        SpeakerPortrait.ElementSave = ObjectFinder.Self.GetStandardElement("Sprite");
        if (SpeakerPortrait.ElementSave != null) SpeakerPortrait.AddStatesAndCategoriesRecursivelyToGue(SpeakerPortrait.ElementSave);
        if (SpeakerPortrait.ElementSave != null) SpeakerPortrait.SetInitialState();
        SpeakerPortrait.Name = "SpeakerPortrait";
        DialogueWindow = new NineSliceRuntime();
        DialogueWindow.ElementSave = ObjectFinder.Self.GetStandardElement("NineSlice");
        if (DialogueWindow.ElementSave != null) DialogueWindow.AddStatesAndCategoriesRecursivelyToGue(DialogueWindow.ElementSave);
        if (DialogueWindow.ElementSave != null) DialogueWindow.SetInitialState();
        DialogueWindow.Name = "DialogueWindow";
        DialogueText = new TextRuntime();
        DialogueText.ElementSave = ObjectFinder.Self.GetStandardElement("Text");
        if (DialogueText.ElementSave != null) DialogueText.AddStatesAndCategoriesRecursivelyToGue(DialogueText.ElementSave);
        if (DialogueText.ElementSave != null) DialogueText.SetInitialState();
        DialogueText.Name = "DialogueText";
        SpeakerNameText = new TextRuntime();
        SpeakerNameText.ElementSave = ObjectFinder.Self.GetStandardElement("Text");
        if (SpeakerNameText.ElementSave != null) SpeakerNameText.AddStatesAndCategoriesRecursivelyToGue(SpeakerNameText.ElementSave);
        if (SpeakerNameText.ElementSave != null) SpeakerNameText.SetInitialState();
        SpeakerNameText.Name = "SpeakerNameText";
        SpeakerName = new NineSliceRuntime();
        SpeakerName.ElementSave = ObjectFinder.Self.GetStandardElement("NineSlice");
        if (SpeakerName.ElementSave != null) SpeakerName.AddStatesAndCategoriesRecursivelyToGue(SpeakerName.ElementSave);
        if (SpeakerName.ElementSave != null) SpeakerName.SetInitialState();
        SpeakerName.Name = "SpeakerName";
        ButtonContinue = new ButtonIcon();
        ButtonContinue.Name = "ButtonContinue";
    }
    protected virtual void AssignParents()
    {
        this.AddChild(SpeakerPortrait);
        this.AddChild(DialogueWindow);
        DialogueWindow.AddChild(DialogueText);
        SpeakerName.AddChild(SpeakerNameText);
        this.AddChild(SpeakerName);
        DialogueWindow.AddChild(ButtonContinue);
    }
    private void ApplyDefaultVariables()
    {
        this.SpeakerPortrait.Height = 480f;
        this.SpeakerPortrait.SourceFileName = @"";
        this.SpeakerPortrait.Width = 480f;
        this.SpeakerPortrait.X = 332f;
        this.SpeakerPortrait.Y = 36f;
        this.SpeakerPortrait.YUnits = global::Gum.Converters.GeneralUnitType.Percentage;

        this.DialogueWindow.Alpha = 195;
        this.DialogueWindow.Blue = 82;
        this.DialogueWindow.Green = 0;
        this.DialogueWindow.Height = 96f;
        this.DialogueWindow.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
        this.DialogueWindow.Red = 0;
        this.DialogueWindow.SourceFileName = @"ExampleSpriteFrame.png";
        this.DialogueWindow.TextureAddress = global::Gum.Managers.TextureAddress.EntireTexture;
        this.DialogueWindow.TextureHeight = 24;
        this.DialogueWindow.TextureLeft = 0;
        this.DialogueWindow.TextureTop = 0;
        this.DialogueWindow.TextureWidth = 24;
        this.DialogueWindow.Width = 304f;
        this.DialogueWindow.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
        this.DialogueWindow.X = 48f;
        this.DialogueWindow.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
        this.DialogueWindow.XUnits = global::Gum.Converters.GeneralUnitType.PixelsFromSmall;
        this.DialogueWindow.Y = 368f;
        this.DialogueWindow.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
        this.DialogueWindow.YUnits = global::Gum.Converters.GeneralUnitType.PixelsFromSmall;

        this.DialogueText.FontSize = 12;
        this.DialogueText.Height = 88f;
        this.DialogueText.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfParent;
        this.DialogueText.UseCustomFont = false;
        this.DialogueText.Width = 96f;
        this.DialogueText.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfParent;
        this.DialogueText.X = 2f;
        this.DialogueText.XUnits = global::Gum.Converters.GeneralUnitType.Percentage;
        this.DialogueText.Y = 4f;
        this.DialogueText.YUnits = global::Gum.Converters.GeneralUnitType.Percentage;

        this.SpeakerNameText.FontSize = 14;
        this.SpeakerNameText.Height = 98f;
        this.SpeakerNameText.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfParent;
        this.SpeakerNameText.MaxLettersToShow = 12;
        this.SpeakerNameText.MaxNumberOfLines = 1;
        this.SpeakerNameText.Text = @"CLUTCH";
        this.SpeakerNameText.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
        this.SpeakerNameText.Width = 94f;
        this.SpeakerNameText.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfParent;
        this.SpeakerNameText.X = 4f;
        this.SpeakerNameText.XUnits = global::Gum.Converters.GeneralUnitType.Percentage;
        this.SpeakerNameText.Y = 2f;
        this.SpeakerNameText.YUnits = global::Gum.Converters.GeneralUnitType.Percentage;

        this.SpeakerName.Alpha = 195;
        this.SpeakerName.Blue = 82;
        this.SpeakerName.Green = 0;
        this.SpeakerName.Height = 20f;
        this.SpeakerName.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
        this.SpeakerName.Red = 0;
        this.SpeakerName.SourceFileName = @"ExampleSpriteFrame.png";
        this.SpeakerName.Width = 146f;
        this.SpeakerName.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
        this.SpeakerName.X = 48f;
        this.SpeakerName.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
        this.SpeakerName.XUnits = global::Gum.Converters.GeneralUnitType.PixelsFromSmall;
        this.SpeakerName.Y = 346f;
        this.SpeakerName.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
        this.SpeakerName.YUnits = global::Gum.Converters.GeneralUnitType.PixelsFromSmall;

ButtonContinue.ButtonCategoryState = ButtonIcon.ButtonCategory.Focused;
        this.ButtonContinue.Visual.X = 269f;
        this.ButtonContinue.Visual.Y = 61f;

    }
    partial void CustomInitialize();
}
