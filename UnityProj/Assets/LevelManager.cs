using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(string name){
		Debug.Log ("Level Load Requested for: " + name);
		Application.LoadLevel (name);
	}
	public void QuitGame(){
		Debug.Log ("Quit Requested");
		Application.Quit ();
	}
}
