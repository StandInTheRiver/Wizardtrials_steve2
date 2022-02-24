using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
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
    }

    private void OnDisable()
    {

    }

    private void setDefaultFocus()
    {
        Button btn = GameObject.Find("OptionsButton").GetComponent<Button>();
        EventSystem es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        es.SetSelectedGameObject(btn.gameObject);
    }

    public void PlayGame()
    {
        ClearSave();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ClearSave()
    {
        // Player Position
        PlayerPrefs.DeleteKey("player.location.x");
        PlayerPrefs.DeleteKey("player.location.y");
        PlayerPrefs.DeleteKey("player.location.z");
        // Player Stats
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    void Start()
    {

    }
}