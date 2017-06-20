using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button[] buttons = (Button[]) FindObjectsOfType(typeof(Button));

        // sorts buttons by their tags
        Array.Sort(buttons, delegate (Button button1, Button button2)
        {
            return button1.tag.CompareTo(button2.tag);
        });


        //DEBUGGING STATEMENTS BELOW
        /*
        foreach (Button myButton in buttons)
        {
            Debug.Log(myButton.GetComponentInChildren<Text>().text + "\n");
        }
        */

        /*
        foreach (Button myButton in buttons)
        {
            Debug.Log(myButton);
        }
        */
        //END OF DEBUGGING STATEMENTS


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
