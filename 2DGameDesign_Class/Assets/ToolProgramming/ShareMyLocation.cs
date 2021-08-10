using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ShareMyLocation : MonoBehaviour
{



	private void OnEnable() =>	ToolFun.AlltheLocationOfObjects.Add(this); 

	private void OnDisable() => ToolFun.AlltheLocationOfObjects.Remove(this);


}
