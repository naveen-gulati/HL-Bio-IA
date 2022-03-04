using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointIncrease : MonoBehaviour
{
    public GameObject ant;
    private PointSystem value;
    // Start is called before the first frame update
    void Start()
    {
        value = ant.GetComponent<PointSystem>();
    }
    // Update is called once per frame
    public void OneIncrease()
    {
        value.Points += 1; 
    }
    public void TwoIncrease()
    {
        value.Points += 2; 
    }
}
