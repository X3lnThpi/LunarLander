using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public Button StartButton;
    public Image RulesImage;
    public Button OptionButton;
    public Button CloseButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartContext);
        OptionButton.onClick.AddListener(ShowRules);
        CloseButton.onClick.AddListener(HideRules);
    }

    void StartContext()
    {
        SceneManager.LoadScene("a");
        Debug.Log("Start Button Pressed");
    }

    void ShowRules()
    {
        RulesImage.gameObject.SetActive(true);
    }

    void HideRules()
    {
        RulesImage.gameObject.SetActive(false);
    }    

    // Update is called once per frame
    void Update()
    {
       
    }

    
}
