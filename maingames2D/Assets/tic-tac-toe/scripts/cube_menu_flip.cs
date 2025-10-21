using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_menu_flip : MonoBehaviour
{
    public float speed_x = 0f;
    public float speed_y = 0f;
    public float speed_z = 1.0f;

    void Update()
    {
        transform.Rotate(speed_x, speed_y, speed_z);
    }
}
