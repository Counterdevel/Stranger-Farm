using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautaMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;

    public float turnsSmoothTime = 0.1f;
    float turnSmoothVelocity;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude > 0.1)
        {
            float angleDirection = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angleDirection, ref turnSmoothVelocity, turnsSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
 