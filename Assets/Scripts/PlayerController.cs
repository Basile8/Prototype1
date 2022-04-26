using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed;
    public float turnRotate = 40;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed * forwardInput);
        transform.Rotate(Vector3.up, turnRotate * horizontalInput * Time.deltaTime);
       // transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
       // transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
