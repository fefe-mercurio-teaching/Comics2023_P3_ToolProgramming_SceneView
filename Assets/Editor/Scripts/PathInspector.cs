using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Path))]
public class PathInspector : Editor
{
    private void OnSceneGUI()
    {
        Path path = (Path)target;

        Vector3[] nodes = new Vector3[path.nodes.Length];
        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i] = path.nodes[i].position;
            Handles.Label(path.nodes[i].position, path.nodes[i].name);
        }

        Handles.color = Color.yellow;
        Handles.DrawPolyLine(nodes);
    }
}
