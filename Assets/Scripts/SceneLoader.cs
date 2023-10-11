using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GoToScene1()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("SecondScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainScene"))
        {
            SceneManager.LoadScene("MainScene"); // 
        }
        else if (other.CompareTag("SecondScene"))
        {
            SceneManager.LoadScene("SecondScene"); // 
        }
        else if (other.CompareTag("ThirdScene"))
        {
            SceneManager.LoadScene("ThirdScene"); // ThirdScene 
        }



    }
}
