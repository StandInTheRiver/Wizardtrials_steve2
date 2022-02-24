using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CM : MonoBehaviour
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

    private void setDefaultFocus()
    {
        Button btn = GameObject.Find("BackButton").GetComponent<Button>();
        EventSystem es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        es.SetSelectedGameObject(btn.gameObject);
    }
}