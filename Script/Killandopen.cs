using UnityEngine;
using System.Collections;

public class Killandopen : MonoBehaviour {

    public int need;
    public static int current;
    public bool BossGate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (current >= need)
        {
            current = 0;
            Destroy(this.gameObject);
        }
	
	}
}
