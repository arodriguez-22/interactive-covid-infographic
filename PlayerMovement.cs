/*
Angelina Rodriguez's Interactive Covid-19 Infographic

*/


using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;

    private void Awake()
    {
        //Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //flips player when moving left
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(5,5,1);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-5, 5, 1);


        //jump animation
        if(Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);

        // Freeze the rotation
        body.freezeRotation = true;

        //Run animation
       // anim.SetBool("run", horizontalInput != 0);


    }
}
