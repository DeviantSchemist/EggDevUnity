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
    }

    // Update is called once per frame
    void Update()
    {

        if (currentLine == textLines.Length)
        {
            currentLine = endLine;
        }

        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return) && currentLine < textLines.Length)
        {
            currentLine++;
        }

        if (Input.GetKeyDown(KeyCode.Backspace) && currentLine > 0)
        {
            currentLine--;
        }
    }
}
