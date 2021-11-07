using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{

    public float speed = 10f;
    private float translation;
    private float straffe;
    
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
