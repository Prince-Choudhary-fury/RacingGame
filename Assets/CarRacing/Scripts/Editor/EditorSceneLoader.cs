#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;

public static class EditorSceneLoader
{
    // % = ctrl/cmd
    // # = shift
    // & = alt
    //Example:
    [MenuItem("Scenes/Load MainMenu %1")] // ctrl/cmd + 1
    public static void LoadMainMenu() { openScene(EditorScenes.MainMenu); }
    [MenuItem("Scenes/Load race_track_lake_1 %1")] // ctrl/cmd + 1
    public static void Loadrace_track_lake_1() { openScene(EditorScenes.race_track_lake_1); }

    [MenuItem("Scenes/Load race_track_lake_2")]
    public static void Loadrace_track_lake_2() { openScene(EditorScenes.race_track_lake_2); }

    [MenuItem("Scenes/Load T3")]
    public static void LoadT3() { openScene(EditorScenes.T3); }

    [MenuItem("Scenes/Load LevelComplete")]
    public static void LoadLevelComplete() { openScene(EditorScenes.LevelComplete); }

    [MenuItem("Scenes/Load Garage_Scene")]
    public static void LoadGarage_Scene() { openScene(EditorScenes.Garage_Scene); }

    private const string PATH = "Assets/CarRacing/scenes/";
    private const string SCENE_SUFFIX = ".unity";

    private static void openScene(EditorScenes scene)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            EditorSceneManager.OpenScene(GetScenePath(scene.Name()), OpenSceneMode.Single);
    }

    private static string GetScenePath(string sceneName)
    {
        return PATH + sceneName + SCENE_SUFFIX;
    }
}
#endif