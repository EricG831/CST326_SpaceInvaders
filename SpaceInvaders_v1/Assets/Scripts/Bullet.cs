using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;
  public float speed = 5;
  public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      Debug.Log("Wwweeeeee");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy red enemies
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        // DEstroy Blue enemies
        if (collision.gameObject.tag == "Enemy2")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        // Destroy green enemies
        if (collision.gameObject.tag == "Shooter")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);            
        }

        // Destroy barricades
        if (collision.gameObject.tag == "FullHealthB" || collision.gameObject.tag == "MidHealthB" || collision.gameObject.tag == "LowHealthB")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
