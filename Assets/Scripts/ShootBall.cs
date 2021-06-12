using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{

    //HARRY THIS IS YOUR SCRIPT

    public Rigidbody2D rb;
    public Camera cam;
    public GameObject arrow;

    private Vector2 mousePos; //mouse position
    private Vector2 lookDir;  //look direction

    private float shootAngle;

    private bool aimOn = true;  //is the player currently aiming

    // Start is called before the first frame update
    void Start()
    {
        //arrow.transform.scale.x = 5;
        //arrow.transform.localScale = new Vector3(20, 3, 1);
        //arrow.transform.scale.y = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        while (aimOn == true)
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

            lookDir = mousePos - rb.position;
            shootAngle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

            rb.rotation = shootAngle;
        }
    }


}
