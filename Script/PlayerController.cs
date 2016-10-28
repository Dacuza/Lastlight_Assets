    using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public int moveSpeed;

    bool dashLeft;
    bool dashRight;

    Component shop;


    Animator animate;

    public static int selectchoice;

    float restaminacoolDown;

    public int hp;
    public int damage;
    public int stamina;
    public bool isFrontShop = false;
    public Camera mainc;
    public bool isEnterShop = false;


    double rundelay;
    double r2delay;
    double rdelay = 1;
    double cooldown;

    Movement PlayerMove;

    // Use this for initialization
    void Start()
    {
        PlayerMove = new Movement(this.gameObject);
        animate = GetComponentInChildren<Animator>();
        shop = GetComponent<Shop_Controller>();
        Stat.mhp = hp;
        Stat.mstamina = stamina;
        Stat.Damage = damage;
        GetComponent<Shop_Controller>().enabled = false;



    }

    // Update is called once per frame
    void Update()
    {
        damage = Stat.Damage;
        hp = Stat.mhp;
        stamina = Stat.stamina;








        if (Input.GetKey(KeyCode.RightArrow) && !animate.GetBool("isAttack") && dashRight == false && dashLeft == false && r2delay <= 0 && animate.GetBool("isRoll") == false)
        {

            animate.SetBool("isWalk", true);

            //transform.Translate(10, 0, 0);
            if (animate.GetBool("isRun") == false)
                PlayerMove.moveForward(moveSpeed);
            if (Input.GetKeyDown(KeyCode.LeftShift) && dashRight == false && dashLeft == false && Stat.stamina >= 10)
            {
                dashRight = true;
                animate.SetBool("isRoll", true);
                rdelay = 0.2;
                r2delay = 0.4;
                Stat.stamina -= 10;
                restaminacoolDown = 2;
                GetComponent<BoxCollider2D>().isTrigger = true;

            }

            if (Input.GetKey(KeyCode.C) && animate.GetBool("isWalk") == true)
            {

                animate.SetBool("isRun", true);
                PlayerMove.moveForward(moveSpeed + 3);

            }
        }

        if (dashRight == true)
        {
            transform.Translate(new Vector3(40 * Time.deltaTime, 0, 0));
            rdelay -= Time.deltaTime;

            if (rdelay <= 0)
            {

                dashRight = false;
                GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }



        if (Input.GetKey(KeyCode.LeftArrow) && !animate.GetBool("isAttack") && dashRight == false && dashLeft == false && r2delay <= 0 && animate.GetBool("isRoll") == false)
        {
            animate.SetBool("isWalk", true);
            //transform.Translate(10, 0, 0);
            PlayerMove.moveBack(moveSpeed);
            if (Input.GetKeyDown(KeyCode.LeftShift) && dashRight == false && dashLeft == false && Stat.stamina >= 10)
            {

                dashLeft = true;
                animate.SetBool("isRoll", true);
                rdelay = 0.2;
                r2delay = 0.4;
                Stat.stamina -= 10;
                restaminacoolDown = 2;
                GetComponent<BoxCollider2D>().isTrigger = true;

            }

            if (Input.GetKey(KeyCode.C) && animate.GetBool("isWalk") == true)
            {

                animate.SetBool("isRun", true);
                PlayerMove.moveBack(moveSpeed + 3);

            }
        }
        if (dashLeft == true)
        {
            transform.Translate(new Vector3(40 * Time.deltaTime, 0, 0));
            rdelay -= Time.deltaTime;

            if (rdelay <= 0)
            {

                dashLeft = false;
                GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }

        if (r2delay >= 0)
        {
            r2delay -= Time.deltaTime;
            if (r2delay <= 0)
                animate.SetBool("isRoll", false);

        }

        if (restaminacoolDown >= 0)

            restaminacoolDown -= Time.deltaTime;

        if (restaminacoolDown <= 0 && Stat.stamina < Stat.mstamina)
            Stat.stamina += 1;
        if (!isFrontShop)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !animate.GetBool("isAttack") && Stat.stamina >= 15)
            {

                restaminacoolDown = 2;
                Stat.stamina -= 15;
                animate.SetBool("isAttack", true);
                cooldown = 1.06;
            }
            if (Input.GetKeyDown(KeyCode.Space) && cooldown > 0.0)
            {
                animate.SetBool("isCombo1", true);
                cooldown = 0.5;

            }


        }
        else if (isFrontShop)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Shop_Controller>().enabled = true;
                GetComponent<PlayerController>().enabled = false;
                isEnterShop = true;
            }

        }



        if (animate.GetBool("isAttack"))
        {
            cooldown -= Time.deltaTime;
            if (cooldown <= 0)
            {
                animate.SetBool("isEnd_hit", true);


                animate.SetBool("isCombo1", false);
                animate.SetBool("isAttack", false);
            }

        }






        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animate.SetBool("isWalk", false);
            animate.SetBool("isRun", false);


        }





    }

    void OnColiisionEnter2D(Collision2D coi)
    {
        if (coi.gameObject.tag == "CantPassR")
        {
            Debug.Log("Aw");

            this.transform.position = new Vector3(this.transform.position.x - 5, this.transform.position.y);
        }
        if (coi.gameObject.tag == "CantPassL")
        {
            Debug.Log("Aw");

            this.transform.position = new Vector3(this.transform.position.x + 5, this.transform.position.y);
        }

    }

    void OnTriggerEnter2D(Collider2D coi)
    {
        if (coi.gameObject.tag == "CantPassR")
        {
            Debug.Log("Aw");
            this.transform.position = new Vector3(this.transform.position.x - 5, this.transform.position.y);
        }
        if (coi.gameObject.tag == "CantPassL")
        {
            Debug.Log("Aw");
            this.transform.position = new Vector3(this.transform.position.x + 5, this.transform.position.y);
        }
        if (coi.gameObject.tag == "Shop")
        {
            mainc.GetComponent<SmoothingCamera>().target = coi.gameObject.transform;
            mainc.GetComponent<SmoothingCamera>().x = 0;
            mainc.GetComponent<SmoothingCamera>().y = 4;
            mainc.GetComponent<SmoothingCamera>().z = 50;

            isFrontShop = true;

        }
    }




    void OnTriggerExit2D(Collider2D coi)
    {
        if (coi.gameObject.tag == "Shop")
        {
            mainc.GetComponent<SmoothingCamera>().x = 6;
            mainc.GetComponent<SmoothingCamera>().y = 4;
            mainc.GetComponent<SmoothingCamera>().z = 120;
            mainc.GetComponent<SmoothingCamera>().target = this.transform;
            isFrontShop = false;

        }
    }





}
