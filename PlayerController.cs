using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 100;
    private int maxHealth = 100;
    public int damage = 0;
   

    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float jumpforce = 100.5f;
    [SerializeField] private bool isJumping;
    [SerializeField] private float movehorizontal;
    [SerializeField] private float movevertical;
    [SerializeField] public Animator animatormegaman;
      

    private Rigidbody2D rigidbody2D;
    [SerializeField] private SpriteRenderer megamansprite;


    public int Health
    {
        get { return health; }
        set {
            if (value > maxHealth)
            {
                Debug.Log("The health can't be >100");
            }
            else if (value < 0)
            {
                Debug.Log("The health can't be <0");
            }
            else
            {
                health = value;
            }

        }
    }
    public int TakeDamage(int damage)  //This function is void
    {
        Health = Health - damage;

        if (Health < 0)
        {
            Debug.Log("Health cant fall under 0");

        }


        return Health;
    }
    public int Heal(int HealAmount) // This Function is void
    {
        Health = Health - HealAmount;

        if (Health > maxHealth)
        {
            Debug.Log("You cant exced the maxHealth");

        }

        return Health;
    }


    void Start() //this method is to assign or initialize
    {
        rigidbody2D = GetComponent<Rigidbody2D>();// Catching
        
        //spriterenderzero = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {




        movehorizontal = Input.GetAxisRaw("Horizontal");
        movevertical = Input.GetAxisRaw("Vertical");




    }
    public void FixedUpdate()
    {
        if (!isJumping && Input.GetKey(KeyCode.D))//right 
        {
            rigidbody2D.velocity = new Vector2(horizontalSpeed*movehorizontal,0);
            
            //rigidbody2D.AddForce (new Vector2(movehorizontal*horizontalSpeed, 0),ForceMode2D.Impulse);
            animatormegaman.SetInteger("state",1);

            
        }
        if (!isJumping && Input.GetKey(KeyCode.A))//left
        {
            rigidbody2D.velocity = new Vector2(horizontalSpeed * movehorizontal, 0);
            //rigidbody2D.AddForce (new Vector2(movehorizontal*horizontalSpeed, 0), ForceMode2D.Impulse);
            animatormegaman.SetInteger("state", 1);


        }
        if(Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D)||(movehorizontal==0))
        {
            animatormegaman.SetInteger("state", 0);
        }
       


        if ((!isJumping && Input.GetKeyDown(KeyCode.W)))
        {
            Debug.Log("W");
            rigidbody2D.AddForce(new Vector2(0f,jumpforce),ForceMode2D.Impulse);
            
            //Debug.Log(isJumping);
        }

        //flipcharacter 
        FlipCharacter();

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }

    }
    public void FlipCharacter()
    {
        if (rigidbody2D.velocity.x < 0)
        {
            megamansprite.flipX = true;
            
        }
        else if (rigidbody2D.velocity.x > 0)
        {
            megamansprite.flipX = false;

        }
    }



    //GetAxis return a FLOAT value (-1 - 1)
    //BoxCast
    //Titlemap Collider 


}
