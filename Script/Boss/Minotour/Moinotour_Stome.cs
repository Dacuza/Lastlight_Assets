using UnityEngine;
using System.Collections;

public class Moinotour_Stome : MonoBehaviour
{

    public static bool isStomin;
    double delay;
    public GameObject stome_Effect;
    GameObject effect;
    GameObject effect2;

    void Update()
    {
        if (isStomin == true)
        {
          //  effect = Instantiate(stome_Effect, new Vector2(this.transform.position.x-2, transform.position.y - 1), Quaternion.identity) as GameObject;
               effect2 = Instantiate(stome_Effect, new Vector2(this.transform.position.x, transform.position.y - 1), Quaternion.EulerRotation(0,GetComponentInParent<Transform>().rotation.y-180,0)) as GameObject;
        
            isStomin = false;


        }
        if (delay >= 0)
            delay -= Time.deltaTime;



    }


    void OnTriggerEnter2D(Collider2D coi)
    {
        if (coi.gameObject.tag == "Element"&& delay <=0&& GetComponentInParent<Animator>().GetBool("isStun"))
        {
            
            SmoothingCamera.shake = 0.3f;
            Stat.hp -= 20;
            isStomin = true;
            delay = 3;
           
        }





    }

    void stomeEffect()
    {

    }




}
   



