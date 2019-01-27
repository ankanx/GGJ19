using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fadecolors : MonoBehaviour
{
    public float FadeDuration = 1f;
    public Color Color1 = Color.cyan;
    public Color Color2 = Color.magenta;

    private Color StartingColor;
    private Color endColor;
    private float lastColorChangeTime;

    private Color imagecolor;

    void Start()
    {
        StartingColor = Color1;
        endColor = Color2;
    }

    void Update()
    {
        var ratio = (Time.time - lastColorChangeTime) / FadeDuration;
        ratio = Mathf.Clamp01(ratio);
        GetComponent<Image>().color = Color.Lerp(StartingColor, endColor, Mathf.Sqrt(ratio));

        if (ratio == 1f)
        {
            lastColorChangeTime = Time.time;

            var temp = StartingColor;
            StartingColor = endColor;
            endColor = temp;
        }
    }
}