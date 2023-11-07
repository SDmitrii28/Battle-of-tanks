using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class PurchaseSource : MonoBehaviour
{

    public void OnPurchaseComplete(Product product)
    {
        //Menu a = new Menu();

        if (product.definition.id == "buy_money400")
        {
            //a.buy.Play();
            Menu.money += 400000;
        }
        else
        if (product.definition.id == "buy_money3000")
        {
            //a.buy.Play();
            Menu.money += 3000000;
        }
        else
        if (product.definition.id == "buy_money10000")
        {
            //a.buy.Play();
            Menu.money += 10000000;
        }
        else
        if (product.definition.id == "buy_money70000")
        {
            //a.buy.Play();
            Menu.money += 70000000;
        }
        else
        if (product.definition.id == "buy_crystal1")
        {
            //a.buy.Play();
            Menu.crystal += 1000;
        }
        else
        if (product.definition.id == "buy_crystal5")
        {
            //a.buy.Play();
            Menu.crystal += 5000;
        }
        else
        if (product.definition.id == "buy_crystal12")
        {
            //a.buy.Play();
            Menu.crystal += 12000;
        }
        else
        if (product.definition.id == "buy_crystal48")
        {
            //a.buy.Play();
            Menu.crystal += 48000;
        }
        else
        if (product.definition.id == "buy_super_tank")
        {
            //a.buy.Play();
            PlayerPrefs.SetInt("tank4", 4);
            PlayerPrefs.Save();
        }

    }

    public void OnPurchaseFailure(Product product, PurchaseFailureReason reason)
    {
        Debug.Log("Purchase of product " + product.definition.id + " failed because " + reason);
    }
}

