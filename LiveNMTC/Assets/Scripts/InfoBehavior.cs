using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehavior : MonoBehaviour
{
    const float speed = 6f;

    
    public Transform SectionInfo;
    Vector3 desiredScale = Vector3.zero;

    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * speed);
    }

    public void OpenInfo()
    {
        desiredScale = Vector3.one;
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }
}
