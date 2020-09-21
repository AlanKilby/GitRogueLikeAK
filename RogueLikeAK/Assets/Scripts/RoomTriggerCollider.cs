﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTriggerCollider : MonoBehaviour
{
    public bool playerIsInTheRoom = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInTheRoom = true;
        }       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInTheRoom = false;
        }
    }
}
