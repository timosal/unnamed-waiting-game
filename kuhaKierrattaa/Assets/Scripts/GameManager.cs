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
    }

    //Need to have a collision detect for items so that that item will be disabled
}
