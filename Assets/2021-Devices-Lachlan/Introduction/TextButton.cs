﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextButton : MonoBehaviour
{
    public Text Textfield;

    public void SetText(string text)
    {
        Textfield.text = text;
    }
}
