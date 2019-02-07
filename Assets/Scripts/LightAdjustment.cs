using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAdjustment : MonoBehaviour {
    public Light lighta;
    
    //Range Variables
    public bool adjustRange = false;
    public float rangeSpeed = 1.0f;
    public float maxRange = 10.0f;

    //Intensity Variables
    public bool adjustIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;

    //Color Variables
    public bool adjustColor = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;

    float startTime;

    // Use this for initialization
    void Start () {
        lighta = GetComponent<Light>();
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (adjustRange)
        {
            lighta.range = Mathf.PingPong(Time.time * rangeSpeed, maxRange); 
        }
        if (adjustIntensity)
        {
            lighta.intensity = Mathf.PingPong(Time.time * intensitySpeed, maxIntensity);
        }
        if (adjustColor)
        {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            lighta.color = Color.Lerp(startColor, endColor , t);
        }
	}
}
