using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    void Start(){
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update(){
        if (Input.anyKey){
            Loader.Load(Loader.Scene.TitleScreen);
        }
    }
}
