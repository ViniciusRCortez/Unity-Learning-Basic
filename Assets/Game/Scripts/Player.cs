using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Rigidbody2D plyRB;
	private bool canJump;
	private Animator animator;
	
	public float jumpFactor = 5f;
	public float forwardFactor = 0.2f;
	private float forceFoward;
	// Start is called before the first frame update
	private void Start()
	{
		canJump = true;
		plyRB = gameObject.GetComponent<Rigidbody2D>();
		animator = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Jump();
		}   
		
	}

	private void Jump()
	{
		if (canJump)
		{
			canJump = false;
			if (transform.position.x < 0)
			{
				forceFoward = forwardFactor;
			}
			else
			{
				forceFoward = 0.0f;
			}
			plyRB.velocity = new Vector2(forceFoward, jumpFactor);
			animator.Play("player_jumping");
		}
		
	}
	
	private void OnCollisionEnter2D(Collision2D other) 
	{
		animator.Play("player_running");
		canJump = true;		
	}
}
