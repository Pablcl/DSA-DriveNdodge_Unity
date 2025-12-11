using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour

{

    public GameObject car;
    public float maxPos = 1.1f;
    float timer;
    public float delayTimer = 1f;

   
    void Start()
    {

	timer = delayTimer;
        
    }

    
    void Update()
    {
	timer = timer - Time.deltaTime;
	if (timer <= 0){
 		Vector3 carPos = new Vector3(Random.Range(-1.1f, 1.1f), transform.position.y, transform.position.z);
		Instantiate (car, carPos, transform.rotation);
	   	timer = delayTimer;
	}
		
    }
}
