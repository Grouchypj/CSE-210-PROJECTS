class MadlibGenerator
{
    private MadlibTemplateManager templateManager;
    private WordInputManager wordInputManager;
    private UserScoreTracker userScoreTracker;
    private ThemeSelector themeSelector;
    private StoryArchive storyArchive;

    public MadlibGenerator(MadlibTemplateManager templateManager, WordInputManager wordInputManager)
    {
        this.templateManager = templateManager;
        this.wordInputManager = wordInputManager;
    }

    public void SetCollaborators(UserScoreTracker userScoreTracker, ThemeSelector themeSelector, StoryArchive storyArchive)
    {
        this.userScoreTracker = userScoreTracker;
        this.themeSelector = themeSelector;
        this.storyArchive = storyArchive;
    }

    public string GenerateMadlib(List<Word> words)
    {
        string template = templateManager.GetRandomTemplate();
        foreach (var word in words)
        {
            string userInput = wordInputManager.GetUserInput($"Enter a {word.GetType().Name}: ");
            template = template.Replace($"{{{word.GetType().Name}}}", userInput);
        }
        return template;
    }
}