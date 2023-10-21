using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilescript : MonoBehaviour
{

    [SerializeField] private float speed =10;
    [SerializeField] public int damage =5;
    

    public Rigidbody2D rb; // Serialized field will always takes what is in the inspector
    // Start is called before the first frame update
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDirection(float direction)
    {


        rb.velocity = new Vector2(speed * direction, 0);


    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("enemy")) // projectile to enemy si la colision choca con el ENEMIGO destruyelo
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
        
    }
}
