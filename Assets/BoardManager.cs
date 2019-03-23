﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

    private const float tile_size = 1.0f;
    private const float tile_offset = 0.5f;

    private int selectionX = -1;
    private int selectionY = -1;

    private void Update()
    {

       // UpdateSelection();
        DrawChessBoard();
        //kljhkjhkjhk

    }


    //private void UpdateSelection()
    //{
    //    if (!Camera.main)
    //        return;

    //    RaycastHit hit;
    //    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,25.0f,LayerMask.GetMask("ChessPlane")))
    //    {
    //        selectionX = (int)hit.point.x;
    //        selectionY = (int)hit.point.z;
    //    }
    //    else
    //    {
    //        selectionX = -1;
    //        selectionY = -1;
    //    }
    //}

    private void DrawChessBoard()
    {
        Vector3 widthLine = Vector3.right * 8;
        Vector3 heigthLine = Vector3.forward * 8;

        for (int i = 0; i <=8; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + widthLine);
            for (int j = 0; j <= 8; j++)
            {

                start = Vector3.right * j;
                Debug.DrawLine(start, start + heigthLine);


            }


        }

        //Draw the selection
        //if (selectionX >= 0 && selectionY>=0)
        //{

        //    Debug.DrawLine(Vector3.forward * selectionY + Vector3.right * selectionX,
        //                   Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1));

        //}


    }

}
