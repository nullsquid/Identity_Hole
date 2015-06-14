using UnityEngine;
using System.Collections;

//public enum World{
//	lovecraft,
//	carol,
//	borges
//};
public class WorldManager : MonoBehaviour {
	public int nodeNumber = 10;

	public WorldNode nodePrefab;
	public static WorldManager instance = null;
	// Use this for initialization
	void Awake () {
		if(instance = null){
			instance = this;
		}
		else if (instance != this){
			Destroy(instance);
		}
		DontDestroyOnLoad(gameObject);
	}

	void Start(){

		WorldNode newNode;
		for(int i = 0; i <= nodeNumber; i++){
			newNode = Instantiate(nodePrefab);
			//newNode.name
			newNode.nodeID = i;
		}
	}

}
