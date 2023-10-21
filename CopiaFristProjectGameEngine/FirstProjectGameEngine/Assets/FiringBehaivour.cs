using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringBehaivour : MonoBehaviour
{
    [SerializeField] private GameObject projectilescript;
    [SerializeField] private Transform projectileSpwanPoint;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FireProjectile()
    {
        //Instantiate(projectile,projectileSpwanPoint.position + Vector3.right, Quaternion.identity);
        Debug.Log("FiredProjectile");

        GameObject go = Instantiate(projectilescript, projectileSpwanPoint.position, Quaternion.identity);
        go.GetComponent<Projectilescript>().SetDirection(this.transform.localScale.x) ;
        //go.SetDirection(this.transform.localScale.x);

        Destroy(go,1.5f);

    }

}
//trigers