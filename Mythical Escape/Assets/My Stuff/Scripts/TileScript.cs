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

    public Vector3 winPos()
    {
        return v3WinPos;
    }

    public bool IsWinPos()
    {
        return (transform.position - v3WinPos).magnitude < 0.01;
    }
}
