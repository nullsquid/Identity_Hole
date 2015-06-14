using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EventManager : MonoBehaviour {

	Dictionary<string, string> games = new Dictionary<string, string>();
	public static EventManager instance = null;
	void Awake(){
		//games.Add("lostbat", "bat");
		if(instance = null){
			instance = this;
		}
		else if (instance != null){
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);

	}
	void InitEvent(string nameOfEvent){
		switch(nameOfEvent){
			//case "curse":

		}
	}

}
