using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Price_Def_Script : MonoBehaviour {

    TextMesh price;

    int price_int;


	// Use this for initialization
	void Start () {
        price = GetComponent<TextMesh>();
	
	}
	
	// Update is called once per frame
	void Update () {


        if (price_int < Shop_Controller.UpDef)
        {
            if (Shop_Controller.UpDef % 2 == 0)
                price_int += 2;
            if (Shop_Controller.UpDef % 3 == 0)
                price_int += 3;
        }
        if (price_int == 0)
            price.text = " ";
        else
            price.text = price_int.ToString();
	
	}
}
