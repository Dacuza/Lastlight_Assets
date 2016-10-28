using UnityEngine;
using System.Collections;

public class Player_Weapon : MonoBehaviour {

    int outputDamage;
    void OnTriggerEnter2D(Collider2D coi)
    {

        Debug.Log("Hit");
        if (coi.gameObject.tag == "Monster" || coi.gameObject.tag == "Boss")
        {

            coi.gameObject.GetComponent<Monster_Stats>().GetHit();
           outputDamage = Random.Range(Stat.Damage - 2, Stat.Damage + 5);

            coi.GetComponent<Monster_Stats>().monsterHp -= outputDamage;
        }

    }
}
