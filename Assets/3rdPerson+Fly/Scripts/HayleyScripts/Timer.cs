using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 45f;

    public GameObject gameOverTimeUI;
    public GameObject gameOverUI;
    public GameObject timerUI;

    [SerializeField] TMP_Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerUI.activeSelf)
        {
            currentTime -= Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 10)
            {
                countdownText.color = Color.red;
            }

            if (currentTime < 0)
            {
                Debug.Log("GameOver!");
                Time.timeScale = 0f;
                gameOverTimeUI.SetActive(true);
            }
        }

    }
}
