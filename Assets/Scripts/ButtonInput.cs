using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInput : MonoBehaviour
{
    public void LoadScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
