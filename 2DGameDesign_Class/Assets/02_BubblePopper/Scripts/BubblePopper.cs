using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BubblePopper : MonoBehaviour
{
	Animator anim;

	AudioSource Audio;

	ScoreKeeper ScoreHandler;

	public TMP_Text ScoreText;

	

	private void Start()
	{
		anim = this.GetComponent<Animator>();
		Audio = this.GetComponent<AudioSource>();
		ScoreHandler = FindObjectOfType<ScoreKeeper>();		
		
	}

	private void OnMouseDown()
	{
		
		ScoreHandler.Score++;

		ScoreText.text = ScoreHandler.Score.ToString();
		//Debug.Log("On Mouse down is working");
		anim.SetBool("Pop", true);

		Invoke("DestroytheBubble", 0.6f);

		Audio.Play();


	}

	private void DestroytheBubble()
	{
		Destroy(gameObject);
	}


}
