using UnityEngine;
using System.Collections;

public class FlyAway : MonoBehaviour {

	Command goodbye = new Fly ();
	void OnMouseDown()
	{
		goodbye.execute ();
	}
}
