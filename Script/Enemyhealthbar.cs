using UnityEngine;
using System.Collections;

public class Enemyhealthbar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(GetComponentInParent<Transform>().position.x, this.transform.position.y);
        transform.localScale = new Vector3(0.1f * GetComponentInParent<Monster_Stats>().monsterHp, 0.3f);
	
	}
}
