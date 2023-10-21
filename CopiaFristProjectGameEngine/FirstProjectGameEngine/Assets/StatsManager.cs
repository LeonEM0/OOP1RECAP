using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StatsManager : MonoBehaviour
{
    public int collectablecount;
    public TextMeshProUGUI collectable_text;
    public TextMeshProUGUI health_text;
    PlayerController player;
    // Start is called before the first frame update
    private void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        collectable_text.text = "#" + collectablecount.ToString();
        health_text.text = " % : "+player.Health.ToString();
        
    }
    public void UpdateCollectableCount(int collectable)
    {
        collectablecount += collectable;

        collectable_text.text = "#" + collectablecount.ToString();

    }
    public void Update()
    {
        health_text.text = " % : " + player.Health.ToString();

    }
    //The functions executed out of the START,UPDATE, AND FIXED UPDATE ARE EXECUTED EVERY FRAME?



}
