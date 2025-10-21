
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class game_main : MonoBehaviour
{
    public int global_counter = 0;
    //
    public bool true_sets = true;
    //
    public int krest_or_nol_1 = 0;//1 - krest, 2  - nol
    public int krest_or_nol_2 = 0;
    public int krest_or_nol_3 = 0;
    public int krest_or_nol_4 = 0;
    public int krest_or_nol_5 = 0;
    public int krest_or_nol_6 = 0;
    public int krest_or_nol_7 = 0;
    public int krest_or_nol_8 = 0;
    public int krest_or_nol_9 = 0;
    //
    public GameObject win_text_x;
    public GameObject win_text_o;
    //
    public GameObject pole_kletchatoe;
    //
    public GameObject btn_main_exit;
    public GameObject btn_odinochnaya;
    public GameObject btn_main_start;
    //
    public GameObject border_menu;
    public GameObject border_menu_1;
    public GameObject border_menu_2;
    public GameObject border_menu_3;
    public GameObject border_menu_4;
    public GameObject btn_menu_border_poddtvergdenue;
    public GameObject border_left;
    public GameObject border_right;
    public GameObject border_up;
    public GameObject border_down;
    //
    public GameObject restart_btn;
    public int counter_restart_btn;
    //
    public GameObject mini_menu_LLIesterenka;
    //
    public GameObject btn_1;
    public GameObject btn_2;
    public GameObject btn_3;
    public GameObject btn_4;
    public GameObject btn_5;
    public GameObject btn_6;
    public GameObject btn_7;
    public GameObject btn_8;
    public GameObject btn_9;
    //
    public GameObject znak_krest_1;
    public GameObject znak_nollik_1;
    //
    public GameObject znak_krest_2;
    public GameObject znak_nollik_2;
    //
    public GameObject znak_krest_3;
    public GameObject znak_nollik_3;
    //
    public GameObject znak_krest_4;
    public GameObject znak_nollik_4;
    //
    public GameObject znak_krest_5;
    public GameObject znak_nollik_5;
    //
    public GameObject znak_krest_6;
    public GameObject znak_nollik_6;
    //
    public GameObject znak_krest_7;
    public GameObject znak_nollik_7;
    //
    public GameObject znak_krest_8;
    public GameObject znak_nollik_8;
    //
    public GameObject znak_krest_9;
    public GameObject znak_nollik_9;


    public void Check_btn_1() {
        global_counter = global_counter + 1;
        if (global_counter == 1) {
            znak_krest_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_1.SetActive(true);
            btn_1.SetActive(false);
            krest_or_nol_1 = 1;
        }
    }

    public void Check_btn_2()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_2.SetActive(true);
            btn_2.SetActive(false);
            krest_or_nol_2 = 1;
        }
    }
    public void Check_btn_3()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_3.SetActive(true);
            btn_3.SetActive(false);
            krest_or_nol_3 = 1;
        }
    }
    public void Check_btn_4()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_4.SetActive(true);
            btn_4.SetActive(false);
            krest_or_nol_4 = 1;
        }
    }
    public void Check_btn_5()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_5.SetActive(true);
            btn_5.SetActive(false);
            krest_or_nol_5 = 1;
        }
    }
    public void Check_btn_6()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_6.SetActive(true);
            btn_6.SetActive(false);
            krest_or_nol_6 = 1;
        }
    }
    public void Check_btn_7()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_7.SetActive(true);
            btn_7.SetActive(false);
            krest_or_nol_7 = 1;
        }
    }
    public void Check_btn_8()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 1;
        }
        else if (global_counter == 6)
        {
            znak_nollik_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_8.SetActive(true);
            btn_8.SetActive(false);
            krest_or_nol_8 = 1;
        }
    }
    public void Check_btn_9()
    {
        global_counter = global_counter + 1;
        if (global_counter == 1)
        {
            znak_krest_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 1;
        }
        else if (global_counter == 2)
        {
            znak_nollik_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 2;
        }
        else if (global_counter == 3)
        {
            znak_krest_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 1;
        }
        else if (global_counter == 4)
        {
            znak_nollik_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 2;
        }
        else if (global_counter == 5)
        {
            znak_krest_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 1;
        }
        else if (global_counter == 6) 
        {
            znak_nollik_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 2;
        }
        else if (global_counter == 7)
        {
            znak_krest_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 1;
        }
        else if (global_counter == 8)
        {
            znak_nollik_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 2;
        }
        else if (global_counter == 9)
        {
            znak_krest_9.SetActive(true);
            btn_9.SetActive(false);
            krest_or_nol_9 = 1;
        }
    }
    public void click_restart_btn()
    {
        if (krest_or_nol_1 == 1 || krest_or_nol_2 == 1 || krest_or_nol_3 == 1 || krest_or_nol_4 == 1 || krest_or_nol_5 == 1 || krest_or_nol_6 == 1 || krest_or_nol_7 == 1 || krest_or_nol_8 == 1 || krest_or_nol_9 == 1)
        {
            win_text_x.SetActive(false);
        }
        if (krest_or_nol_1 == 2 || krest_or_nol_2 == 2 || krest_or_nol_3 == 2 || krest_or_nol_4 == 2 || krest_or_nol_5 == 2 || krest_or_nol_6 == 2 || krest_or_nol_7 == 2 || krest_or_nol_8 == 2 || krest_or_nol_9 == 2) {
            win_text_o.SetActive(false);
        }
        // 
        restart_btn.SetActive(false);
        //
        znak_krest_1.SetActive(false);
        znak_nollik_1.SetActive(false);
        //
        znak_krest_2.SetActive(false);
        znak_nollik_2.SetActive(false);
        //
        znak_krest_3.SetActive(false);
        znak_nollik_3.SetActive(false);
        //
        znak_krest_4.SetActive(false);
        znak_nollik_4.SetActive(false);
        //
        znak_krest_5.SetActive(false);
        znak_nollik_5.SetActive(false);
        //
        znak_krest_6.SetActive(false);
        znak_nollik_6.SetActive(false);
        //
        znak_krest_7.SetActive(false);
        znak_nollik_7.SetActive(false);
        //
        znak_krest_8.SetActive(false);
        znak_nollik_8.SetActive(false);
        //
        znak_krest_9.SetActive(false);
        znak_nollik_9.SetActive(false);
        //
        btn_1.SetActive(true);
        btn_2.SetActive(true);
        btn_3.SetActive(true);
        btn_4.SetActive(true);
        btn_5.SetActive(true);
        btn_6.SetActive(true);
        btn_7.SetActive(true);
        btn_8.SetActive(true);
        btn_9.SetActive(true);
        //
        krest_or_nol_1 = 0;
        krest_or_nol_2 = 0;
        krest_or_nol_3 = 0;
        krest_or_nol_4 = 0;
        krest_or_nol_5 = 0;
        krest_or_nol_6 = 0;
        krest_or_nol_7 = 0;
        krest_or_nol_8 = 0;
        krest_or_nol_9 = 0;
        //
        global_counter = 0;
    }
    
    //функции для мини-меню слева сверху
    public void btn_menu_border() {
        border_menu.SetActive(true);
        border_menu_1.SetActive(true);
        border_menu_2.SetActive(true);
        border_menu_3.SetActive(true);
        border_menu_4.SetActive(true);
    }
    public void btn_menu_border_tester()
    {
        border_menu_1.SetActive(false);
        border_menu_2.SetActive(false);
        border_menu_3.SetActive(false);
        border_menu_4.SetActive(false);
        border_menu.SetActive(false);
    }


    public void out_mini_btn() {
        border_menu.SetActive(false);
        btn_menu_border_poddtvergdenue.SetActive(true);
        border_left.SetActive(true);
        border_right.SetActive(true);
        border_up.SetActive(true);
        border_down.SetActive(true);
    }
    public void out_mini_btn_poddtvergdenue()
    {
        btn_menu_border_poddtvergdenue.SetActive(false);
        border_left.SetActive(false);
        border_right.SetActive(false);
        border_up.SetActive(false);
        border_down.SetActive(false);
    }
    public void out_mini_btn_poddtvergdenue_yes()
    {
        //проверка на вывод сообщения о победе
        pole_kletchatoe.SetActive(false);
        if (counter_restart_btn == 1) {
            restart_btn.SetActive(false);
        }
        //
        btn_menu_border_poddtvergdenue.SetActive(false);
        if (krest_or_nol_1 == 1) {
            btn_1.SetActive(false);
            znak_krest_1.SetActive(false);
        }
        if (krest_or_nol_2 == 1)
        {
            btn_2.SetActive(false);
            znak_krest_2.SetActive(false);
        }
        if (krest_or_nol_3 == 1)
        {
            btn_3.SetActive(false);
            znak_krest_3.SetActive(false);
        }
        if (krest_or_nol_4 == 1)
        {
            btn_4.SetActive(false);
            znak_krest_4.SetActive(false);
        }
        if (krest_or_nol_5 == 1)
        {
            btn_5.SetActive(false);
            znak_krest_5.SetActive(false);
        }
        if (krest_or_nol_6 == 1)
        {
            btn_6.SetActive(false);
            znak_krest_6.SetActive(false);
        }
        if (krest_or_nol_7 == 1)
        {
            btn_7.SetActive(false);
            znak_krest_7.SetActive(false);
        }
        if (krest_or_nol_8 == 1)
        {
            btn_8.SetActive(false);
            znak_krest_8.SetActive(false);
        }
        if (krest_or_nol_9 == 1)
        {
            btn_9.SetActive(false);
            znak_krest_9.SetActive(false);
        }

        //очистка поля для игры O
        btn_menu_border_poddtvergdenue.SetActive(false);
        if (krest_or_nol_1 == 2)
        {
            btn_1.SetActive(false);
            znak_nollik_1.SetActive(false);
        }
        if (krest_or_nol_2 == 2)
        {
            btn_2.SetActive(false);
            znak_nollik_2.SetActive(false);
        }
        if (krest_or_nol_3 == 2)
        {
            btn_3.SetActive(false);
            znak_nollik_3.SetActive(false);
        }
        if (krest_or_nol_4 == 2)
        {
            btn_4.SetActive(false);
            znak_nollik_4.SetActive(false);
        }
        if (krest_or_nol_5 == 2)
        {
            btn_5.SetActive(false);
            znak_nollik_5.SetActive(false);
        }
        if (krest_or_nol_6 == 2)
        {
            btn_6.SetActive(false);
            znak_nollik_6.SetActive(false);
        }
        if (krest_or_nol_7 == 2)
        {
            btn_7.SetActive(false);
            znak_nollik_7.SetActive(false);
        }
        if (krest_or_nol_8 == 2)
        {
            btn_8.SetActive(false);
            znak_nollik_8.SetActive(false);
        }
        if (krest_or_nol_9 == 2)
        {
            btn_9.SetActive(false);
            znak_nollik_9.SetActive(false);
        }

        win_text_o.SetActive(false);
        win_text_x.SetActive(false);

        //включение основного меню
        btn_main_exit.SetActive(true);
        btn_odinochnaya.SetActive(true);
        btn_main_start.SetActive(true);
        krest_or_nol_1 = 0;
        krest_or_nol_2 = 0;
        krest_or_nol_3 = 0;
        krest_or_nol_4 = 0;
        krest_or_nol_5 = 0;
        krest_or_nol_6 = 0;
        krest_or_nol_7 = 0;
        krest_or_nol_8 = 0;
        krest_or_nol_9 = 0;
        btn_1.SetActive(true);
        btn_2.SetActive(true);
        btn_3.SetActive(true);
        btn_4.SetActive(true);
        btn_5.SetActive(true);
        btn_6.SetActive(true);
        btn_7.SetActive(true);
        btn_8.SetActive(true);
        btn_9.SetActive(true);
        global_counter = 0;
        mini_menu_LLIesterenka.SetActive(false);
    }

    public void out_mini_btn_poddtvergdenue_no()
    {
        btn_menu_border_poddtvergdenue.SetActive(false);
        border_left.SetActive(false);
        border_right.SetActive(false);
        border_up.SetActive(false);
        border_down.SetActive(false);
    }

    public void btn_odinochnaya_igra() {

        pole_kletchatoe.SetActive(true);
        btn_main_exit.SetActive(false);
        btn_odinochnaya.SetActive(false);
        btn_main_start.SetActive(false);
        //исправить автоматическое включение игры на двоих
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    void Update() {
        //проверка для X
        if (krest_or_nol_1 == 1 && krest_or_nol_2 == 1 && krest_or_nol_3 == 1) {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_4 == 1 && krest_or_nol_5 == 1 && krest_or_nol_6 == 1)
        {
            win_text_x.SetActive(true);
            counter_restart_btn = 1;
            restart_btn.SetActive(true);
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_7 == 1 && krest_or_nol_8 == 1 && krest_or_nol_9 == 1)
        {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_1 == 1 && krest_or_nol_4 == 1 && krest_or_nol_7 == 1)
        {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;

        }
        else if (krest_or_nol_2 == 1 && krest_or_nol_5 == 1 && krest_or_nol_8 == 1)
        {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_3 == 1 && krest_or_nol_6 == 1 && krest_or_nol_9 == 1)
        {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_3 == 1 && krest_or_nol_5 == 1 && krest_or_nol_7 == 1)
        {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_1 == 1 && krest_or_nol_5 == 1 && krest_or_nol_9 == 1)
        {
            win_text_x.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        //проверка для О
        if (krest_or_nol_1 == 2 && krest_or_nol_2 == 2 && krest_or_nol_3 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_4 == 2 && krest_or_nol_5 == 2 && krest_or_nol_6 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_7 == 2 && krest_or_nol_8 == 2 && krest_or_nol_9 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_1 == 2 && krest_or_nol_4 == 2 && krest_or_nol_7 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_2 == 2 && krest_or_nol_5 == 2 && krest_or_nol_8 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_3 == 2 && krest_or_nol_6 == 2 && krest_or_nol_9 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_3 == 2 && krest_or_nol_5 == 2 && krest_or_nol_7 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0)
            {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        else if (krest_or_nol_1 == 2 && krest_or_nol_5 == 2 && krest_or_nol_9 == 2)
        {
            win_text_o.SetActive(true);
            restart_btn.SetActive(true);
            counter_restart_btn = 1;
            if (krest_or_nol_1 == 0) {
                btn_1.SetActive(false);
            }
            if (krest_or_nol_2 == 0)
            {
                btn_2.SetActive(false);
            }
            if (krest_or_nol_3 == 0)
            {
                btn_3.SetActive(false);
            }
            if (krest_or_nol_4 == 0)
            {
                btn_4.SetActive(false);
            }
            if (krest_or_nol_5 == 0)
            {
                btn_5.SetActive(false);
            }
            if (krest_or_nol_6 == 0)
            {
                btn_6.SetActive(false);
            }
            if (krest_or_nol_7 == 0)
            {
                btn_7.SetActive(false);
            }
            if (krest_or_nol_8 == 0)
            {
                btn_8.SetActive(false);
            }
            if (krest_or_nol_9 == 0)
            {
                btn_9.SetActive(false);
            }
        }
        if (krest_or_nol_1 != 0 && krest_or_nol_2 != 0 && krest_or_nol_3 != 0 && krest_or_nol_4 != 0 && krest_or_nol_5 != 0 && krest_or_nol_6 != 0 && krest_or_nol_7 != 0 && krest_or_nol_8 != 0 && krest_or_nol_9 != 0) {
            restart_btn.SetActive(true);
        }
    }
}
