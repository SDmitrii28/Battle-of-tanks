using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading_game : MonoBehaviour
{
    public int level;
    public Slider sl;
    public Text tx;
    void Start()
    {
        load(level);
    }
    private void load(int level)
    {
        //Application.LoadLevel(level);
        StartCoroutine(LoadAsync());
    }
    private void Update()
    {
        tx.text = ((Mathf.RoundToInt(sl.value))).ToString() + "%";
    }
    IEnumerator LoadAsync()
    {
        // AsyncOperation asyncload = Application.LoadLevelAsync(level);
        while (sl.value != sl.maxValue)
        {
            //sl.value = asyncload.progress;
            sl.value += Time.deltaTime * 4;
            if (sl.value == 100)
            {
                Application.LoadLevel(level);
            }
            yield return 0;
        }
    }
}

