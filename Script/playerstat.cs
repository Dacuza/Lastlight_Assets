using UnityEngine;
using System.Collections;

public class playerstat : MonoBehaviour {

   
    public int hp;
    public int stamina;
    public int damage;
    public int def;
    
    // Use this for initialization
	void Start () {

       // Stat.hp = hp;
      //  Stat.stamina = stamina;
       // Stat.Damage = damage;
       // Stat.Defend = def;
       // pstat = new Stat(hp,stamina,damage,def);
        Debug.Log(Stat.hp);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
