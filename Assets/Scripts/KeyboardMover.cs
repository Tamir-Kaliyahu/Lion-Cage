﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;
    [SerializeField] bool initGameDelay; // whether to delay or not
    bool paused = false;
    void Start()
    {
        if(initGameDelay)
        {
            paused = true;
            DoDelay(6);
            
        }
    }
    private void DoDelay(int delay)
    {
            StartCoroutine(DelayAction(delay));
    }
    IEnumerator DelayAction(int delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        paused = false;
    }

    void Update() {
        if (!paused)
        {
            float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
            float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
            Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
            transform.position += movementVector;
        }
    }
}
