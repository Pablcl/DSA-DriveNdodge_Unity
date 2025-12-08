using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour
{
	public float carSpeed;
	Vector3 position;
	public float minPos;
	public float maxPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    //correccion bug salirse carretera

	position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
	if(position.x>maxPos){
		position.x=maxPos;
	}
	
	if(position.x<minPos){
		position.x=minPos;

}
	
	
	transform.position = position;
        
    }
}
