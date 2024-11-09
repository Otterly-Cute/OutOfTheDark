using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Camera_Movement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=ONlMEZs9Rgw move
    //https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/ camera zoom
    //https://www.youtube.com/watch?v=H7pjj1K91HE drag and drop

    public InputActionReference move;
    public InputActionReference click;
    public InputActionReference zoom;

    private Rigidbody rb;
    private Vector3 moveDirection;
    public float moveSpeed;

    private Camera cam;
    public float zoomSpeed;
    public float minZoom = 30;
    public float maxZoom = 100;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        moveDirection = move.action.ReadValue<Vector3>();

        if (zoom.action.ReadValue<float>() > 0 )
        {
            ZoomCamera(minZoom);
        }
        else if (zoom.action.ReadValue<float>() < 0)
        {
            ZoomCamera(maxZoom);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity= new Vector3(x:moveDirection.x * moveSpeed,y:moveDirection.y * 0,z:moveDirection.z * moveSpeed).normalized; 
    } 

    private void OnEnable()
    {
        click.action.started += Click;
    }

    private void OnDisable()
    {
        click.action.started -= Click;
    }

    private void Click(InputAction.CallbackContext obj)
    {
        Debug.Log(message: "clicked");
    }
    /// <summary>
    /// https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/
    /// </summary>
    /// <param name="target"></param>
    void ZoomCamera(float target)
    {
        cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, zoomSpeed * Time.deltaTime);
    }

}
