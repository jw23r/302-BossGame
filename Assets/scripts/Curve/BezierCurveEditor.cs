using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BezierCurve))]
public class BezierCurveEditor : Editor
{

    int selectedIndex = -1;

    override public void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        // add more to it...
        if (GUILayout.Button("add point"))
        {
            (target as BezierCurve).AddPoint();
            EditorUtility.SetDirty(target);
        }
     
    }

    void OnSceneGUI()
    {
        BezierCurve curve = (BezierCurve)target;



        for (int i = 0; i < curve.worldPoints.Length; i++)
        {
            if (Handles.Button(curve.worldPoints[i], Quaternion.identity, .1f, .05f, Handles.CubeHandleCap))
            {
                selectedIndex = i;
            }
        }

        if (selectedIndex >= 0)
        {

            EditorGUI.BeginChangeCheck();
            Vector3 newPos = Handles.PositionHandle(curve.worldPoints[selectedIndex], Quaternion.identity);

            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(target, "Changed path points");
                curve.points[selectedIndex] = curve.transform.InverseTransformPoint(newPos);
                curve.CacheSplineData();
            }
        }

    }

}