using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
//using UnityEngine.UI;
using Firebase.Messaging;

public class FirebaseToken : MonoBehaviour
{   
    /*
    [SerializeField] InputField myName;
    [SerializeField] InputField recieverName;
    protected string serverKey ="AAAAWsbbFvo:APA91bH3PDfF8AzciF5-VIixdH_syWx3lrI2WjHUJWEmT6urXAv1My_e7PMsntkmvD01xwPmyFVEUbfZoKl_iKJpJCjOxtIyNxVt7URjhdp-m77IYMP0h3chPgZ8Iy6i8fODFcbxJNBW";
    [SerializeField] string url = "https://fcm.googleapis.com/fcm/send";
    [SerializeField] string ScriptUrl;
    */
    public void Start() {
    Firebase.Messaging.FirebaseMessaging.TokenReceived += OnTokenReceived;
    Firebase.Messaging.FirebaseMessaging.MessageReceived += OnMessageReceived;

}
    /*
    public void Subscribe()
    {
        Firebase.Messaging.FirebaseMessaging.SubscribeAsync("/topics/"+myName.text);
    }

    public void  SendNotification()
    {
        string recepient = recieverName.text;
       
    }

    IEnumerator  SendMessage (string recepient)
    {
        WWWForm webform = new WWWForm();
        webform.AddField("serverKey",serverKey);
        webform.AddField("url",url);
        webform.AddField("recipient","/topics/"+recepient);
        webform.AddField("Notification_Title","testtesttest");
        webform.AddField("Notification_Body",$"{myName} test it");

        WWW serverCall = new WWW(ScriptUrl,webform);
        yield return serverCall;
        Debug.Log("start sending Message");
    }
    */
    public void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs token) {
    UnityEngine.Debug.Log("Received Registration Token: " + token.Token);
    }

    public void OnMessageReceived(object sender, Firebase.Messaging.MessageReceivedEventArgs e) {
    UnityEngine.Debug.Log("Received a new message from: " + e.Message.From);
}
}
