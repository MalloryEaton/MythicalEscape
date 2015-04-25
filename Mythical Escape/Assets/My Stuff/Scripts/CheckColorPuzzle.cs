using UnityEngine;
using System.Collections;

public class CheckColorPuzzle : MonoBehaviour 
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    public Color[] colors;

    private Renderer renderer1;
    private Renderer renderer2;
    private Renderer renderer3;

    void Start()
    {
        renderer1 = cube1.GetComponent<Renderer>();
        renderer2 = cube2.GetComponent<Renderer>();
        renderer3 = cube3.GetComponent<Renderer>();
    }

	public bool checkColors()
    {
        if(renderer1.material.color != colors[0])
        {
            return false;
        }
        if (renderer2.material.color != colors[1])
        {
            return false;
        }
        if (renderer3.material.color != colors[2])
        {
            return false;
        }
        return true;
    }
}
