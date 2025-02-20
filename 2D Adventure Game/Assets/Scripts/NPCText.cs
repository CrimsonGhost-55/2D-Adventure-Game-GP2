using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEditor;
using UnityEngine;


public class NPCText : MonoBehaviour
{
    public GameObject dialoguePrompt;
    public PlayerNameDictionary myPlayer;
    private bool playerIsNear = false;
    // Start is called before the first frame update
    void Start()
    {
        dialoguePrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerIsNear || !Input.GetKey(KeyCode.Space))
        {
            return;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsNear = true;
            dialoguePrompt.SetActive(true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsNear = false;
            dialoguePrompt.SetActive(false);
        }
        
    }
}
