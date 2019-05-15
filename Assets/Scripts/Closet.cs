using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{
    private bool activated= false; //En bool för när man aktiverar trigger, som är false
    public GameObject doorTrigger; //Dörrtriggern som laddar nästa scen
    private float timer; //timer float
    public AudioSource pushSound; //Ljud när man puttar stolen
    public Animator closetmove; //Animation för att flytta stolen


    // Update is called once per frame
    void Update()
    {
        if (activated == true) //Om activated är true
        {
            timer += Time.deltaTime; //Öka tiden på timer float
        }
        if (timer >= 1f) //Om tiden är lika med eller mer än 1 sekund
        {
            doorTrigger.SetActive(true); //sätter dörrtriggern till active
            Destroy(gameObject); //Förstör objektet 
        }
       


    }
    private void OnTriggerEnter(Collider other) //När man triggrar collider
    {
        activated = true; //activated-boolen blir true
        pushSound.Play(); //sepla upp Push-ljudet
        closetmove.SetBool("Moved", true); //Sätter move till sant
        
    }
}