using UnityEngine;
using System.Collections;

public class IsBossDie : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        if (Stat.isBossdie)
            Destroy(this.gameObject);
	
	}
}
