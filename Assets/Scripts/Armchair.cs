using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armchair : MonoBehaviour
{
    private bool activated = false;
    private float timer; //timer float
    public AudioSource pushSound; //Ljud när man puttar stolen
    public Animator armchairmove; //Animation för att flytta stolen
   

    // Update is called once per frame
    void Update()
    {
        if (activated== true)
        {
            timer += Time.deltaTime; //Öka tiden på timer float
        }
        
        if (timer >= 1f) //Om tiden är lika med eller mer än 1 sekund
        {
           
            Destroy(gameObject); //Förstör objektet 
        }
    }
    private void OnTriggerEnter(Collider other) //När man triggrar collider
    {
        activated = true;
        
        pushSound.Play(); //sepla upp Push-ljudet
        armchairmove.SetBool("Move", true); //Sätter move till sant
    }

   



   
    

}
