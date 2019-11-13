﻿
using UnityEngine;
using System.Collections;

public class PlayerTrackingCamera : MonoBehaviour
{

    public GameObject player;        //Public variable to store a reference to the player game object
    private Vector2 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = new Vector2(0f, transform.position.y - player.transform.position.y);
    }

    // LateUpdate is called after Update each frame
    void Update()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = new Vector2(0f, player.transform.position.y + offset.y);
    }
}