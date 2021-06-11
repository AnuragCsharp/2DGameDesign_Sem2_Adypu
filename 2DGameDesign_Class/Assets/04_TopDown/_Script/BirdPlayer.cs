using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPlayer : MonoBehaviour
{


	public float speed = 5f;

	private void Update()
	{
		PlayerMovement();
	}

	private void PlayerMovement() //THis method  will handle the movement of Player
	{
		float moveX = 0f;
		float moveY = 0f;

		//If Player moves upward

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			moveY = +1f;

			//Debug.Log("Move Ki Value = " + moveY);
		}

		//If PLayer moves Downward

		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			moveY = -1f;

			//Debug.Log("Move Ki Value = " + moveY);
		}

		//if player move RIght

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			moveX = +1f;

			//Debug.Log("Move Ki Value = " + moveX);
		}

		//if player move Lef


		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			moveX = -1f;

			//Debug.Log("Move Ki Value = " + moveX);
		}

		Vector3 moveDir = new Vector3(moveX, moveY).normalized;

		this.transform.position += moveDir * speed * Time.deltaTime;

	}


	private void OnCollisionEnter2D(Collision2D HitObject)
	{
		Debug.Log("I am hitting with " + HitObject.gameObject.name);
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		Debug.Log("I am no more hitting the object " + collision.gameObject.name);
	}


	private void OnTriggerEnter2D(Collider2D HitObject)
	{
		if (HitObject.CompareTag("Coin"))
		{
			HitObject.gameObject.SetActive(false);
		}
	}


	//private void OnTriggerStay2D(Collider2D collision)
	//{
	//	Debug.LogWarning("I am staing in the Jungle " + collision.gameObject.name);
	//}

	//private void OnTriggerExit2D(Collider2D collision)
	//{
	//	Debug.LogError("Bye Bye Jungle " + collision.gameObject.name);
	//}
}
