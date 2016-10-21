using UnityEngine;
using System.Collections;

public class Red : MonoBehaviour {

	public Command move = new STOP(); //Creates new Stop Instance to call execute;

	void OnMouseDown()
	{
		move.execute ();
		print ("mouse clicked on red");
	}
}
