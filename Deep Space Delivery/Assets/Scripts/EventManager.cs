﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random;

public class EventManager : MonoBehaviour
{
    private float time;
    EventPublisherManager EventPublisherManager;
    Random random = new Random();
    // Use this for initialization

    [SerializeField] private GameObject UIScripts;
    private LaserZone LaserZone;

    private Tuple<bool, float> AsteroidEvent;
    private Tuple<bool, float> CaffeineEvent;
    private Tuple<bool, float> SpaceMonsterEvent;
    private Tuple<bool, float> PowerOuttageEvent;

    private Tuple<bool, float> eventList;

    private Tuple<bool, float> AsteroidEvent;

    const private float TIMELIMIT = 10.0f;

    void Start()
    {
        this.time = 0.0f;
        this.AsteroidEvent = new Tuple<bool,float> (false,0.0f);
        this.CaffeineEvent = new Tuple<bool, float>(false, 0.0f);
        this.SpaceMonsterEvent = new Tuple<bool, float>(false, 0.0f);
        this.PowerOuttageEvent = new Tuple<bool, float>(false, 0.0f);

        this.eventList =
        {
            this.AsteroidEvent,
            this.CaffeineEvent,
            this.SpaceMonsterEvent,
            this.PowerOuttageEvent,
        };
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;
        if (time % 10.0f == 0)//every 10 seconds
        {
            eventAssignment();
            incrementTime();
        }
    }

    void eventAssignment()
    {
        int num = random.next(0, 3);
        if (this.eventList[num].Item1 != true)
        {
            this.eventList[num].Item1 = true;
            switch (num)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        return;
    }

    void incrementTime()
    {
        foreach int i in this.eventList
        {
            if (this.eventList[i].Item1 == true)
            {
                this.eventList[i].Item2 = this.eventList[i].Item2 + time.deltaTime;
            }//close if
            if (this.eventList[i].Item2 == this.TIMELIMIT)
            {
                this.eventList[i].Item1 = false;
                //some failure statement
            }
        }//close foreach
        return;
    }
}
