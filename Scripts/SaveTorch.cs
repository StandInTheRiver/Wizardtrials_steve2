using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTorch : MonoBehaviour
{
    public Animator Anim;
    public bool we_saved = false;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collider Triggered");
        if (other.CompareTag("Player"))
        {
            if (we_saved == false)
            {
                Debug.Log("Collider Was Player");
                // Save Player Location
                SaveGame(other.transform.position);
                Anim.SetBool("ON", true);
            }


        }
    }
    
    public void SaveGame(Vector3 position)
    {

        FindObjectOfType<AudioManager>().Play("checkpoint");
        we_saved = true;
            // Player Position
            Debug.Log($"Saving Player Position: {position.x}:{position.y}:{position.z}");
            PlayerPrefs.SetFloat("player.location.x", position.x);
            PlayerPrefs.SetFloat("player.location.y", position.y);
            PlayerPrefs.SetFloat("player.location.z", position.z);
            // Keyboard Settings
            // Controller Settings
            // Player Progress? Boss Fight / Items / Health / Stamina
        


    }
}
