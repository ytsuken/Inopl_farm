using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Loadingmainscene : MonoBehaviour
{
    float tim = 0f;
    // Start is called before the first frame update
    void Start()
    {
        tim += Time.time;     
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.time);
       if ((Time.time-tim) > 1.3)
        {
            if (Mainparametr.boolLoad == true)
            {
                SceneManager.LoadScene(0);
            }
           else if (Mainparametr.boolLoad == false)
            {
                Mainparametr.boolLoad = true;
                SceneManager.LoadScene(1);

            }
        }
    }
}
