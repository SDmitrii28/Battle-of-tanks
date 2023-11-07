using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public GameObject map;
    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        Resources.distance += (speed * Time.deltaTime);
        if (transform.position.y < -20f)
        {
            Instantiate(map, new Vector3(0, 12.13f, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            //EditorApplication.isPaused = true;
            Destroy(gameObject);
        }
    }
}
