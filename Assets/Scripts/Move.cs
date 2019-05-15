using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    public Rigidbody rBody; //rigidbody 
    public Klick klick; //Skriptet "Klick"

    // Update is called once per frame
    void Update()
    {
        if (klick.move == true) //Om move-boolen är sann
        {
            GetComponent<NavMeshAgent>().SetDestination(klick.MousePosition); //sätter destination på navmesh

            if (transform.position == klick.MousePosition) //om spelaren är på punkten man klickade på
            {
                klick.move = false; // sluta röra sig
            }
        }
        transform.rotation = new Quaternion(0, 0, 0, 9); // rotationen 
    }
}

