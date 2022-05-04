using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public GameObject loadingPanel;
    public static NextScene instance;
    public string sceneName;
    private string targetScene;
    public float minLoadTime;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        loadingPanel.SetActive(false);
    }

    public void Load_Scene()
    {
         targetScene = sceneName;
         StartCoroutine(LoadSceneRoutine());
         
    }

    public IEnumerator LoadSceneRoutine ()
    {
        loadingPanel.SetActive(true);
        AsyncOperation op = SceneManager.LoadSceneAsync(targetScene);
        float elapsedLoadTime = 0f;
        while (!op.isDone)
        {
            elapsedLoadTime += Time.deltaTime;
            yield return null;
        }
        while(elapsedLoadTime < minLoadTime)
        {
            elapsedLoadTime += Time.deltaTime;
            yield return null;
        }

        loadingPanel.SetActive(false);
    }
}
