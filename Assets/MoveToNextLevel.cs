using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveToNextLevel : MonoBehaviour
{
    private string Level2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    

    public void NextScene()
    {
        SceneManager.LoadScene(Level2);
    }
    // Update is called once per frame
    
}
