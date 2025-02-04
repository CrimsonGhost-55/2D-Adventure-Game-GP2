using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemNameDictionary : MonoBehaviour
{
    public string itemName;
    public int itemNumber = 1;
    public PlayerNameDictionary myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerNameDictionary>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddItem();
        Destroy(gameObject);
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

}
