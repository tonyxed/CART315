using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;

    private Rigidbody2D playerMovement;

    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    //updates every frame instead of only 1 frame
    void FixedUpdate()
    {
        playerMovement.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
