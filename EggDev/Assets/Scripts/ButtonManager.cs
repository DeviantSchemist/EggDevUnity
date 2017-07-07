using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

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

        // trying to add listener for every button
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].onClick.AddListener(() => ButtonLoad(i));
        }
    }
	
	// Update is called once per frame
	void Update () {
        //SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);

    }

    void ButtonLoad(int index)
    {
        Debug.Log("Button pressed!");
        SceneManager.LoadScene("DialogueScene_Chapter0Choice" + (index + 1));
    }
}
