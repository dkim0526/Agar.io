using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Eat : MonoBehaviour {

	public string Tag;
	public float Increase;
	public Text Letters;

	int Score;


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == Tag) {
			transform.localScale += new Vector3 (Increase, Increase, Increase);
			Destroy (other.gameObject);

			Score += 10;
			Letters.text = "SCORE: " + Score;
		}
		
	}
}
