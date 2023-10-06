using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GoToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
