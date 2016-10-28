using UnityEngine;
using System.Collections;

public class Golem_gauntlet : MonoBehaviour {

    public GameObject bloodEff;
    void OnTriggerEnter2D(Collider2D coi)
    {

        SmoothingCamera.shake = 0.3f;
        if (coi.gameObject.tag == "Player" && coi.gameObject.GetComponentInChildren<Animator>().GetBool("isRoll") == false && GetComponentInParent<Ai_HardGolem>().atkdelay >= 1f)
        {

            if (coi.transform.position.x > this.transform.position.x)
                coi.gameObject.transform.Translate(new Vector3(3, 0));
            else if (coi.transform.position.x < this.transform.position.x)
                coi.gameObject.transform.Translate(new Vector3(-3, 0));

            Stat.hp -= gameObject.GetComponentInParent<Ai_HardGolem>().Dmg;
            
            GameObject blood = Instantiate(bloodEff, coi.gameObject.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
