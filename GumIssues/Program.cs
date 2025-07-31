using var game = new GumIssues.Game1(
    new GumIssues.GameConfig()
    {
        title = "Chaos Gears",
        renderWidth = 640,
        renderHeight = 480,
        resolutionWidth = 640,
        resolutionHeight = 480,
        fullscreen = false,
    }
);
game.Run();
