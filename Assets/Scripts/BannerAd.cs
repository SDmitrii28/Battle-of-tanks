using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerAd : MonoBehaviour
{

    private BannerView bannerAd;

    // test
    private string bannerId = "ca-app-pub-3940256099942544/6300978111";
    //private string bannerId = "ca-app-pub-2041808174898455/5490647904";
    private void Start()
    {
        bannerAd = new BannerView(bannerId,AdSize.Banner,AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();
        bannerAd.LoadAd(adRequest);
    }
    public void DestroyBanner()
    {
        bannerAd.Destroy();
    }
}
