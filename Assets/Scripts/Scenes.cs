using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    private bool startClicked = false;  //bool för om man klickat eller inte
    private float timer; //Timer-float
    public Animator zoom; //Animator med namnet zoom
    



    private void Update()
    {
        if(startClicked== true) //Om knappen är klickad
        {
            timer += Time.deltaTime; //Öka timer-floaten
        }
        if(timer >= 3f) //om timer är tre sekunder eller mer
        {
            SceneManager.LoadScene("Game1"); //laddar scenen Game1
        }
    }

    public void Play() //play-knapp
    {
        startClicked = true; //Boolen startClicked är sann
        zoom.SetBool("Zoomed", true); //Sätter boolen i animatorn till true så att animationen ska starta
    }
    public void Quit() //quit-knapp
    {
        Application.Quit(); //stänger av spelet
    }
}
