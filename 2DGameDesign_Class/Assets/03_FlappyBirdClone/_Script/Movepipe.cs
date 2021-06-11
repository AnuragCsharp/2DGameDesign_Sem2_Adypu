using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movepipe : MonoBehaviour
{
	public float Speed = 1f;


	private void Update()
	{
		this.transform.position += Vector3.left * Speed * Time.deltaTime;
	}
}
