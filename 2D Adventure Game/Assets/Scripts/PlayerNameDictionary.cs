using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerNameDictionary : MonoBehaviour
{
      public static PlayerNameDictionary Instance;
    public GameObject Player;
    public float speed = 0.1f;

    public TextMeshProUGUI inventoryDisplay;
    public Dictionary<string, int> myInventoryDict = new Dictionary<string, int>();

     private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        myInventoryDict.Add("Sword", 1);
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
	    Player.transform.position += Vector3.up * speed;
            
        }
	if(Input.GetKey(KeyCode.S))
        {
	    Player.transform.position += Vector3.down * speed;
            
        }
	if(Input.GetKey(KeyCode.A))
        {
	    Player.transform.position += Vector3.left * speed;
                
        }
	if(Input.GetKey(KeyCode.D))
        {
	    Player.transform.position += Vector3.right * speed;
            
        }
    }
    public void DisplayInventory()
    {
        inventoryDisplay.text = "";
        foreach (var item in myInventoryDict)
        {
            inventoryDisplay.text += "Item: " + item.Key + ", Quantity: " + item.Value + "\n";  
        }
    }
}
