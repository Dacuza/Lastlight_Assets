using UnityEngine;
using System.Collections;

public class DestorySelfIn : MonoBehaviour {

    public float duration;
	// Use this for initialization
	void Start () {

        Destroy(this.gameObject, duration);
	
	}
	

}
