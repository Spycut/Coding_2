using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputFromDevice : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector3 direction;


    [SerializeField]
    private bool useGamePad;



    private void Update()
    {
        if (useGamePad)
        {
            MoveDirectlyByGamePadInput();
        }

        else
        {
            MoveDirectlyByKeyboardInput();
        }
    }

    private void MoveDirectlyByKeyboardInput()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard.aKey.isPressed)
        {
            transform.Translate(-direction.normalized * (speed * Time.deltaTime)); 
        }


        if (keyboard.dKey.isPressed)
        {
            transform.Translate(-direction.normalized * (speed * Time.deltaTime));
        }
    }

    private void MoveDirectlyByGamePadInput()
    {


        Gamepad gamepad = Gamepad.current;


        if (gamepad.squareButton.isPressed)
        {
            transform.Translate(-direction.normalized * (speed * Time.deltaTime));
        }


        if (gamepad.circleButton.isPressed)
        {
            transform.Translate(-direction.normalized * (speed * Time.deltaTime));
        }

    }




   
}
