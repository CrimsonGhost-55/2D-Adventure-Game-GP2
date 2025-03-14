using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ItemNameDictionary : MonoBehaviour
{
    public string itemName;
    public int objectIndex;
    public int itemNumber = 1;
    public bool isActive = false;
    //public int itemIndex;
    public PlayerNameDictionary myPlayer;
    public DialogManager dialogManager;
    public GameObject Canvas;
    public TextMeshProUGUI pickUp;
    // Start is called before the first frame update

   
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerNameDictionary>();
        dialogManager = FindObjectOfType<DialogManager>();
        GameObject Canvas = GameObject.Find("PickUpText");
        TextMeshProUGUI PickUpText = pickUp.GetComponent<TextMeshProUGUI>();
        PickUpText.SetText("Press Space to Interact");
        pickUp.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //if(collision.CompareTag("Player"))
        //{
        //    isActive = true;
        //}
        pickUp.enabled = true;
        
        Debug.Log("I am on something");
        if(/*isActive == true ||*/ Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Collecting item");
            Interact();
            AddItem();
            pickUp.enabled = false;
            Destroy(gameObject);
        }
       
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickUp.enabled = false;

    }




    public void AddItem()
    {
        if(myPlayer.myInventoryDict.ContainsKey(itemName))
        {
            myPlayer.myInventoryDict[itemName] += itemNumber;
            
        }
        else
        {
            myPlayer.myInventoryDict.Add(itemName, itemNumber);
            
        }
        myPlayer.DisplayInventory();
        
        
    }

    public void Interact()
    {
        dialogManager.currentIndex = objectIndex;
    }

}
