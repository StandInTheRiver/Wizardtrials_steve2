using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    Slider healthBar;

    

    float maxHealth = 100;
    float curHealth;
    // Start is called before the first frame update
    void Start()
    {
        var maxHealth1 = maxHealth;
        healthBar.value = maxHealth1;
        curHealth = healthBar.value;

    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "potion-red-1")
        {
            healthBar.value += 1.5f;
            curHealth = healthBar.value;
        }
        
    }

    void Update()
    {
        
    }
}
