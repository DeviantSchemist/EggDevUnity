using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endLine;

    public bool isActive;

    private bool isTyping = false;
    private bool cancelTyping = false;
    public float typeSpeed;

    // Use this for initialization
    void Start()
    {
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endLine == 0)
        {
            endLine = textLines.Length - 1;
        }

        if (isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (!isActive)
        {
            return;
        }

        if (currentLine == textLines.Length)
        {
            currentLine = endLine;
        }

        /*
        else
        {
            StartCoroutine(TextScroll(textLines[currentLine]));
        }
        */

        //theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return) && currentLine < textLines.Length)
        {
            if (!isTyping)
            {
                currentLine++;

                if (currentLine > endLine)
                {
                    DisableTextBox();
                }
                else
                {
                    StartCoroutine(TextScroll(textLines[currentLine]));
                }
            }
            else if (isTyping && !cancelTyping)
            {
                cancelTyping = true;
            }

        }

        /*
        if (Input.GetKeyDown(KeyCode.Backspace) && currentLine > 0)
        {
            if (!isTyping)
            {
                currentLine--;
            }
            else if (isTyping && !cancelTyping)
            {
                cancelTyping = true;
            }
        }
        */
    }

    // controls a line of text scrolling on the text box
    private IEnumerator TextScroll (string lineOfText)
    {
        int letter = 0;
        theText.text = "";
        isTyping = true;
        cancelTyping = false;

        while (isTyping && !cancelTyping && letter < lineOfText.Length - 1)
        {
            theText.text += lineOfText[letter];
            letter++;
            yield return new WaitForSeconds(typeSpeed);
        }

        theText.text = lineOfText;
        isTyping = false;
        cancelTyping = false;
    }

    // will use when necessary
    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
        StartCoroutine(TextScroll(textLines[currentLine]));
    }

    // will use when necessary
    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
    }
}
