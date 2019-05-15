using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour
{
    public string scene; //string för vilken scne som ska laddas
    
    
  
    private void OnTriggerEnter(Collider other) //När man triggrar collider 
    {
        SceneManager.LoadScene(scene); // Laddar scenen 
    }

}
