using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_btn : MonoBehaviour
{
    public GameObject pole;
    public GameObject mini_menu;
    public GameObject btn_start;
    public void Active() {
        pole.SetActive(true);
        btn_start.SetActive(false);
        mini_menu.SetActive(true);
    }
}
                                                                       