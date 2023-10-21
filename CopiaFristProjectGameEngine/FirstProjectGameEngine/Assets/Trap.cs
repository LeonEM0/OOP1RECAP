using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    [SerializeField] private PlayerController player;
     public int trap_damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
           
            //col.GetComponent<PlayerController>()
            TakeDamage();
            Destroy(this.gameObject);
            Debug.Log("TRAP DESTROYED PLAYER HAS RECEIVE DAMAGE");

        }

    }

    public void TakeDamage()
    {
        player.Health = player.Health - trap_damage;
    }
 
}
