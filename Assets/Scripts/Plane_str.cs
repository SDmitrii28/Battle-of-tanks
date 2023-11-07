using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_str : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject stvol;
    public float fast;
    public float second;
    private void Start()
    { 
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Vector3 spawnpoint = stvol.transform.position;
            Quaternion spawn = stvol.transform.rotation;
            GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
            Rigidbody run = pul.GetComponent<Rigidbody>();
            run.AddForce(pul.transform.up * fast, ForceMode.Impulse);
            Destroy(pul, 1);
            yield return new WaitForSeconds(second);
        }
    }
}
