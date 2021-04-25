using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _01_InputsSystem
{
    public class InputSideBySide : MonoBehaviour
    {
        private void Update()
        {
            ExecuteNewInput();
        }


        private void ExecuteOldInput()
        {
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log(message: "Pressing the A Key on my Keyboard, yay!");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log(message: "Pressing the Key A down on my Keayboard, yay");
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log(message:  "Lifting my finger from the A Key on my Keayboard, yay");
            }
        }

        private void ExecuteNewInput()
        {
            Keyboard myKeyboard = Keyboard.current;

            if (myKeyboard.aKey.isPressed)
            {
                Debug.Log(message: "Pressing the A Key on my Keyboard, yay!");
            }


            if (myKeyboard.aKey.wasPressedThisFrame)
            {
                Debug.Log(message: "Pressing the Key A down on my Keayboard, yay");
            }

            if (myKeyboard.aKey.wasReleasedThisFrame)
            {
                Debug.Log(message: "Lifting my finger from the A Key on my Keayboard, yay");
            }

        }

    }

}