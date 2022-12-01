using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Vector3Path))]
public class Vector3PathInspector : Editor
{
    private void OnSceneGUI()
    {
        Vector3Path vector3Path = (Vector3Path)target;

        for (int i = 0; i < vector3Path.nodes.Length; i++)
        {
            vector3Path.nodes[i] = 
                Handles.PositionHandle(vector3Path.nodes[i], Quaternion.identity);
        }
        
        Handles.DrawPolyLine(vector3Path.nodes);
        
        Handles.BeginGUI();
        EditorGUILayout.LabelField("Nodi percorso", vector3Path.nodes.Length.ToString());
        GUILayout.Button("Clicca qui");

        GUI.Button(new(100f, 100f, 200f, 50f), "Pulsante volante");
        
        Handles.EndGUI();
    }
}
