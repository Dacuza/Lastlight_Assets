using UnityEngine;
using System.Collections;

public class Bosshp_bar : MonoBehaviour {

    RectTransform rect;
    public GameObject boss;
    float mhp;

    // Use this for initialization
    void Start()
    {
        mhp = boss.GetComponent<Monster_Stats>().monsterHp;
        rect = GetComponent<RectTransform>();


    }

    // Update is called once per frame
    void Update()
    {
        if (boss.GetComponent<Monster_Stats>().monsterHp <= 0)
            Destroy(this.gameObject);

       
        
        rect.sizeDelta = new Vector2(((Screen.width / mhp) * boss.GetComponent<Monster_Stats>().monsterHp ) - 40, 30);


    }
}