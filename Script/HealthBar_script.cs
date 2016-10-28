using UnityEngine;
using System.Collections;

public class HealthBar_script : MonoBehaviour {

    RectTransform rect;

	// Use this for initialization
	void Start () {

        rect = GetComponent<RectTransform>();


    }
	
	// Update is called once per frame
	void Update () {

        rect.sizeDelta = new Vector2(((Screen.width/3)/Stat.mhp)*Stat.hp, 20);

    }
}
