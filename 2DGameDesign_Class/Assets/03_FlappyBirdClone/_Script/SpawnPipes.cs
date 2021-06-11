using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
	public float maxTime = 1;

	private float _Timer = 0;

	public GameObject Pipes;

	public float Height = 0.35f;
	


	private void Update() //Every Frame
	{
		
	

		Debug.LogError("What is deltay timie" + Time.deltaTime);
;
		if (_Timer > maxTime)
		{
			GameObject NewPipe = Instantiate(Pipes);

			NewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height,Height), 0);

			Destroy(NewPipe, 5f);

			_Timer = 0;
		}

		//Debug.Log("What is happen to TIme " + _Timer);

		_Timer += Time.deltaTime; //Time 0.0002
	}
}
