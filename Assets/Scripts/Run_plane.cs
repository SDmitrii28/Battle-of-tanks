using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_plane : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -1.3f)
        {
            speed = -1*speed;
        }
        if (transform.position.x > 1.4f)
        {
            speed = -1*speed;
        }

    }
}
