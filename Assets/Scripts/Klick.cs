using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klick : MonoBehaviour
{
    public bool move; //bool för move
    public Vector3 MousePosition; //vector 3 för musens position

    
    private void OnMouseDown() //När man trycker ner musknappen
    {
        RaycastHit hit; //RaycastHit med namnet hit
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) //Om rayn träffar puspositionen 
        {
            MousePosition = hit.point; //Muspositionen är träffpositionen 
            move = true; //rörelse är sant
        }
    }

}
