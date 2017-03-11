﻿/*==== FieldView.cs ====================================================
 * FieldView is an utility to draw fields
 * 
 * Author: Victor Le aka "Coac"
 * Repository : https://github.com/Coac/debug-scene-ui
 * =========================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

public class FieldView
{
    public static Vector3 displayVector3(Vector3 vector)
    {
        GUILayout.BeginHorizontal();

        vector = new Vector3(
            float.Parse(GUILayout.TextField(vector.x.ToString())), 
            float.Parse(GUILayout.TextField(vector.y.ToString())),
            float.Parse(GUILayout.TextField(vector.z.ToString()))
            );

        GUILayout.EndHorizontal();

        return vector;
    }

    public static double displayDouble(double doubl)
    {
        return double.Parse(GUILayout.TextField(doubl.ToString()));
    }

    public static float displayFloat(float input)
    {
        return float.Parse(GUILayout.TextField(input.ToString()));
    }

    public static int displayInt(int input)
    {
        return int.Parse(GUILayout.TextField(input.ToString()));
    }

    public static bool displayBool(bool input)
    {
        return GUILayout.Toggle(input, "");
    }
}