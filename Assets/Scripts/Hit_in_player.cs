using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_in_player : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("shield"))
        {
            Destroy(gameObject);
        }
        else
        if (collision.gameObject.CompareTag("player"))
        {
            Resources.lives--;
            Destroy(gameObject);
        }
        else
            if(collision.gameObject.CompareTag("bullet_up"))
        {
            Destroy(gameObject);
        }
        else
            if (collision.gameObject.CompareTag("tank"))
        {
            Destroy(gameObject);
        }
    }
}
