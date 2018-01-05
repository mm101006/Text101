using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	// requires the use of Using UnityEngine.UI
	public Text text;
	
	private enum States {SubBase, Pack, Sleep, Continue, Stern, Zenith, Horizon};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.SubBase;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.SubBase) {
			SubBase();
		} else if (myState == States.Sleep){
			Sleep();
		} else if (myState == States.Pack){
			Pack();
		} else if (myState == States.Continue) {
			Continue();
		} else if (myState == States.Stern){
			Stern();
		} else if (myState == States.Zenith){
			Zenith();
		} else if (myState == States.Horizon){
			Horizon();
		}
		
	}
	
	#region State handler methods
	void SubBase() {
		text.text = "Captain: Listen up you Seamen, operation Look Wide starts today. " +
					"So pack your bags and be ready to board at 08 hundred.\n\n " +
					"You decide to...\n\n" +
					"Press S to Sleep or P to Pack your Bags.";
		
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.Sleep;
		} else if (Input.GetKeyDown(KeyCode.P)){
			myState = States.Pack;
		} 
	}
	
	void Sleep() {
		text.text = "You wake up from your cat nap, glance at your watch, " +
					"and discover the time. You quickly rummage through your belongings " +
					"and pack what you can. Then you make a mad dash to the docking " +
					"station. As you arrive you see the submarine submerge into the water..." +
					"The adventure goes on without you...\n\n" +
					"Press P to Play again";
		
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.SubBase;
		}		
	}
	
	void Pack() {
		text.text = "You walk to your room and start to pack your bags. " +
					"You then glance at your watch and discover the time 07:55. " +
					"You quickly make a mad dash to the docking station. " +
					"As you arrive the captain blurts out: I like my seamen on time!\n\n" + 
					"Welcome Aboard!\n\n" +
					"Press C to Continue";
					
		if (Input.GetKeyDown(KeyCode.C)){
			myState = States.Continue;
		}
	}
	
	void Continue() {
		text.text = "Day 33: The submarine is currently drifting on the surface of the ocean " +
					"somewhere between Pearl Harbour and the West Coast of the United States. " +
					"Your current assignment is to sweep the perimeter and report back " +
					"to the captain if you discover anything odd.\n\n" +
					"You began your search by:\n\n" +
					"Press S to look from bow to stern, or Z to look from horizon to zenith, " + 
					"or H to look back towards the horizon.\n\n";
					
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.Stern;
		} else if (Input.GetKeyDown(KeyCode.Z)) {
			myState = States.Zenith;
		} else if (Input.GetKeyDown(KeyCode.H)) {
			myState = States.Horizon;
		}
	}
	
	void Stern() {
		text.text = "As you look towards the stern, you don't see anything but clouds and water. " +
					"You sigh and ask yourself when will this monotony ever end.\n\n" +
					"Press R to Return to your assignment.";
					
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.Continue;
		} 
	}
		
	void Zenith() {
		text.text = "As you look towards the stern, you don't see anything but clouds and water. " +
					"You sigh and ask yourself when will this monotony ever end.\n\n" +
					"Press R to Return to your assignment.";		
		
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.Continue;
		} 
	}
	
	void Horizon() {
		text.text = "As you look back towards the horizon you see a huge disk rise from beneath the ocean " +
					"tumble lazily on its axis and then shoot up into the sky." +
					"You quickly notify the captain, before you know it, " +
					"the captain is scurrying to the bridge and begans snapping pictures.\n\n" +
					"The huge disk then plunges out of the clouds, tumbles, and then creates " +
					"a giant opening in the ocean and plunges in....\n\n" +
					"Press P to Play again";
					
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.SubBase;
		}
	}
	#endregion
	
}