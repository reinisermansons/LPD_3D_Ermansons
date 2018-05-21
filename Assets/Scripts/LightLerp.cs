
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{

    public float smooth = 2;
    private Color newColour;

    void Awake()
    {
       // lt = GetComponent<Light>();
        object lt = null;
      //  newColour = lt.color;
    }

    // Update is called once per frame
    void Update()
    {
        ColourChanging();
    }

    void ColourChanging()
    {
        Color colourA = Color.red;
        Color colourB = Color.green;

        if (Input.GetKeyDown(KeyCode.Z))
            newColour = colourA;
        if (Input.GetKeyDown(KeyCode.C))
            newColour = colourB;

      //  light.color = Color.Lerp(light.color, newColour, Time.deltaTime * smooth);
    }
}
