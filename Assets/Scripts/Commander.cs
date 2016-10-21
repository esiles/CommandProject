using UnityEngine;
using System.Collections;

/*-------------------The Command Abstract Class---------*/
public abstract class Command {

	public abstract void execute();
	public static bool check = false; 
	public static int z;

	 
	 
}


/*------------------The Commands---------------------*/
 class LEFT : Command
{
	
	public override void execute()
	{
		if (check == true) {	
			if (z == 1) {
				Train.monotrain.velocity = Vector3.zero;
			} else if (z == 2) {
				Train.monotrain.AddForce (50, 0, 0);
			} else
				Train.monotrain.AddForce (-50, 0, 0);
			Train.Print ();
		} else
			Train.monotrain.AddForce (-50, 0, 0);
	}
}

 class RIGHT: Command
{
	public  override void execute ()
	{
		if (check == true) {	
			
			if (z == 1) {
				Train.monotrain.AddForce (-50, 0, 0);

			} else if (z == 2) {
				Train.monotrain.velocity = Vector3.zero;
			} else
				Train.monotrain.AddForce (50, 0, 0);
			Train.Print ();
		}
		else
			Train.monotrain.AddForce (50, 0, 0);
	}
}

class STOP: Command
{
	public override void execute()
	{
		if (check == true) {
			
			if (z == 1) {
				Train.monotrain.AddForce (50, 0, 0);

			} else if (z == 2) {
				Train.monotrain.AddForce (-50, 0, 0);
			}
			else
			Train.monotrain.velocity = Vector3.zero;
			Train.Print ();
		}
		else
		Train.monotrain.velocity = Vector3.zero;
	}
}

class MYSTERY: Command
{
	public override void execute()
	{
		z = UnityEngine.Random.Range (0, 3); //Generates random number between 0-2
		Train.Print ();
		check = true;	//Will switch check to true after execute is called for the first time. Before that Default values are given to buttons.
	}
}

class Fly : Command
{
	public override void execute()
	{
		
		for (int i = 0; i < 3; i++) {
			Train.monotrain.AddForce (0, 100, 0);
		}	

	}
}
