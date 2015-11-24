﻿using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public float speed = 0.5f;
    private float moveX = 0;
    private float moveY = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
         Vector2 moveDirection = GetComponent<Rigidbody2D>().velocity;
         if (moveDirection != Vector2.zero) {
             float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
             transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
         }
        //if (GetComponent<Rigidbody2D>().velocity.x < 0) {
        //    GetComponent<Sprite>(). .Rotate(-90,0,0);
        //}
        //if (GetComponent<Rigidbody2D>().velocity.x > 0) {
        //    GetComponent<Transform>().Rotate(-90, 0, 0);
        //}
        //if (GetComponent<Rigidbody2D>().velocity.y < 0) {
        //    GetComponent<Transform>().Rotate(-90, 0, 0);
        //}
        //if (GetComponent<Rigidbody2D>().velocity.y > 0) {
        //    GetComponent<Transform>().Rotate(-90, 0, 0);
        //}
	}
    void FixedUpdate() {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * speed, moveY * speed);
    }
}
