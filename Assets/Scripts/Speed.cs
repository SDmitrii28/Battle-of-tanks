using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed = 2f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -15f)
        {
            Destroy(gameObject);
        }
    }
}
