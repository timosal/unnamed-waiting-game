﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            ChoiceMade.CheckAnswer(ChoiceMade.Choice, Items.answer);

        }
    }
}
