using UnityEngine;
using System.Collections;

public class Golem_Knuckle : MonoBehaviour {
    public GameObject bloodEff;


    Animator animate;



    void Start()
    {
        animate = GetComponentInParent<Animator>();



    }


    void OnTriggerEnter2D(Collider2D coi)
    {


        if (coi.gameObject.tag == "Player" && coi.gameObject.GetComponentInChildren<Animator>().GetBool("isRoll") == false&&animate.GetBool("isAttack"))
        {
            if (coi.transform.position.x > this.transform.position.x)
                coi.gameObject.transform.Translate(new Vector3(3, 0));
            else if (coi.transform.position.x < this.transform.position.x)
                coi.gameObject.transform.Translate(new Vector3(-3, 0));
            Stat.hp -= gameObject.GetComponentInParent<Ai_Golem>().Dmg;
            GameObject blood = Instantiate(bloodEff, coi.gameObject.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
