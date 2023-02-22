using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("pickUp")) //will destroy on pickup
        {
           
            GameObject.Destroy(collision.collider.gameObject);
            Debug.Log("Goal");
            restartCurrentLevel();
        
        }
    }
    void  restartCurrentLevel()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
