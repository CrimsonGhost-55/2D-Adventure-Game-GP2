using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static CharacterMovement Instance;
    public GameObject Player;
    public float speed = 0.1f;

    public List<string> myInventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(Player);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You've enter a house");
    }

    public void addItem(string item)
    {
        myInventory.Add(item);
    }
}
