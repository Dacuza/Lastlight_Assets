using UnityEngine;
using System.Collections;

public class Shop_Controller : MonoBehaviour
{

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;

    public static int UpDamage;
    public static int UpDef;
    public static int UpStamina;



    int selectchoice = 0;
    // Use this for initialization
    void Start()
    {
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
        {
        UpDamage = Stat.Damage * 7;
        UpDef = Stat.mhp * 2;
        UpStamina = Stat.mstamina * 2;


            if (selectchoice == 0)
            {
                s1.SetActive(true);
                s2.SetActive(false);
                s3.SetActive(false);
            }
            if (selectchoice == 1)
            {
                s1.SetActive(false);
                s2.SetActive(true);
                s3.SetActive(false);
            }
            if (selectchoice == 2)
            {
                s1.SetActive(false);
                s2.SetActive(false);
                s3.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
              
                if (selectchoice == 2)
                    selectchoice = 0;
                else
                    selectchoice++;

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (selectchoice == 0)
                    selectchoice = 2;
                else
                    selectchoice--;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {



                if (selectchoice == 0)
                {
                    Stat.Money -= UpDamage;
                    Stat.Damage += 5;
                }
                if (selectchoice == 1)
                {

                    Stat.Money -= UpDef;
                    Stat.mhp += 20;
                Stat.hp = Stat.mhp;
                Debug.Log(Stat.mhp);
                Debug.Log(Stat.hp);

                }
                if (selectchoice == 2)
                {
                    Stat.Money -= UpStamina;
                    Stat.mstamina += 20;
                }



            }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<PlayerController>().enabled = true;
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(false);
            GetComponent<Shop_Controller>().enabled = false;
        }
        }
    

    }

