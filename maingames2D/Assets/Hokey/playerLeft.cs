using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLeft : MonoBehaviour
{
    private Vector2 mousePos;
    private Rigidbody2D rb;
    private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
	  if(Input.GetMouseButton(0)){
        	mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        	if (mousePos.y <= 4.666843 && mousePos.y >= -4.66 && mousePos.x <= 0 && mousePos.x >= -10.45)
        	{
            	rb.MovePosition(mousePos);
        	}
        }
    }
}
