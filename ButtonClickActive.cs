using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickActive : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton ()
    {
        textBox.SetActive(true);
    }
}
