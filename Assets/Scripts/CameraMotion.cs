using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    private float speed;
    private float angularSpeed=01f;
    private float rotationAngle;
    private CharacterController characterController;


    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
        rotationAngle = 0f;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X");

        if (Input.GetKey(KeyCode.W))
            speed += 0.05f;
        else if (Input.GetKey(KeyCode.S))
            speed -= 0.05f;
        rotationAngle += mouse_x * angularSpeed*Time.deltaTime;
        transform.Rotate(0, rotationAngle, 0);

        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Vector3 direction=transform.TransformDirection(Vector3.forward*Time.deltaTime*speed);
        characterController.Move(direction);

    }
}
