using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFlowers : MonoBehaviour
{
// public GameObject obj;
    public Animation anim;
    public  Animator m_Animator;
    float time = 0f;
    public Text scenetext;
    public GameObject butFly;
    // Start is called before the first frame update
    public int ochki;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        m_Animator = gameObject.GetComponent<Animator>();



    }
    public void click()
    {

        Debug.Log("asdad");
        //m_Animator.SetBool("Click", true);
        m_Animator.SetTrigger("click");
        if (Mainparametr.farm_i < 660)
        {
            Mainparametr.farm_i += ochki;
            scenetext.text = Mainparametr.farm_i.ToString();
        }
        

     }

        // yield return new WaitForSeconds(7);
        //anim.Play("Octopusik_click
    public void fly_exit()
    {
        
            m_Animator.SetBool("click", true);
        
    }

    
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        
    }

    // Update is called once per frame
    void Update()
    {
        // m_Animator.SetBool("Click", false);
    }
}
