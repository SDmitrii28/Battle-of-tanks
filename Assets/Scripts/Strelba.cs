using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strelba : MonoBehaviour
{
    // Start is called before the first frame update
    public int live;
    public int nomer;
    private int count;
    public GameObject money;
    public GameObject explosion;
    private void Start()
    {
        count = live;
    }
    private void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            if (count == 0 && nomer == i)
            {
                Vector3 Pose = transform.position;
                Quaternion pos = transform.rotation;
                Instantiate(explosion, Pose, pos);
                Destroy(gameObject);
                Instantiate(money, Pose, pos);
                //Instantiate(explosion, Pose, pos);
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet_up"))
        {
            //Vector3 Pose = transform.position;
            count--;
            
           // Instantiate(enemy, Pose, pos);
        }
    }
}
