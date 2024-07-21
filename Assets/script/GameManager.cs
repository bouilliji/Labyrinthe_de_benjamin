using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Button quitButton;
    [SerializeField]
    private GameObject quitButtonGameObject;
    [SerializeField]
    private Button restartButton;
    [SerializeField]
    private GameObject startMenu;
    [SerializeField] 
    private GameObject breakMenu;

    private void Awake()
    {
        startButton.onClick.AddListener(startFunction);
        restartButton.onClick.AddListener(restart);
    }


    private void Start()
    {
        Time.timeScale = 0f;
        breakMenu.SetActive(false);
    }

    private void startFunction()
    {
        Time.timeScale = 1f;
        startMenu.SetActive(false);
        quitButtonGameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void breakFunction()
    {
        Time.timeScale = 0f;
        breakMenu.SetActive(true);
        quitButtonGameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void restart()
    {
        Time.timeScale = 1f;
        breakMenu.SetActive(false);
        quitButtonGameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            breakFunction();
        }
    }
}
