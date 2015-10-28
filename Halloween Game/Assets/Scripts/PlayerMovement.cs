﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private Vector2 _input, _movement;
    float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _movement = _input.normalized * speed * Time.deltaTime;
        transform.Translate(_movement);

        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 playerToMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.x);

        Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
        transform.rotation = newRotation;
  
        }
}
