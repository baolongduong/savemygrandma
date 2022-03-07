using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDefinition : MonoBehaviour
{
    int startAt;
    int directionMove;
    public Transform[] listPoint;
    public void OnDrawGizmos()
    {
        if (listPoint == null || listPoint.Length < 5)
            return;

        for (int i = 1; i < listPoint.Length; i++)
        {
            Gizmos.DrawLine(listPoint[i - 1].position, listPoint[i].position);
        }
    }
    public Transform getPointAt(int p)
    {
        return listPoint[p];
    }
    public Transform getNextPoint()
    {
        if (startAt == 0)
            directionMove = 1;
        else if (startAt == listPoint.Length - 1)
            directionMove = -1;

        startAt += directionMove;
        return listPoint[startAt];
    }
}


