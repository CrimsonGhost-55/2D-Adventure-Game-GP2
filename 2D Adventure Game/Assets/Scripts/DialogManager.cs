using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueDisplay;
    public int currentIndex = 0;
    public string[] dialogue = new string[5];
    // Start is called before the first frame update
    void Start()
    {
        dialogueDisplay.text = dialogue[0];
    }

    // Update is called once per frame
    void Update()
    {
        dialogueDisplay.text = dialogue[currentIndex];
        if(Input.GetKey(KeyCode.Space))
        {
            currentIndex = 0;
        }

       /* switch (currentIndex)
        {
            case 1:
        }*/

    }
}
