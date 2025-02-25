using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;


public class PlayerNameDictionary : MonoBehaviour
{
      public static PlayerNameDictionary Instance;
    public GameObject Player;
    //public GameObject Apple1;
    //public GameObject Apple2;
    //public GameObject Apple3;
    public GameObject pickUp;
    public float speed = 0.1f;
    public bool applesHaveFell = false;
    public bool isInHouse = false;
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
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
	    Player.transform.position += Vector3.up * speed;
            
        }
	if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
	    Player.transform.position += Vector3.down * speed;
            
        }
	if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
	    Player.transform.position += Vector3.left * speed;
                
        }
	if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
	    Player.transform.position += Vector3.right * speed;
            
        }
    if(isInHouse == true && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("GameScene1");
            isInHouse = false;
        }

        //Apple1 = GameObject.Find("Apple1");
        //Apple2 = GameObject.Find("Apple2");
        //Apple3 = GameObject.Find("Apple3");
    }
    public void DisplayInventory()
    {
        inventoryDisplay.text = "";
        foreach (var item in myInventoryDict)
        {
            inventoryDisplay.text += "Item: " + item.Key + ", Quantity: " + item.Value + "\n";  
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //if(collision.gameObject.tag == "Tree")
        //{
        //    Debug.Log("On Tree");
        //    pickUp.SetActive(true);
        //    if(Input.GetKey(KeyCode.Space))
        //    {
        //        applesHaveFell = true;
        //        Debug.Log("Button is being pressed");
        //        Apple1.transform.position = new Vector2(24.88f, 7.92f);
        //        Apple2.transform.position = new Vector2(23.09f, 6.01f);
        //        Apple3.transform.position = new Vector2(21.79f, 7.18f);
        //        if (applesHaveFell == true)
        //        {
        //            Apple1.GetComponent<Collider2D>().enabled = true;
        //            Apple2.GetComponent<Collider2D>().enabled = true;
        //            Apple3.GetComponent<Collider2D>().enabled = true;
        //        }
        //        else if (applesHaveFell == false)
        //        {
        //            Apple1.GetComponent<Collider2D>().enabled = false;
        //            Apple2.GetComponent<Collider2D>().enabled = false;
        //            Apple3.GetComponent<Collider2D>().enabled = false;
        //        }
        //    }
            

        //}
        

        
    }

    
}
