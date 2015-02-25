using UnityEngine;
using System.Collections;

public class mechanics : MonoBehaviour {
	public int life =1000;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] red = GameObject.FindGameObjectsWithTag("red");
		GameObject[] blue = GameObject.FindGameObjectsWithTag("blue");
		GameObject[] yellow = GameObject.FindGameObjectsWithTag("yellow");
		GameObject[] green = GameObject.FindGameObjectsWithTag("green");
		GameObject[] orange = GameObject.FindGameObjectsWithTag("orange");

		if (life>0&&this.GetComponent<instantiate>().gameActive == true){
			//original prefab count as 1,so it has to be desired number +1, ie 3+1=4
			if (red.Length>4){
				life -= 1;
			}
			if (red.Length<3){
				life -= 1;
			}
			if (blue.Length>4){
				life -= 1;
			}
			if (blue.Length<3){
				life -= 1;
			}
			if (yellow.Length>4){
				life -= 1;
			}
			if (yellow.Length<3){
				life -= 1;
			}
			if (green.Length>4){
				life -= 1;
			}
			if (green.Length<3){
				life -= 1;
			}
			if (orange.Length>4){
				life -= 1;
			}
			if (orange.Length<3){
				life -= 1;
			}
			else {

			}
		}
		else{
			//Game over

		}
		Debug.Log (life);
	}
}
