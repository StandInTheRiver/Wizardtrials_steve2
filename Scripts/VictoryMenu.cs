using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    private void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            setDefaultFocus();
        }
    }

    private void OnEnable()
    {
        setDefaultFocus();
        Pause();
    }

    private void setDefaultFocus()
    {
        Button btn = GameObject.Find("MenuButton").GetComponent<Button>();
        EventSystem es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        es.SetSelectedGameObject(btn.gameObject);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu()
    {

        gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        Resume();
    }
}