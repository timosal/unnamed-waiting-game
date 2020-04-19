using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public Items[] items;
    private static List<Items> unsortedItems;

    private Items currentItem;

    [SerializeField]
    private Text itemText;
    private int answer;

    public GameObject Biojate;
    public GameObject Lasinkerays;
    public GameObject Ongelmajate;
    public int Choice;

    public int choiceMade01()
    {
        Choice = 1;
        return Choice;
    }
    public int choiceMade02()
    {
        Choice = 2;
        return Choice;
    }
    public int choiceMade03()
    {
        Choice = 3;
        return Choice;
    }

    // Start is called before the first frame update
    void Start()
    {
        //If the there are no unsorted items, the program will create a list of them.
        if (unsortedItems == null || unsortedItems.Count == 0)
        {
            unsortedItems = items.ToList<Items>();
        }

        SetCurrentItem();
        
    }

    //Sets the item to be shown
    void SetCurrentItem()
    {
        //Selects a random item from the list between 0 and amount of items left
        int randomItemIndex = Random.Range(0, unsortedItems.Count);
        currentItem = unsortedItems[randomItemIndex];

        //Sets the text in the box as the text of the shown item
        itemText.text = currentItem.items;
        //Removes the item shown from the list -> won't be shown again
        unsortedItems.RemoveAt(randomItemIndex);

        Items item = new Items(); 
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CheckAnswer(Choice, answer);
                if (true) {
                    Debug.Log("Oikein");
                }
                else {Debug.Log("Väärin");}

        }
    }
        public bool CheckAnswer(int Choice, int answer)
    {
        if (answer == Choice)
        {
            return true;
        }
        else return false;
    }



    //Need to have a collision detect for items so that that item will be disabled
}
