using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "wall")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
   }
}
