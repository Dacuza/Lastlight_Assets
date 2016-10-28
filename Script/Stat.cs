using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stat : MonoBehaviour {

    public static int mhp;
    public static int hp;
    public static int mstamina;
    public static int stamina;
    public static int Damage;
    public static int Defend;
    public static int Money = 9999999;
    public static bool isBossdie = true;
    public static int CurrentState = 0;
    Scene thisScene;
    string Scenename;
    void Start()
    {
        Debug.Log(Stat.mhp);
        Debug.Log(Stat.hp);
      //  mhp = 50;
        Debug.Log(Stat.mhp);
        Debug.Log(Stat.hp);
        Stat.hp = mhp;
      //  Stat.mstamina = 100;
        Stat.stamina = mstamina;
     //   Stat.Damage = 10;
       // Stat.Defend = 10;
    }

    void Update()
    {


     

        if (hp <= 0)
            SceneManager.LoadScene(Application.loadedLevel);
    }

}
