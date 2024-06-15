using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInputController : MonoBehaviour
{
    [SerializeField] Text output;
    [SerializeField] InputField input;

    public void SendInput()
    {
            output.text = input.text;
            input.text = "";
        
    }


}
