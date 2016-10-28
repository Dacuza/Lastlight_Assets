using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

    int coinValue;
    GameObject player;
	// Use this for initialization
	void Start () {
        
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x > player.transform.position.x)
            this.transform.Translate(new Vector3(-10 * Time.deltaTime, 0, 0));
        if (this.transform.position.x < player.transform.position.x)
            this.transform.Translate(new Vector3(10 * Time.deltaTime, 0, 0));
        if (this.transform.position.y < player.transform.position.y)
            this.transform.Translate(new Vector3(0, 30 * Time.deltaTime, 0));


    }
    public void setcoinValue(int coin)
    {
        coinValue = Random.Range(coin,coin+7);
    }

    void OnCollisionEnter2D(Collision2D coi)
    {
        Debug.Log("hitttttt");
        if (coi.gameObject.tag == "Player")
        {
            Stat.Money += coinValue;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coi)
    {

    }
}
