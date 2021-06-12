using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{

    //HARRY THIS IS YOUR SCRIPT

    public Rigidbody2D rb;
    public Camera cam;
    //public GameObject ball;

    private Vector2 mousePos; //mouse position
    private Vector2 lookDir;  //look direction

    private float shootAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        lookDir = mousePos - rb.position;
        shootAngle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        rb.rotation = shootAngle;
    }
}
