using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menupanel;
    public GameObject infopanel;
    public GameObject settingspanel;

  
    void Start()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
        settingspanel.SetActive(false);
    }

   

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void InfoButton()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);
        settingspanel.SetActive(false);
        
    }

    public void BackButton()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
        settingspanel.SetActive(false);
    }

    public void SettingsButton()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(false);
        settingspanel.SetActive(true);

    }

    public void BackButton2()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
        settingspanel.SetActive(false);

    }
}

