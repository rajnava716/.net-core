namespace ImportProgressBar;

public static class ProgressStorage
{
    private static int progress;

    public static int GetProgress()
        return progress;
    }

    public static void SetProgress(int newProgress)
    {
        progress = newProgress;
    }
}

