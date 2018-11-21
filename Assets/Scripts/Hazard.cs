﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            //SceneManager.LoadScene(0);
            player.Respawn();
        }
        else
        {
            Debug.Log("triggered");
        }
    }
	
}
