using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Save current player setting
// Format should be something like: 'settingType.settingTitle.settingSubtitle'
// Ex: 'player.location.x' or 'input.controller.jump'
// Game Settings such as volume and difficulty will be saved from 'Menu' Scene
public class SaveSystem : MonoBehaviour
{
    public Transform Player;

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);

        if (scene.name == "Swamp_01")
        {
            LoadSave();
        }
    }

    // called when the game is terminated
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // public void SaveGame()
    // {
    //     // Player Position
    //     var position = Player.position;
    //     Debug.Log($"Saving Player Position: {position.x}:{position.y}:{position.z}");
    //     PlayerPrefs.SetFloat("player.location.x", position.x);
    //     PlayerPrefs.SetFloat("player.location.y", position.y);
    //     PlayerPrefs.SetFloat("player.location.z", position.z);
    //     // Keyboard Settings
    //     // Controller Settings
    //     // Player Progress? Boss Fight / Items / Health / Stamina
    // }

    // Load current player setting
    // Check if setting exists using .Haskey()
    // If key exists use it ELSE set to DEFAULT value
    public void LoadSave()
    {
        FindObjectOfType<AudioManager>().StopPlaying("Boss_theme");
        FindObjectOfType<AudioManager>().play_main_theme();

        // Load Save
        Debug.Log("Loading Save");

        if (Player == null)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            return;
        }

        // Player Position
        if (PlayerPrefs.HasKey("player.location.x") && PlayerPrefs.HasKey("player.location.y") &&
            PlayerPrefs.HasKey("player.location.z"))
        {
            float x = PlayerPrefs.GetFloat("player.location.x");
            float y = PlayerPrefs.GetFloat("player.location.y");
            float z = PlayerPrefs.GetFloat("player.location.z");

            Debug.Log($"Loading Player Position: {x}:{y}:{z}");
            Vector3 posVec = new Vector3(x, y, z);
            Player.position = posVec;
        }
        else
        {
            var Start = new Vector3(-7f, 0.8f, 0f);
            var Test1 = new Vector3(28f, 0.8f, 0f);
            var Boss = new Vector3(251f, 19f, 0f);

            Vector3 newPlayerPosition = Start;
            Debug.Log($"Loading DEFAULT Player Position: {newPlayerPosition.x}:{newPlayerPosition.y}:{newPlayerPosition.z}");
            Player.position = newPlayerPosition;
        }

        // Keyboard & Controller Settings can be directly checked from the player controller
    }
}
