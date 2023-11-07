using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int count;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("player") && count==0 )
        {
            Resources.coins += 5;
            Destroy(gameObject);
        }
        
        if(collision.gameObject.CompareTag("player") && count == 1)
        {
            Resources.coins += 25;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("player") && count == 2)
        {
            Resources.coins += 100;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("player") && count == 3)
        {
            Resources.coins += 500;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("player") && count == 4)
        {
            Resources.coins += 1000;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("player") && count == 5)
        {
            Resources.crystal += 1;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("player") && count == 6)
        {
            Resources.coins += 15000;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("player") && count == 7)
        {
            Resources.bullet += 10;
            Destroy(gameObject);
        }
    }
}
