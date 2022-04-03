using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_farm : MonoBehaviour
{
    public GameObject[] list_but = new GameObject[9];
    public GameObject but_fly;
    public GameObject panel_Setting;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound.Play();
        
    }

    public void click_Setting()
    {
        panel_Setting.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume_game()
    {
        panel_Setting.SetActive(false);
        Time.timeScale = 1f;
    }

    public void exit_menu()
    {

        Mainparametr.boolLoad = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {
        if (Mainparametr.farm_i >= 660)
        {
            for (int i = 0; i < list_but.Length; i++)
            {
                list_but[i].SetActive(false);
            }
            but_fly.SetActive(true);
        }


        
    }
}
