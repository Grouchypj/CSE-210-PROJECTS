class MadlibGame
{
    private MadlibGenerator madlibGenerator;
    private StoryDisplay storyDisplay;
    private UserScoreTracker userScoreTracker;
    private ThemeSelector themeSelector;
    private StoryArchive storyArchive;

    public MadlibGame()
    {
        // not totally done yet might change
        MadlibTemplateManager templateManager = new MadlibTemplateManager();
        WordInputManager wordInputManager = new WordInputManager();
        madlibGenerator = new MadlibGenerator(templateManager, wordInputManager);
        storyDisplay = new StoryDisplay();
        userScoreTracker = new UserScoreTracker();
        themeSelector = new ThemeSelector();
        storyArchive = new StoryArchive();
    }

    public void PlayMadlibGame()
    {
        
        List<Word> words = new List<Word>
        {
            new Noun("dog"),
            new Adjective("funny"),
            // going to add more words here later
        };

        string generatedStory = madlibGenerator.GenerateMadlib(words);
        storyDisplay.DisplayStory(generatedStory);
        userScoreTracker.UpdateScore();
        themeSelector.SelectTheme();
        storyArchive.ArchiveStory();
    }
}