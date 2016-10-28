using UnityEngine;
using System.Collections;

public class Minotour_Weapon : MonoBehaviour {

    public GameObject bloodEff;
    void OnTriggerEnter2D(Collider2D coi)
    {
    
            SmoothingCamera.shake = 0.3f;
        if (coi.gameObject.tag == "Player" && coi.gameObject.GetComponentInChildren<Animator>().GetBool("isRoll") == false && GetComponentInParent<Ai_Minotour>().atkdelay >=1f)
        {
            Stat.hp -= gameObject.GetComponentInParent<Ai_Minotour>().Dmg;
            GameObject blood = Instantiate(bloodEff, coi.gameObject.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
