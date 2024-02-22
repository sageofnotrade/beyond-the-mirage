using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader{

    public enum Scene {
        TitleScreen,
        IntroScreen,
        SettingsScreen
    }
    public static void Load(Scene scn) {
        
        SceneManager.LoadScene(scn.ToString());
    }

}