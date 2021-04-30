using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePop : MonoBehaviour
{
	Animator anim;
	float speed = 20f;

	private void Start()
	{
		anim = GetComponent<Animator>();

	}

	private void OnMouseDown()
	{
		anim.SetBool("Pop",true);

		Invoke("DestroyBubbble", 0.62f);
	}

	private void Update()
	{
		this.transform.Rotate(new Vector3(0, 0,  speed * Time.deltaTime));
	}

	private void DestroyBubbble()
	{
		Destroy(this.gameObject);
	}
}
