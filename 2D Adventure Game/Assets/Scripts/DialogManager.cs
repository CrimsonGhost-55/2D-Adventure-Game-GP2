using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueDisplay;
    public PlayerNameDictionary myPlayer;
    public int currentIndex = 0;
    public string[] dialogue = new string[8];
    public bool playerIsNear = false;
    // Start is called before the first frame update
    void Start()
    {
        dialogueDisplay.text = dialogue[currentIndex];
            }

    // Update is called once per frame
    void Update()
    {
        
        if(playerIsNear && Input.GetKeyDown(KeyCode.Space))
        {
            if (currentIndex < 6)
            {
                dialogueDisplay.text = dialogue[currentIndex];
                currentIndex++;
            }
            else if(myPlayer.myInventoryDict.ContainsKey("Apple"))
            {
                 SceneManager.LoadScene("EndScene");
                
            }
            else
            {
                dialogueDisplay.text = "";
                currentIndex = 0;
            }
            
                
            

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsNear = false;
            dialogueDisplay.text = "";
            currentIndex = 0;
        }
    }
}
