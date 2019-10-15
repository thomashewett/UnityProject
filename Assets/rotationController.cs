﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationController : MonoBehaviour
{
    public float SENS_HOR = 3.0F;
    public float SENS_VER = 2.0F;
    GameObject cannon;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cannon = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var mouseMove = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseMove = Vector2.Scale(mouseMove, new Vector2(SENS_HOR, SENS_VER));
        cannon.transform.Rotate(0, mouseMove.x, 0);
        transform.Rotate(-mouseMove.y, 0, 0);

        if(Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
