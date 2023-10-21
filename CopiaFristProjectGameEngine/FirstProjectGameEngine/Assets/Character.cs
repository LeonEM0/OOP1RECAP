using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character //OOP EXERCISE 
{/// <summary>
///  YOURE NOT USING THIS ONE IS JUST AN EXERCISE
/// </summary>
    // Start is called before the first frame update
    private int health = 100;
    private int maxHealth = 100;
    public int damage = 0;
    public int Health //getters and setters
    {
        get { return health; }
        set
        {
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
            Health = 0;
            Debug.Log("Health cant fall under 0");
            Die();

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
    protected abstract void Die();

}
public class Player : Character
{
    protected override void Die()
    {
        Debug.Log("The player has died");
    }
}


public class Character1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
