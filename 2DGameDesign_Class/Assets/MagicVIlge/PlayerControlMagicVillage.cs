using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlMagicVillage : MonoBehaviour
{
	public float PlayerSpeed;

	private float Hori, Vert;

	private Rigidbody2D _Rigi;

	private Animator _Anim;	


	private void Start()
	{
		_Rigi = this.GetComponent<Rigidbody2D>();

		_Anim = this.GetComponent<Animator>();
	}

	private void Update()
	{
		Hori = Input.GetAxisRaw("Horizontal");
		

		Vert = Input.GetAxisRaw("Vertical");


		

		if (Vert == 1 || Vert == -1)
		{
			_Anim.SetBool("WalkLeftRight", false);
			_Anim.SetBool("WalkUpDown", true);
			
		}
		else if (Vert == 0 )
		{
			
			_Anim.SetBool("WalkUpDown", false);
		}

		if (Hori == -1)
		{
			this.GetComponent<SpriteRenderer>().flipX = true;
			_Anim.SetBool("WalkLeftRight", true);
			_Anim.SetBool("WalkUpDown", false);

			
		}

		else if (Hori == 1)
		{
			this.GetComponent<SpriteRenderer>().flipX = false;
			_Anim.SetBool("WalkLeftRight", true);
			_Anim.SetBool("WalkUpDown", false);
			
		}
		else
		{
			_Anim.SetBool("WalkLeftRight", false);
		}




		Debug.Log("Horizontal " + Hori);

	}

	private void FixedUpdate()
	{
		_Rigi.velocity = new Vector2(Hori * PlayerSpeed * Time.deltaTime, Vert * PlayerSpeed * Time.deltaTime);
	}
}
