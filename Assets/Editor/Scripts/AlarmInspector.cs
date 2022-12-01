using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Alarm))]
public class AlarmInspector : Editor
{
    private void OnSceneGUI()
    {
        Alarm alarm = (Alarm)target;

        Handles.color = new(1f, 0f, 0f, .2f);
        Handles.DrawSolidDisc(alarm.transform.position, alarm.transform.up, alarm.radius);
    }
}
