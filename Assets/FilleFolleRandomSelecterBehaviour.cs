using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilleFolleRandomSelecterBehaviour : MonoBehaviour
{
    public Text texteFinalAAfficher;
    public int nombreMin, nombreMax;

    public List<string> listeDesMots = new List<string>();

    void Start()
    {
        print(listeDesMots.Count);
    }

    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            texteFinalAAfficher.text = SelectionnerUneSuiteDeMotsRandom(Random.Range(nombreMin, nombreMax), listeDesMots);
        }
    }

    string SelectionnerUneSuiteDeMotsRandom(int nombreDeMots, List<string> laListeDeMots)
    {
        string phrasefinale = "";

        for (int i = 0; i < nombreDeMots; i++)
        {
            phrasefinale += laListeDeMots[Random.Range(0, laListeDeMots.Count)];
        }

        return phrasefinale;
    }
}
