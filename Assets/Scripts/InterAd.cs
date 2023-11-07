using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterAd : MonoBehaviour
{
    private InterstitialAd interstitialAd;

    // test
   private string interstitialUnitId = "ca-app-pub-3940256099942544/1033173712";
    //private string interstitialUnitId = "ca-app-pub-2041808174898455/5684991541";
    private void OnEnable()
    {
        interstitialAd = new InterstitialAd(interstitialUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(adRequest);
    }
    private void Update()
    {
        ShowAd();
    }
    public void ShowAd()
    {
        if (PlayerPrefs.GetInt("over") >= 6)
        {
            if (interstitialAd.IsLoaded())
            {
                interstitialAd.Show();
                PlayerPrefs.SetInt("over", 0);
                PlayerPrefs.Save();
                //Debug.Log("over");
            }
        }
    }
}
