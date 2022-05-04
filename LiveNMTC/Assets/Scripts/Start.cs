using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
public AudioSource mechanical;
public AudioSource music;
public Animator introAnimation;
public Animator rightDoor;
public Animator leftDoor;

private int nbClick = 0;

public void OnPlay()
{
  nbClick ++;
  if(nbClick == 1)
  {
  introAnimation.Play("logo_entrance_animation");
  rightDoor.Play("RightDoor_open");
  leftDoor.Play("LeftDoors_open");
  mechanical.Play();
  StartCoroutine(PlayMusic());
  StartCoroutine(LoadNextScene());
  }

  }    
private IEnumerator PlayMusic() 
    {
        yield return new WaitForSeconds(2);
        Debug.Log(mechanical.clip.length);
        music.Play();
}
private IEnumerator LoadNextScene() 
    {
        yield return new WaitForSeconds(6);
        Debug.Log(name);
        SceneManager.LoadScene("Scene1");
}
}
