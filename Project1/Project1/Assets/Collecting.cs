using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    int someInt = 30;
    int papers = 0;
    public AudioSource paperPickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Paper")
        {   
            Col.gameObject.SetActive(false);
            papers++;
            paperPickUp.Play();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI(){
        GUI.skin.label.fontSize = someInt;
        GUI.Label (new Rect (0, 400, 500, 100), "Paper's collected :" + papers + "/3");
    
    }
}
