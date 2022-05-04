using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HypertextLink : MonoBehaviour
{
public void VisitLink(string link)
{
    Application.OpenURL(link);
}
}
