using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Resources : MonoBehaviour
{
 
    public GameObject panel_pause;
    public GameObject panel_res;
    public GameObject panel_result;
    public static int level;
    public static int coins;
    public static int crystal;
    public static int bullet;
    public static int lives;
    public static int shield;
    public static int plane1;
    public static int plane2;
    public static float distance;
    public Text t_coins;
    public Text t_crystal;
    public Text t_distance;
    public Text t_bullet;
    public Text t_lives;
    public Text t_shield;
    public Text t_plane1;
    public Text t_plane2;
    public Button[] resource;
    public int nomer_level;
    private int k;
    public Text result_coins;
    public Text result_crystal;
    public Text result_distance;
    public GameObject[] tanks_player;
    public int[] live;
    //sounds
    public AudioSource tank;
    public AudioSource click;
    public static int game_over;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("over"))
        {
            game_over = PlayerPrefs.GetInt("over");
        }
        else
            game_over = 0;

        tank.Play();
        if (PlayerPrefs.HasKey("tank"))
        {
            tanks_player[PlayerPrefs.GetInt("tank")].SetActive(true);
        }
        else
            tanks_player[0].SetActive(true);

        level = PlayerPrefs.GetInt("game");
        coins = PlayerPrefs.GetInt("money");
        crystal = PlayerPrefs.GetInt("crystal");
        lives = live[PlayerPrefs.GetInt("tank")];
        bullet = PlayerPrefs.GetInt("patron");
        shield = PlayerPrefs.GetInt("shield");
        plane1 = PlayerPrefs.GetInt("plane1");
        plane2 = PlayerPrefs.GetInt("plane2");
        distance = 0;
        Time.timeScale = 1f;
        k = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (lives < 0)
        {
            game_over++;
            Result();
        }

        t_coins.text = coins.ToString();

        t_crystal.text = crystal.ToString();

        if (lives >= 0)
        {
            t_lives.text = lives.ToString();
        }

        if (bullet >= 0)
        {
            t_bullet.text = bullet.ToString();
        }
        if (shield >= 0)
        {
            t_shield.text = shield.ToString();
        }
        if (plane1 >= 0)
        {
            t_plane1.text = plane1.ToString();          
        }
        if (plane2 >= 0)
        {
            t_plane2.text = plane2.ToString();
        }

        t_distance.text = Mathf.RoundToInt(distance).ToString();

        End_Resources();
    }
    public void Panel_resources()
    {
        click.Play();
        if (k % 2 == 0)
        {
            panel_res.SetActive(true);
        }
        else
        {
            panel_res.SetActive(false);
        }
        k++;

    }
    public void Open_pause()
    {
        click.Play();
        panel_pause.SetActive(true);
        Time.timeScale = 0f;
        tank.Stop();
    }
    public void Close_pause()
    {
        click.Play();
        panel_pause.SetActive(false);
        Time.timeScale = 1f;
        tank.Play();
    }
    public void Resume_pause()
    {
        click.Play();
        panel_pause.SetActive(false);
        Time.timeScale = 1f;
        tank.Play();
    }
    public void Restart_pause()
    {
        click.Play();
        PlayerPrefs.SetInt("money", coins);
        PlayerPrefs.SetInt("crystal", crystal);
        PlayerPrefs.SetInt("patron", bullet);
        PlayerPrefs.SetInt("shield", shield);
        PlayerPrefs.SetInt("plane1", plane1);
        PlayerPrefs.SetInt("plane2", plane2);
        PlayerPrefs.SetInt("max" + level.ToString(), Mathf.RoundToInt(distance));
        PlayerPrefs.Save();
        Application.LoadLevel(nomer_level);
        Time.timeScale = 1f;
    }
    public void Exit_pause()
    {
        click.Play();
        PlayerPrefs.SetInt("money", coins);
        PlayerPrefs.SetInt("crystal", crystal);
        PlayerPrefs.SetInt("patron", bullet);
        PlayerPrefs.SetInt("shield", shield);
        PlayerPrefs.SetInt("plane1", plane1);
        PlayerPrefs.SetInt("plane2", plane2);
        PlayerPrefs.SetInt("max"+level.ToString(), Mathf.RoundToInt(distance));
        PlayerPrefs.Save();
        Time.timeScale = 1f;
        Application.LoadLevel(1);
    }
    public void In_Menu()
    {
        click.Play();
        PlayerPrefs.SetInt("money", coins);
        PlayerPrefs.SetInt("crystal", crystal);
        PlayerPrefs.SetInt("patron", bullet);
        PlayerPrefs.SetInt("shield", shield);
        PlayerPrefs.SetInt("plane1", plane1);
        PlayerPrefs.SetInt("plane2", plane2);
        PlayerPrefs.SetInt("max" + level.ToString(), Mathf.RoundToInt(distance));
        PlayerPrefs.Save();
        Time.timeScale = 1f;
        Application.LoadLevel(1);
    }
    private void End_Resources()
    {
        if (int.Parse(t_shield.text) <= 0)
        {
            resource[0].interactable = false;
        }
        else
            resource[0].interactable = true;
        if (int.Parse(t_plane1.text) <= 0)
        {
            resource[1].interactable = false;
        }
        else
            resource[1].interactable = true;

        if (int.Parse(t_plane2.text) <= 0)
        {
            resource[2].interactable = false;
        }
        else
            resource[2].interactable = true;

        if (int.Parse(t_bullet.text) <= 0)
        {
            resource[3].interactable = false;
        }
        else
            resource[3].interactable = true;

        if ((PlayerPrefs.GetInt("tank") == 3 && int.Parse(t_bullet.text) < 2) || (PlayerPrefs.GetInt("tank") == 4 && int.Parse(t_bullet.text) < 2))
        {
            resource[3].interactable = false;
        }
    }
    public void Result()
    {
        PlayerPrefs.SetInt("over", game_over);
        PlayerPrefs.Save();

        result_coins.text = (coins - PlayerPrefs.GetInt("money")).ToString();
        result_crystal.text = (crystal - PlayerPrefs.GetInt("crystal")).ToString();
        result_distance.text = Mathf.RoundToInt(distance).ToString();
        panel_result.SetActive(true);
        Time.timeScale = 0f;
        tank.Stop();
    }
}
