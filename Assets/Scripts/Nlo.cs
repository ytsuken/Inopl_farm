using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nlo : MonoBehaviour
{
    // public GameObject obj;
    public Animation anim;
    public Animator m_Animator;
    float time = 0f;
    public Text scenetext;
       void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        m_Animator = gameObject.GetComponent<Animator>();

    }
    public void click()
    {
        m_Animator.SetTrigger("click");
            Mainparametr.farm_i += 100;
            scenetext.text = Mainparametr.farm_i.ToString();


    }
}
