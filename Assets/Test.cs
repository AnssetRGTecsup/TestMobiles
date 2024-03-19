using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    private float totalTime = 0f;
    private bool allowIncrease = false;

    private void Update()
    {
        /*if (!allowIncrease) return;
        totalTime += Time.deltaTime;*/
    }

    public void OnTouch(InputAction.CallbackContext context)
    {
        Debug.Log(string.Format("Hola Brando - {0}", context.phase));
        /*switch (context.phase)
        {
            case InputActionPhase.Waiting:
                Debug.Log("Waiting");
                break;
            case InputActionPhase.Disabled:
                Debug.Log("Disabled");
                break;
            case InputActionPhase.Started:
                Debug.Log("Started");
                //allowIncrease = true;
                break;
            case InputActionPhase.Performed:
                Debug.Log(string.Format("Performed - {0:f2}", totalTime));
                break;
            case InputActionPhase.Canceled:
                Debug.Log("Canceled");
                //allowIncrease = false;
                break;
        }*/
    }
}
