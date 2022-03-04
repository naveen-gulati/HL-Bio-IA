using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accurate : MonoBehaviour
{
    public GameObject ant;
    public GameObject cat;
    public Text AccuracyText;
    private PointSystem value;
    private Player clicks;
    // Start is called before the first frame update
    void Start()
    {
        value = ant.GetComponent<PointSystem>();
        clicks = cat.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        int total = clicks.ClickCount; 
        int total2 = (total+30)-15;
            string ac = (((float) value.Points/total2)*100).ToString("f0");
            AccuracyText.text = ac+"%";

    }
}
