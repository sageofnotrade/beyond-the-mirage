using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    
    void Start()
    {
        Texture2D cursor = Resources.Load<Texture2D>("Cursor/cursor");
        Vector2 hotspot = new(0, cursor.height - 1);

        Cursor.SetCursor(cursor, hotspot, CursorMode.Auto);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;

        GameObject canvas = GameObject.Find("Buttons");
        Button[] buttons = canvas.GetComponentsInChildren<Button>();

        foreach (Button button in buttons){
            if (button.name == "Start")
                button.onClick.AddListener(ToC);
            else if (button.name == "Settings")
                button.onClick.AddListener(Settings);
            else if (button.name == "Quit")
                button.onClick.AddListener(Quit);
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void ToC(){
        //Loader.Load(Table of Contents / Character Selection Scene)
    }

    void Settings(){
        Loader.Load(Loader.Scene.SettingsScreen);
    }

    void Quit(){
        Application.Quit();
    }

}
