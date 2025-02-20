using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemNameDictionary : MonoBehaviour
{
    public string itemName;
    public int objectIndex;
    public int itemNumber = 1;
    //public int itemIndex;
    public PlayerNameDictionary myPlayer;
    public DialogManager dialogManager;
    public GameObject pickUp;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerNameDictionary>();
        dialogManager = FindObjectOfType<DialogManager>();
        
        pickUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pickUp = GameObject.Find("PickUpText");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        pickUp.SetActive(true);
        if (Input.GetKey(KeyCode.Space))
        {
            Interact();
            AddItem();
            pickUp.SetActive(false);
            Destroy(gameObject);
        }
        if (myPlayer.applesHaveFell == true && Input.GetKey(KeyCode.Space))
        {
            Interact();
            AddItem();
            pickUp.SetActive(false);
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickUp.SetActive(false);
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
