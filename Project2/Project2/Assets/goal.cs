using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public float count;
    public float goals;
    Vector3 originalPos;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("goalie"))
        {
            Debug.Log("Goal");
            gameObject.transform.position = originalPos;
            rb.isKinematic = true;
            count = 1;
            goals++;
            Debug.Log(count);

        if(count == 1)
        {
            rb.isKinematic = false;
            count = 2;
            Debug.Log(count);
       }
      }
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnGUI()
    {
        GUI.Label (new Rect(0,600,100,100), "Goals Scored: " + goals);
    }
}
