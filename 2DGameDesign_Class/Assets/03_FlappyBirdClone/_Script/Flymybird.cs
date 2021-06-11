using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flymybird : MonoBehaviour
{
	private Rigidbody2D _rigi;

	public float Velocity = 1;

	private void Start()
	{
		_rigi = this.GetComponent<Rigidbody2D>(); //_rigi will have the componend of bird's Rigidboy

		
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)) //0 is for left mouse click
		{

			Debug.Log("Mouse or Space key is PRessed");
			_rigi.velocity = Vector2.up * Velocity;
		}

	}
}
