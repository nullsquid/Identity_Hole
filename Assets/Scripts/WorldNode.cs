using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldNode : MonoBehaviour {

	public string theText;
	public int nodeID;
	public string eventText;
	public bool hasEvent = false;
	public List<string> happenedSoFar = new List<string>();
	public string world;

	void Awake(){
		happenedSoFar.Add(null);
	}

}
