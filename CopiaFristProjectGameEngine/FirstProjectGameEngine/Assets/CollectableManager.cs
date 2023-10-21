using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    private int collectablevalue = 1;
    

    private PlayerController player; // SI PONES EL GAMEOBJECT COMO SERIALIZEFIELD Y ARRASTRAS EL PLAYER AL MOMENTO DE HACER EL PREFAB NO SE GUARDARA LA REFENCIA DEL PLAYER
    //private PlayerController player;

    StatsManager statsManager;

    //[SerializeField] private int damage2 = 20;
    
    // Start is called before the first frame update
    void Start()
    {

        // player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>(); Instead of calling the player call the stats manager
        statsManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<StatsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D colision2)
    {
        if (colision2.CompareTag("Player"))
        {
            //logic with the player       
            //  colision2.GetComponent<Health>().TakeDamage(damage2);    
            // Debug.Log("Object destroyed");
            //AddCollectableCounter(colision2.GetComponent<PlayerController>()); THIS IS THE PLAYER
            //Destroy(this.gameObject); FIRST DO THE ACTION THEN DESTROY THE OBJECT
            // TakeDamage();
            statsManager.UpdateCollectableCount(collectablevalue);
           

            Destroy(gameObject);


        }
    }

    /*
    public void TakeDamage()
    {
        player.Health = player.Health - damage2;
       
    }
    */
   /*
    public void AddCollectableCounter(PlayerController player)
    {
        player.collectables = player.collectables + 1;
        //player.GetComponent<Collector>().Collect(1);
        Debug.Log("+1");
    }
   */

}

//Check if the if the player collide with the trigger and kill either the player or the Trap
