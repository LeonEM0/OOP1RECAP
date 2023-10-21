using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // to use text mesh pro you need this library 
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private int maxHealth = 100;
    public  UnityEvent<int> onTakeDamage;
    private int currentHealth;


    void Start()
    {

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log(currentHealth);

        if(currentHealth <= 0)
        {
            Debug.Log("im dead AHHHHH");
            Destroy(this.gameObject);
        }

    }
    public void GainHealth(int amount)
    {
        currentHealth += amount;


    }

}
