using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceMade : MonoBehaviour
{
    public GameObject Biojate;
    public GameObject Lasinkerays;
    public GameObject Ongelmajate;
    public static int Choice;

    public void choiceMade01()
    {
        Choice = 1;

    }
    public void choiceMade02()
    {
        Choice = 2;
    }
    public void choiceMade03()
    {
        Choice = 3;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool CheckAnswer(int Choice, int answer)
    {
        if (answer == Choice)
        {
            return true;
        }
        else return false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
