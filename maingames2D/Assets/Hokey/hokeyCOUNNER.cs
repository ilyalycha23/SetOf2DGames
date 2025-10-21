using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hokeyCOUNNER : MonoBehaviour
{
    private int firstPlayerCounter;
    private int secondPlayerCounter;
    public GameObject shauba;
    public Text playerOneTEXT, playerTwoTEXT;
    public Transform transf1, transf2;

    // Update is called once per frame
    void Update()
    {
        playerOneTEXT.text = firstPlayerCounter.ToString();
	  playerTwoTEXT.text = secondPlayerCounter.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "GOALleft"){
	  	firstPlayerCounter+=1;
		Debug.Log(transf2.transform.position);
		transform.position = transf2.transform.position;
		
	  }else if(other.tag == "GOALright"){
		secondPlayerCounter+=1;
		Debug.Log(transf1.transform.position);
		transform.position = transf1.transform.position;
	  }
    }
}
