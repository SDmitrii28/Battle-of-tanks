using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_pullya_up : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("tank"))
        {
            //Vector3 Pose = transform.position;
            //Quaternion pos = transform.rotation;
            Destroy(gameObject);

            // Instantiate(enemy, Pose, pos);
        }
    }
}
