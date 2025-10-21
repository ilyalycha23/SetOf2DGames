using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicker : MonoBehaviour
{
    public int counterClicks, counterCoins, counterGald;
    private int monsterHP1 = 200, monsterHP2 = 500, monsterHP3 = 1000, monsterHP4 = 1500, monsterHP5 = 5000;
    public GameObject Monster1, Monster2, Monster3, Monster4, Monster5;
    public Text CounterTEXT, coinsTEXT, gladTEXT;
    public int allhp = 8388;
    public int PlusBal = 1;
    public GameObject WinCanvas, btnX2, TextCostX2, btnRAVNO6, TextCostRAVNO6, btnGLAD, TextCostGLAD, btnBACK;
    void Update()
    {
         CounterTEXT.text = counterClicks.ToString();
	   coinsTEXT.text = counterCoins.ToString();
	   gladTEXT.text = counterGald.ToString();
	   if(counterClicks >= 200){
	    	Monster1.SetActive(false);
		Monster2.SetActive(true);
	    }
	    if(counterClicks >= 500){
	    	Monster2.SetActive(false);
		Monster3.SetActive(true);
	    }
	    if(counterClicks >= 1000){
	    	Monster3.SetActive(false);
		Monster4.SetActive(true);
	    }
	    if(counterClicks >= 1500){
	    	Monster4.SetActive(false);
		Monster5.SetActive(true);
	    }
	    if(counterClicks >= 5000){
	    	Monster5.SetActive(false);
		WinCanvas.SetActive(true);
		btnBACK.SetActive(false);
	    }
    }
	 
    public void OnClickBtn(){
	    counterClicks+=PlusBal;
	    

	    if(counterClicks%30==0){
	    	counterCoins+=1;
	    }

	    if(counterClicks%100==0){
	    	counterGald+=1;
	    }

	   
		
    }
    public void CoinsBTN(){
	    if(counterCoins>=10 && counterCoins<49){
		counterClicks=0;
	    	PlusBal=2;
		counterCoins-=10;
		btnX2.SetActive(false);
		TextCostX2.SetActive(false);
		btnRAVNO6.SetActive(true);
		TextCostRAVNO6.SetActive(true);
	    }
	    if(counterCoins>=50){
		counterClicks=0;
	    	PlusBal=6;
		counterCoins-=50;
		btnRAVNO6.SetActive(false);
		TextCostRAVNO6.SetActive(false);
	    }
    }
     public void CoinsGLAD(){
	  if(counterGald>=5){
		counterClicks+=500;
		counterGald-=5;
	  }
     }
}
