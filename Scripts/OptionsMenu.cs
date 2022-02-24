using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public TMP_Dropdown gameDifficultyDropdown;
    List<string> difficulty = new List<string>() {"Easy", "Medium", "Hard"};

    public Slider EffectsVolumeSlider;
    public Slider MusicVolumeSlider;

    public TMP_Text EffectsVolumeLabel;
    public TMP_Text MusicVolumeLabel;

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
        FindObjectOfType<AudioManager>().change_volume();
        //FindObjectOfType<AudioManager>().set_settings();
    }

    private void setDefaultFocus()
    {
        Button btn = GameObject.Find("BackButton").GetComponent<Button>();
        EventSystem es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        es.SetSelectedGameObject(btn.gameObject);
    }

    void Start()
    {
        PopulateGameDifficultyList();
        // Get current setting or set defaults
        if (!PlayerPrefs.HasKey("game.audio.effects"))
        {
            float defaultEffectsVol = 50;
            Debug.Log($"Setting Default Effects Audio Volume: {defaultEffectsVol}");
            UpdateEffectsVolume(defaultEffectsVol);
        }

        if (!PlayerPrefs.HasKey("game.audio.music"))
        {
            float defaultMusicVol = 50;
            Debug.Log($"Setting Default Music Audio Volume: {defaultMusicVol}");
            UpdateMusicVolume(defaultMusicVol);
        }

        EffectsVolumeSlider.value = PlayerPrefs.GetFloat("game.audio.effects");
        MusicVolumeSlider.value = PlayerPrefs.GetFloat("game.audio.music");
    }

    void PopulateGameDifficultyList()
    {
        gameDifficultyDropdown.AddOptions(difficulty);
        // Get current setting or set defaults
        if (PlayerPrefs.HasKey("game.difficulty"))
        {
            gameDifficultyDropdown.value = PlayerPrefs.GetInt("game.difficulty");
        }
        else
        {
            gameDifficultyDropdown.value = 0;
        }
    }

    public void UpdateDifficulty(int idx)
    {
        var newDiff = difficulty[idx];
        Debug.Log($"New Game Difficulty Set: {idx}/{newDiff}");
        PlayerPrefs.SetInt("game.difficulty", idx);
    }

    public void UpdateEffectsVolume(Single newVol)
    {
        Debug.Log($"New Effects Volume: {newVol}");
        PlayerPrefs.SetFloat("game.audio.effects", newVol);
        UpdateEffectsVolumeLabel();
    }

    public void UpdateMusicVolume(Single newVol)
    {
        Debug.Log($"New Music Volume: {newVol}");
        PlayerPrefs.SetFloat("game.audio.music", newVol);
        UpdateMusicVolumeLabel();
    }

    public void UpdateEffectsVolumeLabel()
    {
        float effectsVol = PlayerPrefs.GetFloat("game.audio.effects");
        Debug.Log($"New Effects Volume Label: {effectsVol}");
        EffectsVolumeLabel.text = effectsVol.ToString();
    }

    public void UpdateMusicVolumeLabel()
    {
        float musicVol = PlayerPrefs.GetFloat("game.audio.music");
        Debug.Log($"New Music Volume Label: {musicVol}");
        MusicVolumeLabel.text = musicVol.ToString();
    }
}