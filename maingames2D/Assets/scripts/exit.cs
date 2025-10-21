using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{

    public void quitGame()
    {
	  Debug.Log("Game closed");
        Application.Quit();
    }


}
