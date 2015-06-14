using UnityEngine;
using System.Collections;

public class Book : MonoBehaviour {

	public int day = 1;
	public int dayLimit = 3;

	public float startTime = 0f;
	public float timer;

	public bool timerIsRunning = true;

	public float timeInDay;

	public World curWorld;

	void Start(){
		timer = startTime;
	}
	void Update(){
		if(timerIsRunning == true){
		timer += Time.deltaTime;
			if(timer >= timeInDay){

				Invoke("NextDay", 0);
				timer = 0;
			}
		}
		else{
			timer = 0;
		}
	}

	public void SwitchWorld(string worldName){
		switch(worldName){

		}
	}

	void NextDay(){
		day += 1;

	}

}
