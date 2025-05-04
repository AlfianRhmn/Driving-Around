using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isEscPressed = false;

    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject carAudio;

    void Start()
    {
        pausePanel.SetActive(false);
        carAudio.SetActive(true);
    }

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (isEscPressed == false && Input.GetKeyDown(KeyCode.Escape))
        {
            isEscPressed = true;
            pausePanel.SetActive(true);
            carAudio.SetActive(false);
            Time.timeScale = 0f;
        }
        else if (isEscPressed == true && Input.GetKeyDown(KeyCode.Escape))
        {
            isEscPressed = false;
            pausePanel.SetActive(false);
            carAudio.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
