using System.Collections; //collection of classes
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] FiringBehaivour firingBehaivour;
    //To make reference declarevariable of the name of the script+ name of the reference same name but with lower case
    public PlayerController playerController;

    void Start()
    {
        // if you are gonna do catching dont use SerializeField
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.F)) //GetKeyDown when he pushes 
       {
            playerController.animatormegaman.SetBool("shooting", true);
            firingBehaivour.FireProjectile();
            
            
       }
      


       if(Input.GetKeyUp(KeyCode.F))
       {
            playerController.animatormegaman.SetBool("shooting",false);
       }



        
    } 
}
