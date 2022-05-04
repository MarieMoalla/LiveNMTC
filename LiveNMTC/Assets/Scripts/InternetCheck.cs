using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetCheck : MonoBehaviour
{
   public GameObject go;
    void Start()
    {
         if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Error. Check internet connection!");
            go.SetActive(true);
        }
    }

}
