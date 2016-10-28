using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money_Text : MonoBehaviour {

        
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Shadow : " + Stat.Money;
	}
}
