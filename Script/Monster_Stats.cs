using UnityEngine;
using System.Collections;

public class Monster_Stats : MonoBehaviour {

    public int monsterHp;
    public int moneydrop;
    public GameObject coinStyle;
     Animator animate;
    bool isCoinDrop = false;
    public bool isDead = false;
    public GameObject Head;
    public float AttackedDelay;
    public float stunedTime;

    void Start()
    {
        
        animate = GetComponent<Animator>();
        

    }


    void Update()
    {

        if(AttackedDelay >0)
        {
            AttackedDelay -= Time.deltaTime;
            if(AttackedDelay <= 0)
            {
                animate.SetBool("isAttacked", false);
            }
        }


        if(monsterHp >0 && gameObject.tag == "Boss")
        {
            Stat.isBossdie = false;
        }
        

        if (monsterHp <= 0)
        {
            monsterHp = 0;

            if (gameObject.tag == "Monster" )
            {
                Killandopen.current += 1;
                if (!isCoinDrop)
                {
                    

                    GameObject coinclone = Instantiate(coinStyle,this.gameObject.transform.position,Quaternion.identity) as GameObject;
                    
                
                    coinclone.GetComponent<CoinScript>().setcoinValue(moneydrop);
                    if (Head != null)
                    {
                        GameObject cloneHead = Instantiate(Head, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity) as GameObject;
                        cloneHead.AddComponent<Rigidbody2D>();
                        cloneHead.AddComponent<CircleCollider2D>();
                        cloneHead.GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 500));
                        Destroy(cloneHead, 3);
                    }
                    isCoinDrop = true;
                    isDead = true;
                }
                animate.SetBool("isDead", true);


                Destroy(this.gameObject,2f);
            }

            if (gameObject.tag == "Boss")
            {
                Stat.isBossdie = true;
                if (!isCoinDrop)
                {


                    GameObject coinclone = Instantiate(coinStyle, this.gameObject.transform.position, Quaternion.identity) as GameObject;


                    coinclone.GetComponent<CoinScript>().setcoinValue(moneydrop);
                    if (Head != null)
                    {
                        GameObject cloneHead = Instantiate(Head, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity) as GameObject;
                        cloneHead.AddComponent<Rigidbody2D>();
                        cloneHead.AddComponent<CircleCollider2D>();
                        cloneHead.GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 500));
                        Destroy(cloneHead, 3);
                    }
                    isCoinDrop = true;
                    isDead = true;
                }
                animate.SetBool("isWalk", false);
                animate.SetBool("isAttack", false);
                animate.SetBool("isStun", false);
                animate.SetBool("isDead", true);


                Destroy(this.gameObject, 4f);
            }
        }

        

    }


    public void GetHit()
    {
        animate.SetBool("isAttacked", true);
        AttackedDelay = stunedTime;

    }

}
