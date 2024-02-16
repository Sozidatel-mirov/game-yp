using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float jumpStrength = 2f;
   [SerializeField] private float maxGroundDistance = 0.3f;

    private Rigidbody rb;
    private Transform groundCheckObject;

    private bool isgrounded;

    [SerializeField] private float speed = 5f;
    private Vector2 velocity;
    void Start()
    {
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        groundCheckObject = GameObject.FindGameObjectWithTag("GroundCheck").transform;
    }

    void Update()
    {
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);

        isgrounded = Physics.Raycast(groundCheckObject.transform.position, Vector3.down, maxGroundDistance);

        if(Input.GetButtonDown("Jump") && isgrounded)
        {
            rb.AddForce(Vector3.up * 100 * jumpStrength);
        }
    }
}
