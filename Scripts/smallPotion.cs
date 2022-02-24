﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallPotion : MonoBehaviour
{
    public Animator Anim;
    public Player_getshit playerH;
    public Hero_Controller playerM;
    public bool Health_OR_Mana;

    public int PotionValueH = 15;
    public int PotionValueM = 20;

    // Start is called before the first frame update
    void Start()
    {
        playerH = GameObject.FindGameObjectWithTag("Player_self_hitbox").GetComponent<Player_getshit>();
        playerM = GameObject.FindGameObjectWithTag("Player").GetComponent<Hero_Controller>();
        Anim = GetComponent<Animator>();
        Anim.SetBool("Health_OR_Mana", Health_OR_Mana);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("smallPotion Collider Triggered");

        if (Health_OR_Mana)
        {
            Debug.Log("Small Mana Potion Collider Triggered");
            if (other.CompareTag("Player") && playerM.hero_current_mana != playerM.hero_max_mana)
            {
                Debug.Log("Small Mana Potion Taken");
                // Play Disappear Animation
                Anim.SetBool("Taken", true);
            }
        }
        else
        {
            Debug.Log("Small Health Potion Collider Triggered");
            if (other.CompareTag("Player") && playerH.player_current_health != playerH.player_max_health)
            {
                Debug.Log("Small Health Potion Taken");
                // Play Disappear Animation
                Anim.SetBool("Taken", true);
            }
        }
    }

    // PotionTaken is called by the last frame of potionDisappear Animation
    public void PotionTaken()
    {
        // Destroy Potion Object
        Destroy(gameObject);

        if (Health_OR_Mana)
        {
            // Update Player Mana
            if (playerM.hero_current_mana == playerM.hero_max_mana)
            {
                return;
            }

            if (playerM.hero_current_mana + PotionValueM >= playerM.hero_max_mana)
            {
                FindObjectOfType<AudioManager>().Play("get_potion_mana_small");
                playerM.hero_current_mana = playerM.hero_max_mana;
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("get_potion_mana_small");
                playerM.hero_current_mana += PotionValueM;
            }
        }
        else
        {
            // Update Player Health
            if (playerH.player_current_health == playerH.player_max_health)
            {
                return;
            }

            if (playerH.player_current_health + PotionValueH >= playerH.player_max_health)
            {
                FindObjectOfType<AudioManager>().Play("get_potion_health_small");
                playerH.player_current_health = playerH.player_max_health;
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("get_potion_health_small");
                playerH.player_current_health += PotionValueH;
            }
        }
    }
}