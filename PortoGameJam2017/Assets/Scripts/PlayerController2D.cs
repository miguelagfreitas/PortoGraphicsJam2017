﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
	private Rigidbody2D Rb2D;
	private float x_axis;
	private float y_axis;

	public float velocity;

	public BoxCollider2D right_attack;
	public BoxCollider2D left_attack;
	public BoxCollider2D front_attack;
	public BoxCollider2D back_attack;

	private BoxCollider2D[] attack_vector;


	// Use this for initialization
	void Start ()
	{
		Rb2D = GetComponent<Rigidbody2D> ();

		attack_vector = new BoxCollider2D[4];

		attack_vector [0] = right_attack;
		attack_vector [1] = left_attack;
		attack_vector [2] = right_attack;
		attack_vector [3] = right_attack;

	}
	
	// Update is called once per frame
	void Update ()
	{
		x_axis = Input.GetAxisRaw ("Horizontal");
		y_axis = Input.GetAxisRaw ("Vertical");

		Rb2D.velocity = new Vector2 (x_axis, y_axis) * velocity;
	}



}
