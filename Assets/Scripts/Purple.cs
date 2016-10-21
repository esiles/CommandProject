using UnityEngine;
using System.Collections;

public class Purple : MonoBehaviour {

	public Command move = new LEFT();//Creates new Purple instance to use execute

	void OnMouseDown()
	{
		move.execute ();
		print ("mouse clicked on purple");
	}
}
