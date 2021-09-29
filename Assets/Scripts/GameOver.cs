using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button RestartButton;
    public Text WonText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("GameOver");
        WonText.gameObject.SetActive(true);
       // WonText.enabled = true;

    }

    void RestartLevelOnClick()
    {
        SceneManager.LoadScene("a");
    }

    private void Start()
    {
        RestartButton.onClick.AddListener(RestartLevelOnClick);
    }
}
