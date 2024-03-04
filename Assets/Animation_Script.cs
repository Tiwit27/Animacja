using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Animation_Script : MonoBehaviour
{
    public GameObject kontroler;
    public GameObject wedkarz1;
    public GameObject wedkarz2;
    public GameObject wedka;
    public GameObject kamera;

    public bool[] scenes = new bool[20];
    private void Start()
    {
        FirstScene();
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i] = false;
        }
    }
    public void FirstScene()
    {
        kontroler.GetComponent<Animator>().SetBool("walking", true);
    }
    private void FixedUpdate()
    {
        //first scene
        if(kontroler.GetComponent<Animator>().GetBool("walking") && kontroler.transform.position.z < 526.5f)
        {
            kontroler.transform.position += new Vector3(-1.5f, -3.2f, 31) * 0.005f;
            if(kontroler.transform.position.z > 515f)
            {
                wedka.transform.position += new Vector3(2,0,3) * 0.07f;
            }
        }
        else
        {
            kontroler.GetComponent<Animator>().SetBool("walking", false);
            scenes[0] = true;
        }
        if (scenes[0])
        {
            kamera.GetComponent<Animator>().SetInteger("scene", 1);
        }
    }
}
