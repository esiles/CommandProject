using UnityEngine;
using System.Collections;

public class Random : MonoBehaviour {

	public Command move = new MYSTERY(); //Creates new Mystery instance to use its execute

	void OnMouseDown()
	{
		move.execute ();

	}
}
