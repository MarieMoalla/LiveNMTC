using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenShotHandler : MonoBehaviour
{
    #region variables
    //static instance of the static function "ScreenshotHandler"
	private static ScreenShotHandler instance;
    public Camera myCamera; 
	private bool takeScreenshotOnNextFrame;
    #endregion

    #region Awake method
    private void Awake()
    {
            instance = this;
    }
    #endregion

    #region on capture public method
    public  void OnCapture ()
	{
		    Debug.Log("OnCapture enter checked!");
        
            instance.TakeScreenshot(Screen.width,Screen.height);
	}
    #endregion
    
    #region Take screen shot method
    private void TakeScreenshot(int width, int height)
	{
			Debug.Log("TakeScreenshot enter checked!");
            //the target texture will be the layer put ontop of our camera to represent the picture we are taking
			//used to controle the width and hight of image instead of having the whole camera
			myCamera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
            
			takeScreenshotOnNextFrame = true;
            OnPostRender();
    }
    #endregion

	//in order to take the screenshot image we need to capture it after rendering the current frame
	//this method will trigger every frame
	#region Camera renderer method
    private void OnPostRender()
	{
       if(takeScreenshotOnNextFrame) 
		{
            Debug.Log("OnPostRender enter checked!");
			takeScreenshotOnNextFrame = false;
			RenderTexture renderTexture = myCamera.targetTexture;
            
            Texture2D screenShot = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
            myCamera.Render();
            RenderTexture.active = myCamera.targetTexture;
            screenShot.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
            string filename = ScreenShotName(renderTexture.width, renderTexture.height);
            /*
            #region save in pc
            //File.WriteAllBytes(Application.persistentDataPath + "/" + filename, screenShot.EncodeToPNG());
            byte[] bytes = screenShot.EncodeToPNG();
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            #endregion
            */
            #region save in mobile
            NativeGallery.SaveImageToGallery(screenShot, filename,"NMTC" );
            #endregion
			//cleanUp
			RenderTexture.ReleaseTemporary(renderTexture);
			myCamera.targetTexture = null;
        }
	}
    #endregion
    
    #region screenshot name maker
    public static string ScreenShotName(int width, int height) 
    {
            return string.Format("{0}/screenshots/screen_{1}x{2}_{3}.png", 
            Application.dataPath, 
            width, height, 
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }  
    #endregion

}
