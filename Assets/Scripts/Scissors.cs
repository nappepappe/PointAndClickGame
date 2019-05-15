using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : MonoBehaviour, IPickup
{
    public AudioSource scissorpickup; //Ljudkälla för pickup-ljud
    public GameObject rugCollider; //Collidern som triggrar exit
                                        // Start is called before the first frame update

    public void Pickup() //Funktionen pickup
    {
        Destroy(gameObject); //Förstör objektet

    }

    private void OnTriggerEnter(Collider other) //När man triggrar collidern
    {
        Pickup(); //Kör pickup
        rugCollider.SetActive(true); //Aktiverar exit-collidern
        scissorpickup.Play(); //spelar upp pickup ljudet.
    }
}
