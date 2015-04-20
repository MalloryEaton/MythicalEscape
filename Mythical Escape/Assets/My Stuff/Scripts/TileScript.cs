using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour
{
    public Transform transHome;
    private Vector3 v3HomePos;

    void Start()
    {
        v3HomePos = transHome.position;
    }

    public bool IsHome()
    {
        return (transform.position - v3HomePos).magnitude < 0.01;
    }
}
