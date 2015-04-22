using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour
{
    public Transform transWin;
    private Vector3 v3WinPos;

    void Awake()
    {
        v3WinPos = transWin.position;
    }

    public bool IsWinPos()
    {
        return (transform.position - v3WinPos).magnitude < 0.01;
    }
}
