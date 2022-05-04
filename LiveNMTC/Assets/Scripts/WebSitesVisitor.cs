using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebSitesVisitor : MonoBehaviour
{
    private string bntName;
    public string Website;
    public string facebook;
    public string linkedin;
    public string instagram;
    void Update()
      {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                Debug.Log("interracting!");
                bntName = Hit.transform.name;
                switch (bntName)
                {
                    case "website_btn" :
                        Application.OpenURL(Website);
                        break;
                    case "facebook" :
                        Application.OpenURL(facebook);
                        break;
                    case "linkedin" :
                        Application.OpenURL(linkedin);
                        break;
                    case "instagram" :
                        Application.OpenURL(instagram);
                        break; 
                    default:
                        break;
                }
            }
          }
      }
}
