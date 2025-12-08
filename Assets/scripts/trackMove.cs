using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour
{
    public float speed;
    Vector2 poscarretera;



    void Start()
    {
        
    }

    void Update()
    {
	poscarretera = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = poscarretera;
    }
}
