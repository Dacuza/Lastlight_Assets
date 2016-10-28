using UnityEngine;
using System.Collections;

public class WareWolf_Claw : MonoBehaviour {

    public GameObject bloodEff;
    void OnTriggerEnter2D(Collider2D coi)
    {


        if (coi.gameObject.tag == "Player" && coi.gameObject.GetComponentInChildren<Animator>().GetBool("isRoll") == false)
        {
            if (coi.transform.position.x > this.transform.position.x )
                coi.gameObject.transform.Translate(new Vector3(3, 0));
           else if (coi.transform.position.x < this.transform.position.x)
                coi.gameObject.transform.Translate(new Vector3(-3, 0));
            Stat.hp -= gameObject.GetComponentInParent<Ai_WareWolf>().Dmg;
            GameObject blood = Instantiate(bloodEff, coi.gameObject.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
