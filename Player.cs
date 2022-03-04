using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int ClickCount; 
    public GameObject assignment1, assignment2, assignment3;
    // Start is called before the first frame update
    void Start()
    {
        ClickCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickCount += 1;
        }
        //Debug.Log("ClickCount" + ClickCount);

        /*if (ClickCount == 15)
        {
            assignment1.SetActive(true);
            assignment2.SetActive(true);
            assignment3.SetActive(true);
        }*/
    }
}
