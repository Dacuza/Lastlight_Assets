using UnityEngine;
using System.Collections;

public class StaminaCoverBar_Script : MonoBehaviour {

    RectTransform rect;

    // Use this for initialization
    void Start()
    {

        rect = GetComponent<RectTransform>();


    }

    // Update is called once per frame
    void Update()
    {

        rect.sizeDelta = new Vector2((((Screen.width / 3.8f) / Stat.mstamina) * Stat.mstamina)+10, 20);

    }
}
