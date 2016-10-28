using UnityEngine;
using System.Collections;

public class Ai_Golem : MonoBehaviour {

    Animator animate;
    int Hp;
    public int Dmg;
    public int Speed;
    bool isPlayerClose;
    float atkdelay;
    GameObject player;
    // Use this for initialization
    void Start()
    {

        isPlayerClose = false;
        player = GameObject.Find("Player");
        animate = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if (isPlayerClose == true && !GetComponent<Monster_Stats>().isDead)
        {
            if (player.transform.position.x <= transform.position.x && animate.GetBool("isAttack") == false && !animate.GetBool("isAttacked"))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.Translate(new Vector3(-Speed * Time.deltaTime, 0));
                animate.SetBool("isWalk", true);


            }

            if (player.transform.position.x >= transform.position.x && animate.GetBool("isAttack") == false && !animate.GetBool("isAttacked"))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                transform.Translate(new Vector3(-Speed * Time.deltaTime, 0));
                animate.SetBool("isWalk", true);


            }

            if ((player.transform.position.x - transform.position.x) <= 3 && player.transform.position.x - transform.position.x >= 1 && atkdelay <= 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", true);
                atkdelay = 2.3f;
            }
            else if ((transform.position.x - player.transform.position.x) <= 3 && (transform.position.x - player.transform.position.x) >= 1 && atkdelay <= 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                //Debug.Log((transform.position.x - player.transform.position.x) + "  " + (transform.position.x - player.transform.position.x));
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", true);
                atkdelay = 2.3f;
            }

            if (atkdelay >= 0)
            {
                atkdelay -= Time.deltaTime;


                if (atkdelay <= 0)
                {
                    animate.SetBool("isAttack", false);


                }



            }

            if (player.transform.position.x - transform.position.x >= 10)
                isPlayerClose = false;




        }



        if (isPlayerClose == false)
        {


            if (Mathf.Abs(player.transform.position.x - transform.position.x) <= 20)
                isPlayerClose = true;

        }




    }



}
