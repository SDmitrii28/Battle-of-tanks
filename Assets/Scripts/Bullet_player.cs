using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_player : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet_enem"))
        {
            Destroy(gameObject);
            Vector3 Pose = transform.position;
            Quaternion pos = transform.rotation;
            Instantiate(explosion, Pose, pos);
        }
    }
}
