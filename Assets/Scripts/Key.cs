using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IPickup
{
    public AudioSource keyPickup; //Ljudkälla för pickup-ljud
    public GameObject exitRoomCollider; //Collidern som triggrar exit
    // Start is called before the first frame update
   
   public void Pickup() //Funktionen pickup
    {
        Destroy(gameObject); //Förstör objektet

    }

    private void OnTriggerEnter(Collider other) //När man triggrar collidern
    {
        Pickup(); //Kör pickup
        exitRoomCollider.SetActive(true); //Aktiverar exit-collidern
        keyPickup.Play(); //spelar upp pickup ljudet.
    }
}
