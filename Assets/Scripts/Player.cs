using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public float normspeed;
    private Rigidbody rb;
    public AudioSource coin;

    public GameObject explosion;
    public Text result_coins;
    public Text result_crystal;
    public Text result_distance;
    public GameObject panel_result;
    public AudioSource tank;
    public AudioSource bullet;
    public AudioSource cub;
    private void Start()
    {
        speed = 0f;
        rb = GetComponent<Rigidbody>();

    }
    //private void Update()
    //{
        //    float hor = Input.GetAxisRaw("Horizontal");
        //    Vector3 dir = new Vector3(hor, 0, 0);
        //    transform.Translate(dir.normalized * speed * Time.deltaTime);
    //}
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

    }
    public void OnLeftButton()
    {
        if (speed >= 0f)
        {
            speed = -normspeed;
        }
    }
    public void OnRightButton()
    {
        if (speed <= 0f)
        {
            speed = normspeed;
        }
    }
    public void OnButtonUp()
    {
        speed = 0f;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("money"))
        {
            coin.Play();
        }
        if (collision.gameObject.CompareTag("patron"))
        {
           bullet.Play();
        }
        if (collision.gameObject.CompareTag("crystal"))
        {
            coin.Play();
        }
        if (collision.gameObject.CompareTag("cub"))
        {
            cub.Play();
        }
        if (collision.gameObject.CompareTag("tank"))
        {
            Vector3 Pose = transform.position;
            Quaternion pos = transform.rotation;
            Instantiate(explosion, Pose, pos);
            Resources.game_over++;
            Result();
        }
    }
    public void Result()
    {
        PlayerPrefs.SetInt("over", Resources.game_over);
        PlayerPrefs.Save();

        result_coins.text = (Resources.coins - PlayerPrefs.GetInt("money")).ToString();
        result_crystal.text = (Resources.crystal - PlayerPrefs.GetInt("crystal")).ToString();
        result_distance.text = Mathf.RoundToInt(Resources.distance).ToString();
        panel_result.SetActive(true);
        Time.timeScale = 0f;
        tank.Stop();
    }
}
