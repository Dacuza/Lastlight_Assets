using UnityEngine;
using System.Collections;

public class CoverHealhtBar_Script : MonoBehaviour {

    RectTransform rect;

    // Use this for initialization
    void Start()
    {

        rect = GetComponent<RectTransform>();


    }

    // Update is called once per frame
    void Update()
    {

        rect.sizeDelta = new Vector2((((Screen.width / 3f) / Stat.mhp) * Stat.mhp), 32);

    }
}
