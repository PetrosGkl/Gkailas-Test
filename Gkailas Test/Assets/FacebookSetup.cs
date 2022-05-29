using Facebook.Unity;
using UnityEngine;

public class FacebookSetup : MonoBehaviour
{
    private void Awake()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
            Application.targetFrameRate = 60;
        if (FB.IsInitialized)
            FB.Init(FBInitCallBack);
    }

    private void FBInitCallBack()
    {
        if (FB.IsInitialized)
            FB.ActivateApp();
    }

    public void OnApplicationPause(bool pause)
    {
        if (!pause)
            if (FB.IsInitialized)
                FB.ActivateApp();
    }

}
