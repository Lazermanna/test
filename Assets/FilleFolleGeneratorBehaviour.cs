using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilleFolleGeneratorBehaviour: MonoBehaviour
{
    public InputField premier, deuxieme;
    string texteInitial, texteFinalAAfficher;

    public List<string> listeDesLettres = new List<string>();
    public List<string> listeDesCodes = new List<string>();

    void Start()
    {
        print(listeDesLettres.Count);
    }

    void Update()
    {
        texteInitial = premier.text;

        deuxieme.text = FaireUnTexteDeFilleFolleVersTexteNormal(texteInitial);
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

    string FaireUnTexteDeFilleFolleVersTexteNormal(string texteEntre)
    {
        List<string> listeDesCaracteresEntres = new List<string>();

        string phraseFinale = "";

        foreach (var item in listeDesCodes)
        {
            if (texteEntre.Contains(item))
            {
                listeDesCaracteresEntres.Add(listeDesLettres[listeDesCodes.IndexOf(item)]);
            }
            if (texteEntre.Contains(" "))
            {
                listeDesCaracteresEntres.Add(" ");
            }
        }

        for (int i = 0; i < listeDesCaracteresEntres.Count; i++)
        {
            phraseFinale += listeDesCaracteresEntres[i];
        }

        print("phrase finale :" + phraseFinale);
        return phraseFinale;
    }
}
