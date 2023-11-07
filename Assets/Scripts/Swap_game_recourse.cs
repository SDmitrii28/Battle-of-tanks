using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap_game_recourse : MonoBehaviour
{
    public GameObject[] ob;
    public GameObject[] ob_money;
    private float[] pos = { -1.74f, -0.56f, 0.48f, 1.66f };
    private int level;
    public GameObject[] map;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            map[i].SetActive(false);
        }
        level = PlayerPrefs.GetInt("game");
        map[level].SetActive(true);
        switch (level)
        {
            case 0:
                StartCoroutine(spawn1());
                break;
            case 1:
                StartCoroutine(spawn2());
                break;
            case 2:
                StartCoroutine(spawn3());
                break;
            case 3:
                StartCoroutine(spawn4());
                break;
            case 4:
                StartCoroutine(spawn5());
                break;
            case 5:
                StartCoroutine(spawn6());
                break;
            case 6:
                StartCoroutine(spawn7());
                break;
            case 7:
                StartCoroutine(spawn8());
                break;
            case 8:
                StartCoroutine(spawn9());
                break;
            case 9:
                StartCoroutine(spawn10());
                break;
            case 10:
                StartCoroutine(spawn11());
                break;
            case 11:
                StartCoroutine(spawn12());
                break;
            case 12:
                StartCoroutine(spawn13());
                break;
            case 13:
                StartCoroutine(spawn14());
                break;
            case 14:
                StartCoroutine(spawn15());
                break;
            default:
                break;
                

        }
        StartCoroutine(spawn_crystal());
        StartCoroutine(spawn_cub());
        StartCoroutine(spawn_patron());
    }

    IEnumerator spawn1()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 2)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 900)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 900 && Resources.distance <= 1500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1500 && Resources.distance <= 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 7)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2200 && Resources.distance <= 2300)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2300 && Resources.distance <= 2400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 4)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 2)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn2()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 2)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 200 && Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 900)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 900 && Resources.distance <= 1500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1500 && Resources.distance <= 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(2.5f);
        }
    }
    IEnumerator spawn3()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 200 && Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 900)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 900 && Resources.distance <= 1500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1500 && Resources.distance <= 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator spawn4()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 100 && Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 900)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 900 && Resources.distance <= 1500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1500 && Resources.distance <= 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator spawn5()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 2)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 100 && Resources.distance <= 300)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 300 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 900)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 900 && Resources.distance <= 1500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1500 && Resources.distance <= 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn6()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 100 && Resources.distance <= 200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 200 && Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 700)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 700 && Resources.distance <= 1100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1100 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn7()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 50)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 50 && Resources.distance <= 150)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 150 && Resources.distance <= 300)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 300 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 1100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1100 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn8()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 50)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 2)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 50 && Resources.distance <= 150)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 150 && Resources.distance <= 300)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 300 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 1100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1100 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator spawn9()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

           
            if (Resources.distance <= 200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 200 && Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 1100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1100 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn10()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));


            if (Resources.distance <= 200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 10)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 200 && Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 1100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1100 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn11()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));


            if (Resources.distance <= 400)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 400 && Resources.distance <= 600)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 600 && Resources.distance <= 1100)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1100 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator spawn12()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));


            if (Resources.distance <= 200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 9)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 200 && Resources.distance <= 500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 500 && Resources.distance <= 1000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1000 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator spawn13()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 8)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 500 && Resources.distance <= 1000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1000 && Resources.distance <= 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 2000)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator spawn14()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            if ( Resources.distance <= 500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 6)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 500 && Resources.distance <= 1200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 1200)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator spawn15()
    {
        while (true)
        {
            //Instantiate(ob[Random.Range(0, ob.Length)], new Vector3(pos[Random.Range(0, 4)], 6, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

            if (Resources.distance <= 500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 5)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length - 1)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            if (Resources.distance > 500)
            {
                Instantiate(ob[Random.Range(0, ob.Length - 3)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ob_money[Random.Range(0, ob_money.Length)], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator spawn_crystal()
    {
        while (true)
        {
            Instantiate(ob[8], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(10f);
        }
    }
    IEnumerator spawn_cub()
    {
        while (true)
        {
            if (Resources.distance > Menu.dist[PlayerPrefs.GetInt("game")])
            {
                Instantiate(ob[9], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            yield return new WaitForSeconds(30f);
        }
    }
    IEnumerator spawn_patron()
    {
        while (true)
        {
            
            Instantiate(ob[10], new Vector3(pos[Random.Range(0, 4)], 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(30f);
        }
    }
}
