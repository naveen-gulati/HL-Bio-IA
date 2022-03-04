using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickInactive : MonoBehaviour
{
    public GameObject textBox;
    
    public void ClickTheButton()
    {
        textBox.SetActive(false);
    }
}
