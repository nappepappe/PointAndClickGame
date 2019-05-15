using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugScript : MonoBehaviour, IPickup
{
    public GameObject key; //Nyckel-objektet
    public AudioSource CutSound; //Ljud för att klippa sönder mattan
    public GameObject rug; //Matta-objektet

public void Pickup() //Pickup funktion
    {
        Destroy(rug); //Förstör gameobjektet "rug"
    }
    private void OnTriggerEnter(Collider other) //Om man triggrar collidern
    { 
        Pickup(); //Kör pickup funktion
        CutSound.Play(); //Spelat upp klipp-ljudet
        key.SetActive(true); //aktiverar nykeln
    }
}
