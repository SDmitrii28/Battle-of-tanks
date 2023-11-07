using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Volume : MonoBehaviour
{
    public AudioMixerGroup mixer;
    private int k;
    private int k1;
    public GameObject[] on;
    public GameObject[] off;
    public AudioSource click;

    public void Start()
    {
        //PlayerPrefs.DeleteAll();
        Music_start();
        Sounds_start();

    }
    private void Music_start()
    {
        if (PlayerPrefs.HasKey("music_volume"))
        {
            k = PlayerPrefs.GetInt("music_volume");
            if (k == 1)
            {
                on[0].SetActive(true);
                off[0].SetActive(false);
                mixer.audioMixer.SetFloat("MyExposedParam", 20);
            }
            else
            {
                on[0].SetActive(false);
                off[0].SetActive(true);
                mixer.audioMixer.SetFloat("MyExposedParam", -80);
            }
        }
        else
        {
            on[0].SetActive(true);
            off[0].SetActive(false);
            mixer.audioMixer.SetFloat("MyExposedParam", 20);
            k = 0;
        }
    }

    private void Sounds_start()
    {
        if (PlayerPrefs.HasKey("sounds_volume"))
        {
            k1 = PlayerPrefs.GetInt("sounds_volume");
            if (k1 == 1)
            {
                on[1].SetActive(true);
                off[1].SetActive(false);
                mixer.audioMixer.SetFloat("MyExposedParam 1", 20);
            }
            else
            {
                on[1].SetActive(false);
                off[1].SetActive(true);
                mixer.audioMixer.SetFloat("MyExposedParam 1", -80);
            }
        }
        else
        {
            on[1].SetActive(true);
            off[1].SetActive(false);
            mixer.audioMixer.SetFloat("MyExposedParam 1", 20);
            k1 = 0;
        }
    }
    // Start is called before the first frame update
    public void ToggleVolume()
    {
        click.Play();
        if (k % 2 == 1)
        {
            on[0].SetActive(true);
            off[0].SetActive(false);
            mixer.audioMixer.SetFloat("MyExposedParam", 20);
            PlayerPrefs.SetInt("music_volume",1);
        }
        else
        {
            on[0].SetActive(false);
            off[0].SetActive(true);
            mixer.audioMixer.SetFloat("MyExposedParam", -80);
            PlayerPrefs.SetInt("music_volume", 0);
        }
        k++;
        PlayerPrefs.Save();
    }

    public void ToggleVolumeSounds()
    {
        click.Play();
        if (k1 % 2 == 1)
        {
            on[1].SetActive(true);
            off[1].SetActive(false);
            mixer.audioMixer.SetFloat("MyExposedParam 1", 20);
            PlayerPrefs.SetInt("sounds_volume", 1);
        }
        else
        {
            on[1].SetActive(false);
            off[1].SetActive(true);
            mixer.audioMixer.SetFloat("MyExposedParam 1", -80);
            PlayerPrefs.SetInt("sounds_volume", 0);
        }
        k1++;
        PlayerPrefs.Save();
    }
}
