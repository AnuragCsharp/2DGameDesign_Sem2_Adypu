using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class ToolFun : MonoBehaviour
{

	public static List<ShareMyLocation> AlltheLocationOfObjects = new List<ShareMyLocation>();


#if UNITY_EDITOR
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;

		Gizmos.DrawWireSphere(transform.position, 2);
	}

	

#endif
}
