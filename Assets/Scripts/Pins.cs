﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour
{
    private List<Vector3> startPos = new List<Vector3>();
    private List<Transform> pins = new List<Transform>();
    private int numPinsDown = 0;
    public int numPins = 10;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform)
        {
            startPos.Add(child.position);
            pins.Add(child);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in pins)
        {
            if (child.gameObject.activeInHierarchy && child.position.y < -5f)
            {
                child.gameObject.SetActive(false);
                numPinsDown++;
                numPins--;
            }
        }
        if (numPinsDown == pins.Count)
        {
            Reset();
        }
    }

    void Reset()
    {
        for(int i = 0; i < pins.Count; i++)
        {
            pins[i].gameObject.SetActive(true);
            pins[i].position = startPos[i];
            pins[i].rotation = Quaternion.identity;
            Rigidbody r = pins[i].GetComponent<Rigidbody>();
            r.velocity = Vector3.zero;
            r.angularVelocity = Vector3.zero;
        }
        numPinsDown = 0;
        numPins = 10;
    }
}
