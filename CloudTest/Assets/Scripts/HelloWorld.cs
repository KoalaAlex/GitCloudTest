using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour {
    public Text textField;
    private bool textChanged = false;
    private string savedText;

    private void Start()
    {
        savedText = textField.text;
    }

    public void PushAndToggleText() {
        if (!textChanged)
        {
            textField.text = "Hello World";
        }
        else {
            textField.text = savedText;
        }
        textChanged = !textChanged;
    }
}
