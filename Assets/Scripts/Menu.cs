using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //public static int k;
    public GameObject[] panel;
    public GameObject[] panel_level;
    public GameObject[] panel_lock_level;
    public GameObject[] panel_tank;
    public GameObject[] buy_resources;
    public Text all_coins;
    public Text all_crystal;
    public Text all_patron;
    public Text shild;
    public Text plane1;
    public Text plane2;
    public Button[] minus;
    public Button[] plus;
    public Text[] price;
    public Text[] counts;
    public Button[] buy_price1;
    private int[] a;
    public static int[] dist;
    private int[] Max_dist;
    public Text[] Distance;
    public GameObject[] star1;
    public GameObject[] star2;
    public GameObject[] star3;
    public GameObject[] star_1;
    public GameObject[] star_2;
    public GameObject[] star_3;
    public GameObject[] open_level1;
    public GameObject[] open_level2;
    public Button[] buy_level;
    public Button[] buy_tank;
    public GameObject[] open_tank1;
    public GameObject[] open_tank2;
    public static int money;
    public static int crystal;
    public static int patron;
    public static int shield;
    public static int airplane1;
    public static int airplane2;
    public GameObject[] lock_level;
    public Button[] play_level;
    public GameObject[] lock_tank;
    public Button[] select_tank;
    public GameObject[] v_tank;
    //sounds
    public AudioSource click;
    public AudioSource buy;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.HasKey("tank"))
        {
            v_tank[PlayerPrefs.GetInt("tank")].SetActive(true);
        }
        else
            v_tank[0].SetActive(true);
        a = new int[4];
        dist = new int[15];
        Max_dist = new int[15];
        Begin_distance();
        Begin_All_money();
        Begin_All_Crystal();
        Begin_All_Patron();
        Begin_All_Shield();
        Begin_All_Plan1();
        Begin_All_Plan2();
        //PlayerPrefs.DeleteAll();

    }

    // Update is called once per frame
    void Update()
    {
        End_All_money();
        End_All_crystal();
        End_All_Patron();
        End_All_Shield();
        End_All_Plane1();
        End_All_Plane2();
        Open_buy_tank();
        Open_tank_coins();
        Open_tank_distance();
        Open_buy_level();
        Open_level_coins();
        Open_level_distance();
        Max_distance(Distance);
        buy_resources_if();
        Star_game();
        Count_resource();
        Update_buy_level();
        Update_buy_tank();
    }
    public void ClickMenu(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel[0].SetActive(true);
                break;
            case 1:
                click.Play();
                panel[1].SetActive(true);
                break;
            case 2:
                click.Play();
                panel[2].SetActive(true);
                break;
            case 3:
                click.Play();
                panel[3].SetActive(true);
                break;
            case 4:
                click.Play();
                Application.Quit();
                break;
            default:
                break;

        }
    }
    public void Close_panel(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel[0].SetActive(false);
                break;
            case 1:
                click.Play();
                panel[1].SetActive(false);
                break;
            case 2:
                click.Play();
                panel[2].SetActive(false);
                break;
            case 3:
                click.Play();
                panel[3].SetActive(false);
                break;
            default:
                break;

        }
    }
    public void Close_panel_level(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel_level[0].SetActive(false);
                break;
            case 1:
                click.Play();
                panel_level[1].SetActive(false);
                break;
            case 2:
                click.Play();
                panel_level[2].SetActive(false);
                break;
            case 3:
                click.Play();
                panel_level[3].SetActive(false);
                break;
            case 4:
                click.Play();
                panel_level[4].SetActive(false);
                break;
            case 5:
                click.Play();
                panel_level[5].SetActive(false);
                break;
            case 6:
                click.Play();
                panel_level[6].SetActive(false);
                break;
            case 7:
                click.Play();
                panel_level[7].SetActive(false);
                break;
            case 8:
                click.Play();
                panel_level[8].SetActive(false);
                break;
            case 9:
                click.Play();
                panel_level[9].SetActive(false);
                break;
            case 10:
                click.Play();
                panel_level[10].SetActive(false);
                break;
            case 11:
                click.Play();
                panel_level[11].SetActive(false);
                break;
            case 12:
                click.Play();
                panel_level[12].SetActive(false);
                break;
            case 13:
                click.Play();
                panel_level[13].SetActive(false);
                break;
            case 14:
                click.Play();
                panel_level[14].SetActive(false);
                break;
            default:
                break;
        }
    }
    public void Click_panel_level(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel_level[0].SetActive(true);
                break;
            case 1:
                click.Play();
                panel_level[1].SetActive(true);
                break;
            case 2:
                click.Play();
                panel_level[2].SetActive(true);
                break;
            case 3:
                click.Play();
                panel_level[3].SetActive(true);
                break;
            case 4:
                click.Play();
                panel_level[4].SetActive(true);
                break;
            case 5:
                click.Play();
                panel_level[5].SetActive(true);
                break;
            case 6:
                click.Play();
                panel_level[6].SetActive(true);
                break;
            case 7:
                click.Play();
                panel_level[7].SetActive(true);
                break;
            case 8:
                click.Play();
                panel_level[8].SetActive(true);
                break;
            case 9:
                click.Play();
                panel_level[9].SetActive(true);
                break;
            case 10:
                click.Play();
                panel_level[10].SetActive(true);
                break;
            case 11:
                click.Play();
                panel_level[11].SetActive(true);
                break;
            case 12:
                click.Play();
                panel_level[12].SetActive(true);
                break;
            case 13:
                click.Play();
                panel_level[13].SetActive(true);
                break;
            case 14:
                click.Play();
                panel_level[14].SetActive(true);
                break;
            default:
                break;
        }
    }
    public void Click_lock_level(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel_lock_level[0].SetActive(true);
                break;
            case 1:
                click.Play();
                panel_lock_level[1].SetActive(true);
                break;
            case 2:
                click.Play();
                panel_lock_level[2].SetActive(true);
                break;
            case 3:
                click.Play();
                panel_lock_level[3].SetActive(true);
                break;
            case 4:
                click.Play();
                panel_lock_level[4].SetActive(true);
                break;
            case 5:
                click.Play();
                panel_lock_level[5].SetActive(true);
                break;
            case 6:
                click.Play();
                panel_lock_level[6].SetActive(true);
                break;
            case 7:
                click.Play();
                panel_lock_level[7].SetActive(true);
                break;
            case 8:
                click.Play();
                panel_lock_level[8].SetActive(true);
                break;
            case 9:
                click.Play();
                panel_lock_level[9].SetActive(true);
                break;
            case 10:
                click.Play();
                panel_lock_level[10].SetActive(true);
                break;
            case 11:
                click.Play();
                panel_lock_level[11].SetActive(true);
                break;
            case 12:
                click.Play();
                panel_lock_level[12].SetActive(true);
                break;
            case 13:
                click.Play();
                panel_lock_level[13].SetActive(true);
                break;
            case 14:
                click.Play();
                panel_lock_level[14].SetActive(true);
                break;
            default:
                break;
        }
    }
    public void Close_panel_lock_level(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel_lock_level[0].SetActive(false);
                break;
            case 1:
                click.Play();
                panel_lock_level[1].SetActive(false);
                break;
            case 2:
                click.Play();
                panel_lock_level[2].SetActive(false);
                break;
            case 3:
                click.Play();
                panel_lock_level[3].SetActive(false);
                break;
            case 4:
                click.Play();
                panel_lock_level[4].SetActive(false);
                break;
            case 5:
                click.Play();
                panel_lock_level[5].SetActive(false);
                break;
            case 6:
                click.Play();
                panel_lock_level[6].SetActive(false);
                break;
            case 7:
                click.Play();
                panel_lock_level[7].SetActive(false);
                break;
            case 8:
                click.Play();
                panel_lock_level[8].SetActive(false);
                break;
            case 9:
                click.Play();
                panel_lock_level[9].SetActive(false);
                break;
            case 10:
                click.Play();
                panel_lock_level[10].SetActive(false);
                break;
            case 11:
                click.Play();
                panel_lock_level[11].SetActive(false);
                break;
            case 12:
                click.Play();
                panel_lock_level[12].SetActive(false);
                break;
            case 13:
                click.Play();
                panel_lock_level[13].SetActive(false);
                break;
            case 14:
                click.Play();
                panel_lock_level[14].SetActive(false);
                break;
            default:
                break;
        }
    }
    public void Tank_lock(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel_tank[0].SetActive(true);
                break;
            case 1:
                click.Play();
                panel_tank[1].SetActive(true);
                break;
            case 2:
                click.Play();
                panel_tank[2].SetActive(true);
                break;
            case 3:
                click.Play();
                panel_tank[3].SetActive(true);
                break;
            case 4:
                click.Play();
                panel_tank[4].SetActive(true);
                break;
            default:
                break;

        }
    }
    public void Close_tank(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                panel_tank[0].SetActive(false);
                break;
            case 1:
                click.Play();
                panel_tank[1].SetActive(false);
                break;
            case 2:
                click.Play();
                panel_tank[2].SetActive(false);
                break;
            case 3:
                click.Play();
                panel_tank[3].SetActive(false);
                break;
            case 4:
                click.Play();
                panel_tank[4].SetActive(false);
                break;
            default:
                break;

        }
    }
    public void Click_resources(int k)
    {
        for (int i = 0; i < counts.Length; i++)
        {
            counts[i].text = 0.ToString();
            price[i].text = 0.ToString();
        }
        switch (k)
        {
            case 0:
                click.Play();
                buy_resources[0].SetActive(true);
                a[0] = 0;
                break;
            case 1:
                click.Play();
                buy_resources[1].SetActive(true);
                a[1] = 0;
                break;
            case 2:
                click.Play();
                buy_resources[2].SetActive(true);
                a[2] = 0;
                break;
            case 3:
                click.Play();
                buy_resources[3].SetActive(true);
                a[3] = 0;
                break;
            default:
                break;

        }
    }
    public void Close_resources(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                buy_resources[0].SetActive(false);
                break;
            case 1:
                click.Play();
                buy_resources[1].SetActive(false);
                break;
            case 2:
                click.Play();
                buy_resources[2].SetActive(false);
                break;
            case 3:
                click.Play();
                buy_resources[3].SetActive(false);
                break;
            default:
                break;

        }
    }
    private void Count_resource()
    {
        counts[0].text = (a[0] * 10).ToString();
        price[0].text = (a[0] * 100 * 10).ToString();

        counts[1].text = a[1].ToString();
        price[1].text = (a[1] * 100).ToString();

        counts[2].text = a[2].ToString();
        price[2].text = (a[2] * 300).ToString();

        counts[3].text = a[3].ToString();
        price[3].text = (a[3] * 600).ToString();
    }
    public void Plus(int k)
    {
        switch (k)
        {
   
            case 0:
                click.Play();
                a[0]++;
                break;
            case 1:
                click.Play();
                a[1]++;
                break;
            case 2:
                click.Play();
                a[2]++;
                break;
            case 3:
                click.Play();
                a[3]++;
                break;
            default:
                break;

        }
    }
    public void Minus(int k)
    {
        switch (k)
        {
            case 0:
                click.Play();
                a[0]--;
                break;
            case 1:
                click.Play();
                a[1]--;
                break;
            case 2:
                click.Play();
                a[2]--;
                break;
            case 3:
                click.Play();
                a[3]--;
                break;
            default:
                break;

        }
    }
    private void buy_resources_if()
    {
        for (int i = 0; i < minus.Length; i++)
        {
            if (a[i] <= 0)
            {
                minus[i].interactable = false;
            }
            else
                minus[i].interactable = true;
        }
        for (int i = 1; i < buy_price1.Length; i++)
        {
            if (int.Parse(all_crystal.text) < int.Parse(price[i].text) || int.Parse(price[i].text) == 0)
            {
                buy_price1[i].interactable = false;
            }
            else
                buy_price1[i].interactable = true;
        }
        if (int.Parse(all_coins.text) < int.Parse(price[0].text) || int.Parse(price[0].text) == 0)
        {
            buy_price1[0].interactable = false;
        }
        else
            buy_price1[0].interactable = true;
    }
    private void Begin_distance()
    {
        for (int i = 0; i < dist.Length; i++)
        {
            if (PlayerPrefs.HasKey("begin" + i.ToString()))
            {
                dist[i] = int.Parse(PlayerPrefs.GetString("begin" + i.ToString()));
                PlayerPrefs.DeleteKey("begin" + i.ToString());

            }
            else
                dist[i] = int.Parse(Distance[i].text);

            if (PlayerPrefs.HasKey("max" + i.ToString()))
            {
                Max_dist[i] = PlayerPrefs.GetInt("max" + i.ToString());
            }
            else
                Max_dist[i] = 0;
        }
    }
    private void Max_distance(Text []distance)
    {
        for (int i = 0; i < dist.Length; i++)
        {
            if (Max_dist[i] > dist[i])
            {
                Distance[i].text = Max_dist[i].ToString();
            }
            else
            {
                Distance[i].text = dist[i].ToString();
            }
            PlayerPrefs.SetString("begin" + i.ToString(), Distance[i].text);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("max" + i.ToString());
        }
    }
    private void Star_game()
    {
        for(int i = 0; i < star1.Length; i++)
        {
            if (int.Parse(Distance[i].text) >= 800)
            {
                
                star1[i].SetActive(true);
                star_1[i].SetActive(true);

            }
            else
            {
                star1[i].SetActive(false);
                star_1[i].SetActive(false);
            }

            if (int.Parse(Distance[i].text) >= 1500)
            {
                star2[i].SetActive(true);
                star_2[i].SetActive(true);
            }
            else
            {
                star2[i].SetActive(false);
                star_2[i].SetActive(false);
            }

            if (int.Parse(Distance[i].text) >= 2500)
            {
                star3[i].SetActive(true);
                star_3[i].SetActive(true);
            }
            else
            {
                star3[i].SetActive(false);
                star_3[i].SetActive(false);
            }
        }
    }
    private void Open_level_distance()
    {
        if (int.Parse(Distance[0].text) >= 800)
        {
            open_level1[0].SetActive(true);
        }
        else
            open_level1[0].SetActive(false);

        if (int.Parse(Distance[1].text) >= 1000)
        {
            open_level1[1].SetActive(true);
        }
        else
            open_level1[1].SetActive(false);

        if (int.Parse(Distance[2].text) >= 1100)
        {
            open_level1[2].SetActive(true);
        }
        else
            open_level1[2].SetActive(false);

        if (int.Parse(Distance[3].text) >= 1200)
        {
            open_level1[3].SetActive(true);
        }
        else
            open_level1[3].SetActive(false);

        if (int.Parse(Distance[4].text) >= 1300)
        {
            open_level1[4].SetActive(true);
        }
        else
            open_level1[4].SetActive(false);

        if (int.Parse(Distance[5].text) >= 1400)
        {
            open_level1[5].SetActive(true);
        }
        else
            open_level1[5].SetActive(false);

        if (int.Parse(Distance[6].text) >= 1500)
        {
            open_level1[6].SetActive(true);
        }
        else
            open_level1[6].SetActive(false);

        if (int.Parse(Distance[7].text) >= 1600)
        {
            open_level1[7].SetActive(true);
        }
        else
            open_level1[7].SetActive(false);

        if (int.Parse(Distance[8].text) >= 1700)
        {
            open_level1[8].SetActive(true);
        }
        else
            open_level1[8].SetActive(false); 

        if (int.Parse(Distance[9].text) >= 1800)
        {
            open_level1[9].SetActive(true);
        }
        else
            open_level1[9].SetActive(false);

        if (int.Parse(Distance[10].text) >= 1900)
        {
            open_level1[10].SetActive(true);
        }
        else
            open_level1[10].SetActive(false);

        if (int.Parse(Distance[11].text) >= 2000)
        {
            open_level1[11].SetActive(true);
        }
        else
            open_level1[11].SetActive(false);

        if (int.Parse(Distance[12].text) >= 2100)
        {
            open_level1[12].SetActive(true);
        }
        else
            open_level1[12].SetActive(false);

        if (int.Parse(Distance[13].text) >= 2500)
        {
            open_level1[13].SetActive(true);
        }
        else
            open_level1[13].SetActive(false);

    }


    private void Open_level_coins()
    {
        if (int.Parse(all_coins.text) >= 100000)
        {
            open_level2[0].SetActive(true);
        }
        else
            open_level2[0].SetActive(false);

        if (int.Parse(all_coins.text) >= 200000)
        {
            open_level2[1].SetActive(true);
        }
        else
            open_level2[1].SetActive(false);

        if (int.Parse(all_coins.text) >= 250000)
        {
            open_level2[2].SetActive(true);
        }
        else
            open_level2[2].SetActive(false);

        if (int.Parse(all_coins.text) >= 250000)
        {
            open_level2[3].SetActive(true);
        }
        else
            open_level2[3].SetActive(false);

        if (int.Parse(all_coins.text) >= 300000)
        {
            open_level2[4].SetActive(true);
        }
        else
            open_level2[4].SetActive(false);

        if (int.Parse(all_coins.text) >= 350000)
        {
            open_level2[5].SetActive(true);
        }
        else
            open_level2[5].SetActive(false);

        if (int.Parse(all_coins.text) >= 400000)
        {
            open_level2[6].SetActive(true);
        }
        else
            open_level2[6].SetActive(false);

        if (int.Parse(all_coins.text) >= 450000)
        {
            open_level2[7].SetActive(true);
        }
        else
            open_level2[7].SetActive(false);

        if (int.Parse(all_coins.text) >= 500000)
        {
            open_level2[8].SetActive(true);
        }
        else
            open_level2[8].SetActive(false);

        if (int.Parse(all_coins.text) >= 520000)
        {
            open_level2[9].SetActive(true);
        }
        else
            open_level2[9].SetActive(false);

        if (int.Parse(all_coins.text) >= 550000)
        {
            open_level2[10].SetActive(true);
        }
        else
            open_level2[10].SetActive(false);

        if (int.Parse(all_coins.text) >= 570000)
        {
            open_level2[11].SetActive(true);
        }
        else
            open_level2[11].SetActive(false);

        if (int.Parse(all_coins.text) >= 590000)
        {
            open_level2[12].SetActive(true);
        }
        else
            open_level2[12].SetActive(false);

        if (int.Parse(all_coins.text) >= 600000)
        {
            open_level2[13].SetActive(true);
        }
        else
            open_level2[13].SetActive(false);

    }


    private void Open_buy_level()
    {
        if (int.Parse(Distance[0].text) >= 800 && int.Parse(all_coins.text) >= 100000)
        {
            buy_level[0].interactable = true;
        }
        else
            buy_level[0].interactable = false;

        if (int.Parse(Distance[1].text) >= 1000 && int.Parse(all_coins.text) >= 200000)
        {
            buy_level[1].interactable = true;
        }
        else
            buy_level[1].interactable = false;

        if (int.Parse(Distance[2].text) >= 1100 && int.Parse(all_coins.text) >= 250000)
        {
            buy_level[2].interactable = true;
        }
        else
            buy_level[2].interactable = false;

        if (int.Parse(Distance[3].text) >= 1200 && int.Parse(all_coins.text) >= 250000)
        {
            buy_level[3].interactable = true;
        }
        else
            buy_level[3].interactable = false;

        if (int.Parse(Distance[4].text) >= 1300 && int.Parse(all_coins.text) >= 300000)
        {
            buy_level[4].interactable = true;
        }
        else
            buy_level[4].interactable = false;

        if (int.Parse(Distance[5].text) >= 1400 && int.Parse(all_coins.text) >= 350000)
        {
            buy_level[5].interactable = true;
        }
        else
            buy_level[5].interactable = false;

        if (int.Parse(Distance[6].text) >= 1500 && int.Parse(all_coins.text) >= 400000)
        {
            buy_level[6].interactable = true;
        }
        else
            buy_level[6].interactable = false;

        if (int.Parse(Distance[7].text) >= 1600 && int.Parse(all_coins.text) >= 450000)
        {
            buy_level[7].interactable = true;
        }
        else
            buy_level[7].interactable = false;

        if (int.Parse(Distance[8].text) >= 1700 && int.Parse(all_coins.text) >= 500000)
        {
            buy_level[8].interactable = true;
        }
        else
            buy_level[8].interactable = false;

        if (int.Parse(Distance[9].text) >= 1800 && int.Parse(all_coins.text) >= 520000)
        {
            buy_level[9].interactable = true;
        }
        else
            buy_level[9].interactable = false;

        if (int.Parse(Distance[10].text) >= 1900 && int.Parse(all_coins.text) >= 550000)
        {
            buy_level[10].interactable = true;
        }
        else
            buy_level[10].interactable = false;

        if (int.Parse(Distance[11].text) >= 2000 && int.Parse(all_coins.text) >= 570000)
        {
            buy_level[11].interactable = true;
        }
        else
            buy_level[11].interactable = false;

        if (int.Parse(Distance[12].text) >= 2100 && int.Parse(all_coins.text) >= 590000)
        {
            buy_level[12].interactable = true;
        }
        else
            buy_level[12].interactable = false;

        if (int.Parse(Distance[13].text) >= 2500 && int.Parse(all_coins.text) >= 600000)
        {
            buy_level[13].interactable = true;
        }
        else
            buy_level[13].interactable = false;

    }
    private void Open_tank_distance()
    {
        if (int.Parse(Distance[1].text) >= 1000)
        {
            open_tank1[0].SetActive(true);
        }
        else
            open_tank1[0].SetActive(false);

        if (int.Parse(Distance[3].text) >= 1200)
        {
            open_tank1[1].SetActive(true);
        }
        else
            open_tank1[1].SetActive(false);

        if (int.Parse(Distance[6].text) >= 1400)
        {
            open_tank1[2].SetActive(true);
        }
        else
            open_tank1[2].SetActive(false);

        if (int.Parse(Distance[9].text) >= 1700)
        {
            open_tank1[3].SetActive(true);
        }
        else
            open_tank1[3].SetActive(false);
    }

    private void Open_tank_coins() {
        if (int.Parse(all_coins.text) >= 70000)
        {
            open_tank2[0].SetActive(true);
        }
        else
            open_tank2[0].SetActive(false);

        if (int.Parse(all_coins.text) >= 110000)
        {
            open_tank2[1].SetActive(true);
        }
        else
            open_tank2[1].SetActive(false);

        if (int.Parse(all_coins.text) >= 350000)
        {
            open_tank2[2].SetActive(true);
        }
        else
            open_tank2[2].SetActive(false);

        if (int.Parse(all_coins.text) >= 500000)
        {
            open_tank2[3].SetActive(true);
        }
        else
            open_tank2[3].SetActive(false);
    }
    private void Open_buy_tank()
    {
        if (int.Parse(Distance[1].text) >= 1000 && int.Parse(all_coins.text) >= 70000)
        {
            buy_tank[0].interactable = true;
        }
        else
            buy_tank[0].interactable = false;

        if (int.Parse(Distance[3].text) >= 1200 && int.Parse(all_coins.text) >= 110000)
        {
            buy_tank[1].interactable = true;
        }
        else
            buy_tank[1].interactable = false;

        if (int.Parse(Distance[6].text) >= 1400 && int.Parse(all_coins.text) >= 350000)
        {
            buy_tank[2].interactable = true;
        }
        else
            buy_tank[2].interactable = false;

        if (int.Parse(Distance[9].text) >= 1700 && int.Parse(all_coins.text) >= 500000)
        {
            buy_tank[3].interactable = true;
        }
        else
            buy_tank[3].interactable = false;
    }
    private void Begin_All_money()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetInt("money");
        }
        else
            money = int.Parse(all_coins.text);
    }
    private void End_All_money()
    {
        all_coins.text = money.ToString();
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.Save();
    }
    private void Begin_All_Crystal()
    {
        if (PlayerPrefs.HasKey("crystal"))
        {
            crystal = PlayerPrefs.GetInt("crystal");
        }
        else
            crystal = int.Parse(all_crystal.text);
    }
    private void End_All_crystal()
    {
        all_crystal.text = crystal.ToString();
        PlayerPrefs.SetInt("crystal", crystal); ;
        PlayerPrefs.Save();
    }
    private void Begin_All_Patron()
    {
        if (PlayerPrefs.HasKey("patron"))
        {
            patron = PlayerPrefs.GetInt("patron");
        }
        else
            patron = int.Parse(all_patron.text);
    }
    private void End_All_Patron()
    {
        all_patron.text = patron.ToString();
        PlayerPrefs.SetInt("patron", patron); ;
        PlayerPrefs.Save();
    }

    private void Begin_All_Shield()
    {
        if (PlayerPrefs.HasKey("shield"))
        {
            shield = PlayerPrefs.GetInt("shield");
        }
        else
            shield = int.Parse(shild.text);
    }
    private void End_All_Shield()
    {
        shild.text = shield.ToString();
        PlayerPrefs.SetInt("shield", shield);
        PlayerPrefs.Save();
    }
    private void Begin_All_Plan1()
    {
        if (PlayerPrefs.HasKey("plane1"))
        {
            airplane1 = PlayerPrefs.GetInt("plane1");
        }
        else
            airplane1 = int.Parse(plane1.text);
    }
    private void End_All_Plane1()
    {
        plane1.text = airplane1.ToString();
        PlayerPrefs.SetInt("plane1", airplane1);
        PlayerPrefs.Save();
    }

    private void Begin_All_Plan2()
    {
        if (PlayerPrefs.HasKey("plane2"))
        {
            airplane2 = PlayerPrefs.GetInt("plane2");
        }
        else
            airplane2 = int.Parse(plane2.text);
    }
    private void End_All_Plane2()
    {
        plane2.text = airplane2.ToString();
        PlayerPrefs.SetInt("plane2", airplane2);
        PlayerPrefs.Save();
    }
    public void Buy_resources(int k)
    {
        switch (k)
        {
            case 0:
                {
                    buy.Play();
                    money -= int.Parse(price[0].text);
                    patron += int.Parse(counts[0].text);
                    a[0] = 0;
                }
                break;

            case 1:
                {
                    buy.Play();
                    crystal -= int.Parse(price[1].text);
                    shield += int.Parse(counts[1].text);
                    a[1] = 0;
                }
                break;
            case 2:
                {
                    buy.Play();
                    crystal -= int.Parse(price[2].text);
                    airplane1 += int.Parse(counts[2].text);
                    a[2] = 0;
                }
                break;
            case 3:
                {
                    buy.Play();
                    crystal -= int.Parse(price[3].text);
                    airplane2 += int.Parse(counts[3].text);
                    a[3] = 0;
                }
                break;
            default:
                break;
        }
    }
    public void Buy_Level(int k)
    {
        switch (k)
        {
            case 0:
                {
                    buy.Play();
                    money -= 100000;
                    PlayerPrefs.SetInt("level0", 0);
                    PlayerPrefs.Save();
                }
                break;
            case 1:
                {
                    buy.Play();
                    money -= 200000;
                    PlayerPrefs.SetInt("level1", 1);
                    PlayerPrefs.Save();
                }
                break;
            case 2:
                {
                    buy.Play();
                    money -= 250000;
                    PlayerPrefs.SetInt("level2", 2);
                    PlayerPrefs.Save();
                }
                break;
            case 3:
                {
                    buy.Play();
                    money -= 250000;
                    PlayerPrefs.SetInt("level3", 3);
                    PlayerPrefs.Save();
                }
                break;
            case 4:
                {
                    buy.Play();
                    money -= 300000;
                    PlayerPrefs.SetInt("level4", 4);
                    PlayerPrefs.Save();
                }
                break;
            case 5:
                {
                    buy.Play();
                    money -= 350000;
                    PlayerPrefs.SetInt("level5", 5);
                    PlayerPrefs.Save();
                }
                break;
            case 6:
                {
                    buy.Play();
                    money -= 400000;
                    PlayerPrefs.SetInt("level6", 6);
                    PlayerPrefs.Save();
                }
                break;
            case 7:
                {
                    buy.Play();
                    money -= 450000;
                    PlayerPrefs.SetInt("level7", 7);
                    PlayerPrefs.Save();
                }
                break;
            case 8:
                {
                    buy.Play();
                    money -= 500000;
                    PlayerPrefs.SetInt("level8", 8);
                    PlayerPrefs.Save();
                }
                break;
            case 9:
                {
                    buy.Play();
                    money -= 520000;
                    PlayerPrefs.SetInt("level9", 9);
                    PlayerPrefs.Save();
                }
                break;
            case 10:
                {
                    buy.Play();
                    money -= 550000;
                    PlayerPrefs.SetInt("level10", 10);
                    PlayerPrefs.Save();
                }
                break;
            case 11:
                {
                    buy.Play();
                    money -= 570000;
                    PlayerPrefs.SetInt("level11", 11);
                    PlayerPrefs.Save();
                }
                break;
            case 12:
                {
                    buy.Play();
                    money -= 590000;
                    PlayerPrefs.SetInt("level12", 12);
                    PlayerPrefs.Save();
                }
                break;
            case 13:
                {
                    buy.Play();
                    money -= 600000;
                    PlayerPrefs.SetInt("level13", 13);
                    PlayerPrefs.Save();
                }
                break;
            default:
                break;
        }
    }
    private void Update_buy_level()
    {
        for(int i = 0; i < play_level.Length; i++)
        {
            if (PlayerPrefs.HasKey("level" + i.ToString()))
            {
                lock_level[i].SetActive(false);
                play_level[i].interactable = true;
                panel_lock_level[i+1].SetActive(false);
            }
        }
    }
    private void Update_buy_tank()
    {
        for (int i = 0; i < select_tank.Length; i++)
        {
            if (PlayerPrefs.HasKey("tank" + i.ToString()))
            {
                lock_tank[i].SetActive(false);
                select_tank[i].interactable = true;
                panel_tank[i].SetActive(false);
            }
        }
    }
    public void Buy_Tank(int k)
    {
        switch (k)
        {
            case 0:
                {
                    buy.Play();
                    money -= 70000;
                    PlayerPrefs.SetInt("tank0", 0);
                    PlayerPrefs.Save();
                }
                break;
            case 1:
                {
                    buy.Play();
                    money -= 110000;
                    PlayerPrefs.SetInt("tank1", 1);
                    PlayerPrefs.Save();
                }
                break;
            case 2:
                {
                    buy.Play();
                    money -= 350000;
                    PlayerPrefs.SetInt("tank2", 2);
                    PlayerPrefs.Save();
                }
                break;
            case 3:
                {
                    buy.Play();
                    money -= 500000;
                    PlayerPrefs.SetInt("tank3", 3);
                    PlayerPrefs.Save();
                }
                break;
            default:
                break;
        }
    }
    public void Chekeed_Tank(int tank)
    {
        PlayerPrefs.SetInt("tank", tank);
        PlayerPrefs.Save();
        switch (tank)
        {
            case 0:
                {
                    click.Play();
                    v_tank[0].SetActive(true);
                    v_tank[1].SetActive(false);
                    v_tank[2].SetActive(false);
                    v_tank[3].SetActive(false);
                    v_tank[4].SetActive(false);
                    v_tank[5].SetActive(false);
                }
                break;
            case 1:
                {
                    click.Play();
                    v_tank[0].SetActive(false);
                    v_tank[1].SetActive(true);
                    v_tank[2].SetActive(false);
                    v_tank[3].SetActive(false);
                    v_tank[4].SetActive(false);
                    v_tank[5].SetActive(false);
                }
                break;
            case 2:
                {
                    click.Play();
                    v_tank[0].SetActive(false);
                    v_tank[1].SetActive(false);
                    v_tank[2].SetActive(true);
                    v_tank[3].SetActive(false);
                    v_tank[4].SetActive(false);
                    v_tank[5].SetActive(false);
                }
                break;
            case 3:
                {
                    click.Play();
                    v_tank[0].SetActive(false);
                    v_tank[1].SetActive(false);
                    v_tank[2].SetActive(false);
                    v_tank[3].SetActive(true);
                    v_tank[4].SetActive(false);
                    v_tank[5].SetActive(false);
                }
                break;
            case 4:
                {
                    click.Play();
                    v_tank[0].SetActive(false);
                    v_tank[1].SetActive(false);
                    v_tank[2].SetActive(false);
                    v_tank[3].SetActive(false);
                    v_tank[4].SetActive(true);
                    v_tank[5].SetActive(false);
                }
                break;
            case 5:
                {
                    click.Play();
                    v_tank[0].SetActive(false);
                    v_tank[1].SetActive(false);
                    v_tank[2].SetActive(false);
                    v_tank[3].SetActive(false);
                    v_tank[4].SetActive(false);
                    v_tank[5].SetActive(true);
                }
                break;
            default:
                break;
        }
    }
    public void Donat(int k)
    {
        switch (k)
        {
            case 0:
                {

                    click.Play();
                }
                break;
            case 1:
                {
                    click.Play();

                }
                break;
            case 2:
                {
                    click.Play();

                }
                break;
            case 3:
                {
                    click.Play();

                }
                break;
            case 4:
                {
                    click.Play();

                }
                break;
            case 5:
                {
                    click.Play();


                }
                break;
            case 6:
                {
                    click.Play();

                }
                break;
            case 7:
                {
                    click.Play();

                }
                break;
            default:
                break;
        }
    }
    public void Load_level(int k)
    {
        PlayerPrefs.SetInt("game", k - 2);
        PlayerPrefs.Save();
        Application.LoadLevel(2);
    }
}
