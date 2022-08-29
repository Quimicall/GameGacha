using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D playerRb;

    Vector2 movimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movimento * speed * Time.fixedDeltaTime);
    }
}
