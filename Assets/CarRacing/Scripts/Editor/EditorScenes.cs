public enum EditorScenes
{
    MainMenu,
    race_track_lake_1,
    race_track_lake_2,
    T3,
    LevelComplete,
    Garage_Scene,
}

public static class ScenesExtensions
{
    public static string Name(this EditorScenes scene)
    {
        switch (scene)
        {
            case EditorScenes.MainMenu:
                return "MainMenu";
            case EditorScenes.race_track_lake_1:
                return "race_track_lake_1";
            case EditorScenes.race_track_lake_2:
                return "race_track_lake_2";
            case EditorScenes.T3:
                return "T3";
            case EditorScenes.LevelComplete:
                return "LevelComplete";
            case EditorScenes.Garage_Scene:
                return "Garage_Scene";
            default:
                return "Scene Not Found";
        }
    }
}