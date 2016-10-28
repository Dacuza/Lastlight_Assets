using UnityEngine;
using System.Collections;

public class Ai_HardGolem : MonoBehaviour {

    Animator animate;
    public GameObject Hpbar;
    //  int Hp;
    public int Dmg;
    public int Speed;
    public bool isPlayerClose;
    public float atkdelay;
    public float skilldelay;
    GameObject player;
    // Use this for initialization
    void Start()
    {

        isPlayerClose = false;
        player = GameObject.Find("Player");
        animate = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if (isPlayerClose == true)
        {
            if (player.transform.position.x <= transform.position.x && animate.GetBool("isAttack") == false  )
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.Translate(new Vector3(-Speed * Time.deltaTime, 0));
                animate.SetBool("isWalk", true);


            }

            if (player.transform.position.x >= transform.position.x && animate.GetBool("isAttack") == false )
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                transform.Translate(new Vector3(-Speed * Time.deltaTime, 0));
                animate.SetBool("isWalk", true);


            }

            if ((player.transform.position.x - transform.position.x) <= 5 && player.transform.position.x - transform.position.x >= 4 && atkdelay <= 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", true);
                atkdelay = 2.1f;
            }
            else if ((transform.position.x - player.transform.position.x) <= 5 && (transform.position.x - player.transform.position.x) >= 4 && atkdelay <= 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                //Debug.Log((transform.position.x - player.transform.position.x) + "  " + (transform.position.x - player.transform.position.x));
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", true);
                atkdelay = 2.1f;
            }

            if ((player.transform.position.x - transform.position.x) <= 4 && player.transform.position.x - transform.position.x >= 1 && atkdelay <= 0 && skilldelay <= 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", true);
            
                skilldelay = 2f;
            }
            else if ((transform.position.x - player.transform.position.x) <= 4 && (transform.position.x - player.transform.position.x) >= 1 && atkdelay <= 0 && skilldelay <= 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                //Debug.Log((transform.position.x - player.transform.position.x) + "  " + (transform.position.x - player.transform.position.x));
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", true);
      
                skilldelay = 2f;

            }


            if (atkdelay >= 0)
            {
                atkdelay -= Time.deltaTime;


                if (atkdelay <= 0)
                {
                    animate.SetBool("isAttack", false);
         

                }



            }
            if (skilldelay >= 0)
            {
                skilldelay -= Time.deltaTime;


                if (skilldelay <= 0)
                {
                    animate.SetBool("isAttack", false);
                    

                }



            }
         
                Hpbar.SetActive(true);
            if (Mathf.Abs(player.transform.position.x - transform.position.x) >= 20)
                isPlayerClose = false;




        }



        if (isPlayerClose == false)
        {
            animate.SetBool("isWalk", false);
            animate.SetBool("isAttack", false);

            Hpbar.SetActive(false);

            if (Mathf.Abs(player.transform.position.x - transform.position.x) <= 20)
                isPlayerClose = true;

        }




    }





}
