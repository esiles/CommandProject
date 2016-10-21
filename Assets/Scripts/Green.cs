using UnityEngine;
using System.Collections;

public class Green : MonoBehaviour {

	Command move = new RIGHT();//Creates new Right instance to use execute

	void OnMouseDown()
	{
		move.execute ();
	}
}
