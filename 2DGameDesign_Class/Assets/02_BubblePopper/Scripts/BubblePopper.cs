using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePopper : MonoBehaviour
{
	Animator anim;


	private void Start()
	{
		anim = this.GetComponent<Animator>();

		
	}

	private void OnMouseDown()
	{

		//Debug.Log("On Mouse down is working");
		anim.SetBool("Pop", true);

		Invoke("DestroytheBubble", 06f);


	}

	private void DestroytheBubble()
	{
		Destroy(gameObject);
	}


}
