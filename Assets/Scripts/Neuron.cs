using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] lines = System.IO.File.ReadAllLines("Assets/testsingle_neuron.csv");
        
        for(int i = 0; i< lines.Length; i++)
        {
            string currLine = lines[i];
            string[] positions = currLine.Split(',');
            Instantiate((GameObject)Resources.Load("Node", typeof(GameObject)), new Vector3(float.Parse(positions[0]), float.Parse(positions[1]), float.Parse(positions[2])), Quaternion.identity);
        }
	}
	

}
