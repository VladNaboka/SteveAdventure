using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class AdLose : MonoBehaviour
{
#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-2456268673033762/4407550969";
#elif UNITY_IPHONE
          private string _adUnitId = "ca-app-pub-2456268673033762/4407550969";
#else
          private string _adUnitId = "unused";
#endif

    private InterstitialAd interstitialAd;

    //private string interstitialUnitId = "ca-app-pub-2456268673033762/4407550969";

    private void OnEnable()
    {
        interstitialAd = new InterstitialAd(_adUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(adRequest);
    }

    public void ShowAd()
    {
        if (interstitialAd.IsLoaded())
            interstitialAd.Show();
    }

//    // These ad units are configured to always serve test ads.
//#if UNITY_ANDROID
//    private string _adUnitId = "ca-app-pub-2456268673033762/4407550969";
//#elif UNITY_IPHONE
//      private string _adUnitId = "ca-app-pub-2456268673033762/4407550969";
//#else
//      private string _adUnitId = "unused";
//#endif

//    private InterstitialAd interstitialAd;

//    public static AdLose Instance;

//    private void Awake()
//    {
//        if (Instance != null)
//        {
//            Destroy(gameObject);
//            return;
//        }
//        Instance = this;
//        DontDestroyOnLoad(gameObject);
//    }

//    private void Start()
//    {
//        MobileAds.Initialize((InitializationStatus initStatus) =>
//        {
//            // This callback is called once the MobileAds SDK is initialized.
//        });

//        LoadInterstitialAd();
//    }

//    /// <summary>
//    /// Loads the interstitial ad.
//    /// </summary>
//    public void LoadInterstitialAd()
//    {
//        // Clean up the old ad before loading a new one.
//        if (interstitialAd != null)
//        {
//            interstitialAd.Destroy();
//            interstitialAd = null;
//        }

//        Debug.Log("Loading the interstitial ad.");

//        // create our request used to load the ad.
//        var adRequest = new AdRequest();
//        adRequest.Keywords.Add("unity-admob-sample");

//        // send the request to load the ad.
//        InterstitialAd.Load(_adUnitId, adRequest,
//            (InterstitialAd ad, LoadAdError error) =>
//            {
//                // if error is not null, the load request failed.
//                if (error != null || ad == null)
//                {
//                    Debug.LogError("interstitial ad failed to load an ad " +
//                                   "with error : " + error);
//                    return;
//                }

//                Debug.Log("Interstitial ad loaded with response : "
//                          + ad.GetResponseInfo());

//                interstitialAd = ad;
//                RegisterEventHandlers(interstitialAd);
//            });
//    }

//    /// <summary>
//    /// Shows the interstitial ad.
//    /// </summary>
//    public void ShowInterstitialAd()
//    {
//        if (interstitialAd != null && interstitialAd.CanShowAd())
//        {
//            Debug.Log("Showing interstitial ad.");
//            interstitialAd.Show();
//        }
//        else
//        {
//            Debug.LogError("Interstitial ad is not ready yet.");
//        }
//    }

//    private void RegisterEventHandlers(InterstitialAd ad)
//    {
//        // Raised when the ad is estimated to have earned money.
//        ad.OnAdPaid += (AdValue adValue) =>
//        {
//            Debug.Log(String.Format("Interstitial ad paid {0} {1}.",
//                adValue.Value,
//                adValue.CurrencyCode));
//        };
//        // Raised when an impression is recorded for an ad.
//        ad.OnAdImpressionRecorded += () =>
//        {
//            Debug.Log("Interstitial ad recorded an impression.");
//        };
//        // Raised when a click is recorded for an ad.
//        ad.OnAdClicked += () =>
//        {
//            Debug.Log("Interstitial ad was clicked.");
//        };
//        // Raised when an ad opened full screen content.
//        ad.OnAdFullScreenContentOpened += () =>
//        {
//            Debug.Log("Interstitial ad full screen content opened.");
//        };
//        // Raised when the ad closed full screen content.
//        ad.OnAdFullScreenContentClosed += () =>
//        {
//            Debug.Log("Interstitial Ad full screen content closed.");

//            // Reload the ad so that we can show another as soon as possible.
//            LoadInterstitialAd();
//        };
//        // Raised when the ad failed to open full screen content.
//        ad.OnAdFullScreenContentFailed += (AdError error) =>
//        {
//            Debug.LogError("Interstitial ad failed to open full screen content " +
//                           "with error : " + error);

//            // Reload the ad so that we can show another as soon as possible.
//            LoadInterstitialAd();
//        };
//    }
}
