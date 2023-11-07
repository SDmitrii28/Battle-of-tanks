using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem_shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject stvol;
    public float fast;
    void Start()
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
            run.AddForce(pul.transform.up * (-1) * fast, ForceMode.Impulse);
            Destroy(pul, 1);
            yield return new WaitForSeconds(2f);
        }
    }
}
