using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour 
{
	public static Rigidbody monotrain; //Rigidbody for all other scripts




	public static Rigidbody trainInstance//Singleton implementation 
	{
		get
		{
			if (monotrain == null) 
			{
				monotrain = GameObject.FindWithTag("Player").GetComponent<Rigidbody> (); //Gets the single monotrain rigidbody to work with
			}
			return monotrain;
		}

	}

	public void Awake()//Get the train instance on awake
	{
		monotrain = trainInstance ;
		print ("Created the instance of train");	//Check to make sure Awake is called.

	}

	public static void Print()
	{
		print ("Has entered the execute command");	//Used to check if commands and executes are being called from the invokers
	}
}
/*---------------------------------------------------*/
