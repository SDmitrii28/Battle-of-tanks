using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject bullet;
    public GameObject[] stvol;
    public float[] fast;
    public GameObject[] shield;
    private float time;
    public GameObject[] Plane;
    //public Object[] Plane;
    //sounds
    public AudioSource shot;

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            shield[PlayerPrefs.GetInt("tank")].SetActive(false);
        }

    }
    public void Shooting()
    {
        switch (PlayerPrefs.GetInt("tank"))
        {
            case 0:
                {
                    shot.Play();
                    Resources.bullet--;
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint = stvol[0].transform.position;
                    Quaternion spawn = stvol[0].transform.rotation;
                    GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
                    Rigidbody run = pul.GetComponent<Rigidbody>();
                    run.AddForce(pul.transform.up * fast[0], ForceMode.Impulse);
                    Destroy(pul, 1);
                }
                break;
            case 1:
                {
                    shot.Play();
                    Resources.bullet--;
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint = stvol[1].transform.position;
                    Quaternion spawn = stvol[1].transform.rotation;
                    GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
                    Rigidbody run = pul.GetComponent<Rigidbody>();
                    run.AddForce(pul.transform.up * fast[1], ForceMode.Impulse);
                    Destroy(pul, 1);
                }
                break;
            case 2:
                {
                    shot.Play();
                    Resources.bullet--;
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint = stvol[2].transform.position;
                    Quaternion spawn = stvol[2].transform.rotation;
                    GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
                    Rigidbody run = pul.GetComponent<Rigidbody>();
                    run.AddForce(pul.transform.up * fast[2], ForceMode.Impulse);
                    Destroy(pul, 1);
                }
                break;
            case 3:
                {
                    shot.Play();
                    Resources.bullet -= 2;
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint = stvol[3].transform.position;
                    Quaternion spawn = stvol[3].transform.rotation;
                    GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
                    Rigidbody run = pul.GetComponent<Rigidbody>();
                    run.AddForce(pul.transform.up * fast[3], ForceMode.Impulse);
                    Destroy(pul, 1);

                    shot.Play();
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint1 = stvol[4].transform.position;
                    Quaternion spawn1 = stvol[4].transform.rotation;
                    GameObject pul1 = Instantiate(bullet, spawnpoint1, spawn1) as GameObject;
                    Rigidbody run1 = pul1.GetComponent<Rigidbody>();
                    run1.AddForce(pul1.transform.up * fast[3], ForceMode.Impulse);
                    Destroy(pul1, 1);
                }
                break;
            case 4:
                {
                    shot.Play();
                    Resources.bullet -= 2;
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint = stvol[5].transform.position;
                    Quaternion spawn = stvol[5].transform.rotation;
                    GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
                    Rigidbody run = pul.GetComponent<Rigidbody>();
                    run.AddForce(pul.transform.up * fast[4], ForceMode.Impulse);
                    Destroy(pul, 1);

                    shot.Play();
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint1 = stvol[6].transform.position;
                    Quaternion spawn1 = stvol[6].transform.rotation;
                    GameObject pul1 = Instantiate(bullet, spawnpoint1, spawn1) as GameObject;
                    Rigidbody run1 = pul1.GetComponent<Rigidbody>();
                    run1.AddForce(pul1.transform.up * fast[4], ForceMode.Impulse);
                    Destroy(pul1, 1);
                }
                break;
            case 5:
                {
                    shot.Play();
                    //Resources.bullet--;
                    //GetComponent<AudioSource>().PlayOneShot(aud);
                    Vector3 spawnpoint = stvol[7].transform.position;
                    Quaternion spawn = stvol[7].transform.rotation;
                    GameObject pul = Instantiate(bullet, spawnpoint, spawn) as GameObject;
                    Rigidbody run = pul.GetComponent<Rigidbody>();
                    run.AddForce(pul.transform.up * fast[5], ForceMode.Impulse);
                    Destroy(pul, 1);
                }
                break;
            default:
                break;
        }
    }
    public void Active_Shield()
    {
        if (PlayerPrefs.HasKey("tank"))
        {
            Resources.shield--;
            shield[PlayerPrefs.GetInt("tank")].SetActive(true);
            time = 17f;
        }
    }
    public void Active_Plane(int k)
    {
        switch (k)
        {
            case 0:
                {
                    Resources.plane1--;
                    Instantiate(Plane[0], new Vector3(0.3f, -3.44f, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                }
                break;
            case 1:
                {
                    Resources.plane2--;
                    Instantiate(Plane[1], new Vector3(0.3f, -3.44f, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                }
                break;
            default:
                break;
        }
    }
}
