using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class PlanningInfo : MonoBehaviour
{

public GameObject Target;
public GameObject vb;

void Start()
{
    //vb = GameObject.Find("Lociebtn";)
    vb.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);

}
public void OnButtonPressed(VirtualButtonBehaviour vb)
{
    Debug.Log("pressed!");
    Target.SetActive(true);
}
}