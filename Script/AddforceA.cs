using UnityEngine;
using System.Collections;

public class AddforceA : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(50*Time.deltaTime,0));
	}
    

    void OnCollisionEnter2D(Collision2D coi)
    {
        if (coi.gameObject.tag == "Monster"||coi.gameObject.tag == "Boss")
            GetComponent<BoxCollider2D>().isTrigger = true;
        if (coi.gameObject.tag == "Player")
            Stat.hp -= 3;
    }

    void OnTriggerEnter2D(Collider2D coi)
    {
        if (coi.gameObject.tag == "Player")
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
