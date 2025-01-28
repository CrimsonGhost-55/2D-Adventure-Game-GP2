using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(Player);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You've enter a house");
    }
}
