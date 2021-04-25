using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputFromAction : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector2 movementDirection;

    private float dir;


    public void MoveLeft(InputAction.CallbackContext context)
    {
        float input = context.ReadValue<float>();
        if (context.phase == InputActionPhase.Performed)
        {
            input *= -1;
        }

        dir = input;

    }


    public void MoveRight(InputAction.CallbackContext context)
    {
        float input = context.ReadValue<float>();
        if (context.phase == InputActionPhase.Performed)
        {
            input *= 1;
        }

        dir = input;
    }

    private void Update()
    {
        transform.Translate(translation: movementDirection.normalized * dir * (speed * Time.deltaTime));
    }
}