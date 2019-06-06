﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Controller : MonoBehaviour
{
    private IPlayerCommand utility;
    private IPlayerCommand idle;
    private bool playerInPlayzone;
    private GameObject interactingGame;


    void Start()
    {
        // true for now
        this.playerInPlayzone = false;

        this.utility = ScriptableObject.CreateInstance<PlayerInteraction>();
        this.idle = ScriptableObject.CreateInstance<PlayerIdle>();
    }

    void Update()
    {
        this.playzoneDetection();
        if (this.playerInPlayzone && Input.GetButtonDown("Utility2"))
        {
            this.utility.Execute(this.interactingGame);
        }

        if (Input.GetAxis("Horizontal2") == 0 && Input.GetAxis("Vertical2") == 0)
        {
            this.gameObject.GetComponent<Animator>().speed = 1;
            this.idle.Execute(this.gameObject);
        }
        else
        {
            var directionX = Input.GetAxis("Horizontal2");
            var directionY = -Input.GetAxis("Vertical2");

            var degree = UnityEngine.Mathf.Rad2Deg * UnityEngine.Mathf.Atan2(directionY, directionX);
            var speed = Mathf.Sqrt(directionX * directionX + directionY * directionY);
            this.gameObject.transform.rotation = Quaternion.Euler(degree, 90, 270);
            this.gameObject.GetComponent<Animator>().speed = speed;
            this.gameObject.GetComponent<Animator>().Play("HumanoidRun");
        }
    }

    private void playzoneDetection()
    {

        if (!this.playerInPlayzone)
        {
            // if (in some playzone)
            // {
            this.playerInPlayzone = true;
            // playzone's corresponding gameobject
            this.interactingGame = GameObject.Find("Virus Game");
            // }
        }

        // else
        // {
        //     this.playerInPlayzone = false;
        //     this.interactingGame = null;
        // }
    }
}