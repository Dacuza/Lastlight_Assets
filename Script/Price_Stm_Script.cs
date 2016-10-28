﻿using UnityEngine;
using System.Collections;

public class Price_Stm_Script : MonoBehaviour {

    TextMesh price;

    int price_int;


    // Use this for initialization
    void Start()
    {
        price = GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {


        if (price_int < Shop_Controller.UpStamina)
        {
            if (Shop_Controller.UpStamina % 2 == 0)
                price_int += 2;
            if (Shop_Controller.UpStamina % 3 == 0)
                price_int += 3;
        }
        if (price_int == 0)
            price.text = " ";
        else
            price.text = price_int.ToString();

    }
}