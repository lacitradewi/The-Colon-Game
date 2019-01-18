using UnityEngine;
using System.Collections;

public class eventSystem : MonoBehaviour {

	public static int bookChoice;

	public void nextScene (int scene){
		Application.LoadLevel (scene);
	}

	public void exitScene(){
		Application.Quit ();
	}

	public void readBook(int book){
		bookChoice = book;
	}
}
