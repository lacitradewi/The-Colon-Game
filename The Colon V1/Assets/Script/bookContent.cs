using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bookContent : MonoBehaviour {

	public Sprite[] imageBook;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (eventSystem.bookChoice == 1) {
			gameObject.GetComponent<Image>().sprite = imageBook[0];
		}
		else if (eventSystem.bookChoice == 2) {
			gameObject.GetComponent<Image>().sprite = imageBook[1];
		}
		else if (eventSystem.bookChoice == 3) {
			gameObject.GetComponent<Image>().sprite = imageBook[2];
		}
		else if (eventSystem.bookChoice == 4) {
			gameObject.GetComponent<Image>().sprite = imageBook[3];
		}
		else if (eventSystem.bookChoice == 5) {
			gameObject.GetComponent<Image>().sprite = imageBook[4];
		}
		else if (eventSystem.bookChoice == 6) {
			gameObject.GetComponent<Image>().sprite = imageBook[5];
		}
		else if (eventSystem.bookChoice == 7) {
			gameObject.GetComponent<Image>().sprite = imageBook[6];
		}
		else if (eventSystem.bookChoice == 8) {
			gameObject.GetComponent<Image>().sprite = imageBook[7];
		}
		else if (eventSystem.bookChoice == 9) {
			gameObject.GetComponent<Image>().sprite = imageBook[8];
		}
		else if (eventSystem.bookChoice == 10) {
			gameObject.GetComponent<Image>().sprite = imageBook[9];
		}
		else if (eventSystem.bookChoice == 11) {
			gameObject.GetComponent<Image>().sprite = imageBook[10];
		}
		else if (eventSystem.bookChoice == 12) {
			gameObject.GetComponent<Image>().sprite = imageBook[11];
		}
		else if (eventSystem.bookChoice == 13) {
			gameObject.GetComponent<Image>().sprite = imageBook[12];
		}
		else if (eventSystem.bookChoice == 14) {
			gameObject.GetComponent<Image>().sprite = imageBook[13];
		}
		else if (eventSystem.bookChoice == 15) {
			gameObject.GetComponent<Image>().sprite = imageBook[14];
		}
		else if (eventSystem.bookChoice == 16) {
			gameObject.GetComponent<Image>().sprite = imageBook[15];
		}
	}
}
