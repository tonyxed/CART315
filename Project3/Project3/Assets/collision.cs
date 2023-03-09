using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collision : MonoBehaviour
{
    public int coins;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pickup")
        {
            other.gameObject.SetActive(false);
            coins +=1;


        }
        if(coins == 11)
        {
            
        }
    }

}
