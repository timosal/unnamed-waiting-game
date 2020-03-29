using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    float nytAika = 0f; //Paljonko aikaa jäljellä
    float aloitusAika = 30f;  //Paljonko aikaa alussa

    [SerializeField] Text TextTimer;
    void Start()
    {
        nytAika = aloitusAika;  //asetetaan jäljellä olevaksi ajaksi haluttu määrä
    }

    void Update()
    {
        nytAika -= 1 * Time.deltaTime;  //Joka sekunti vähennetään  sen hetkisestä ajasta yksi
        TextTimer.text = nytAika.ToString("0"); //Asetetaan teksti objektiin aika mikä muutetaan string muotoon

        if(nytAika <= 0)  //Kun aika menisi 0 alapuolella niin asetetaan aika 0:ksi, kun aika 0 niin peli siirtyy loppuruutuun.
        {
            nytAika = 0; 
            SceneManager.LoadScene("EndScene");  
        }
    }
}
