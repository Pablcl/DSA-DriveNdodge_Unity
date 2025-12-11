using UnityEngine;

public class uiManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Play(){
	Application.LoadLevel ("SampleScene");
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause() {

    if (Time.timeScale == 1) {
        Time.timeScale = 0;
    }

    else if (Time.timeScale == 0) {
        Time.timeScale = 1;
    }

  public void Replay(){
    Application.LoadLevel(Application.loadedLevel);
    }

    public void Menu(){

    Application.LoadLevel("MenuScene");
    }
    public void Exit(){
	Application.Quit ();
    }


}

	
}
