using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public Animator anime;
    public float trTime = 1.1f;
    void Start(){
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update(){
        if (Input.anyKey){
            StartCoroutine(TransitionToMainMenu());
        }
    }

    IEnumerator TransitionToMainMenu(){
        anime.SetTrigger("AnyKey");

        yield return new WaitForSeconds(trTime);

        Loader.Load(Loader.Scene.TitleScreen);
    }
}
