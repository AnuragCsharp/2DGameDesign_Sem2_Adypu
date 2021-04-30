using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelManager : MonoBehaviour
{
	public void ChangeLevel(string SceneName)
	{
		//Debug.Log("Your Scene will be Changed " + SceneName);

		SceneManager.LoadScene(SceneName);
	}
}
