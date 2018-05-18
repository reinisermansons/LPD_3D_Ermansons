using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
     public Rect labelPosition;
    string labelText;
    public GUIStyle labelStyle;
    public int points = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 500, 20), "Savāktās monētas : " + points);
    }
}
