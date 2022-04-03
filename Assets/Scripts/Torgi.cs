using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torgi : MonoBehaviour
{
    public GameObject panel_Setting;
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

}