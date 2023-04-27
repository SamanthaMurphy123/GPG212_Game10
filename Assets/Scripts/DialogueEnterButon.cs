using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class DialogueEnterButon : MonoBehaviour
{
    public Button button;

    void Start()
    {
        // Get the button component
        if (button == null)
        {
            button = GetComponent<Button>();
        }
    }

    void Update()
    {
        // Check for the enter key press
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Invoke the button's onClick event
            button.onClick.Invoke();
        }
    }
}
