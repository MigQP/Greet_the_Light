using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_select_manager : MonoBehaviour {

	public void BackToMainMenu ()
	{
		SceneManager.LoadScene (1);
	}

	public void ToAladarSong ()
	{
        // A LA CANCIÓN DE ALADAR
        SceneManager.LoadScene(7);
    }
}
