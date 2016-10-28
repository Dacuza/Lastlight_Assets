using UnityEngine;
using System.Collections;

public class Cheat : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            Stat.mhp += 10;
            Stat.hp = Stat.mhp;
             

        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            Stat.Damage = 100;
        }



    }
}