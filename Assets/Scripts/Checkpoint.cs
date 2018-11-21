﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Checkpoint");
            PlayerCharacter player = collision.GetComponent <PlayerCharacter>();
            player.SetCurrentCheckpoint(this);
        }
    }
}
