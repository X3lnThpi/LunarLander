using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public Button StartButton;
    //Button OptionButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartContext);
    }

    void StartContext()
    {
        SceneManager.LoadScene("a");
        Debug.Log("Start Button Pressed");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
}
