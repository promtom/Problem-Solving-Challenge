using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void loadScene(string scene)
    {
        Application.LoadLevel(scene);
    }
    
    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quit!");
    }
}
