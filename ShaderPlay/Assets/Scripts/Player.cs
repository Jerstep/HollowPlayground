using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Controller))]
public class Player : MonoBehaviour
{
    float gravity = -20;
    Vector3 velocity;

    Controller controller;

    void Start()
    {
        controller = GetComponent<Controller>();
    }
    
    void Update()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
