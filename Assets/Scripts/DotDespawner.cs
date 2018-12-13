using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotDespawner : MonoBehaviour
{
    public int zostavajuceZivotyPocet;
    public Text zivotyText;
    public Text cas;
    public Text koniecHry;
    public Button hratZnova;
    public bool koniec = false;

    void Start()
    {
        koniecHry.enabled = false;
        hratZnova.interactable = false;
        hratZnova.gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dot")
        {
            Destroy(collision.gameObject);
            zostavajuceZivotyPocet--;
        }
        //Debug.Log(pocetNechytenych);

    }

    void Update()
    {
        if(!koniec)
        { 
            zivotyText.text = "Zostávajúce životy: " + zostavajuceZivotyPocet;
            cas.text = "Čas hrania: " + Time.timeSinceLevelLoad;

            if(zostavajuceZivotyPocet == 0 && koniec == false )
            {
                koniecHry.enabled = true;
                koniecHry.text = "Koniec hry! \n Celková dĺžka hrania:\n" + Time.timeSinceLevelLoad;
                koniec = true;
                hratZnova.interactable = true;
                hratZnova.gameObject.SetActive(true);
            }
        }
    }
}
