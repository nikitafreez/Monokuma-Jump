using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSctript : MonoBehaviour
{
    public GameObject mainMenu, GameUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void ExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }

    public void StartClick()
    {
        mainMenu.SetActive(false);
        GameUI.SetActive(true);
        Time.timeScale = 1f;
    }
}
