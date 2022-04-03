using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    public GameObject Setting;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void load_loading()
    {
        SceneManager.LoadScene(2);
    }

    public void load_learning()
    {
        SceneManager.LoadScene(3);
    }

    public void load_menu()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
