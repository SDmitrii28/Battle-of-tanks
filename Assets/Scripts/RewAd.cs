using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class RewAd : MonoBehaviour
{
    // test
   private string RewardedUnitId = "ca-app-pub-3940256099942544/5224354917";
    //private string RewardedUnitId = "ca-app-pub-2041808174898455/2933817073";
    private RewardedAd rewardedAd;
    private void OnEnable()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        //int coins = PlayerPrefs.GetInt("coins");
        //coins += 150;
        //PlayerPrefs.SetInt("coins", coins);
        Menu.money += 5000;
    }

    public void ShowAd()
    {
        if (rewardedAd.IsLoaded())
            rewardedAd.Show();
    }
}
