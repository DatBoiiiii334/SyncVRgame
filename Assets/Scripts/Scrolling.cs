using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public GameObject Road1;
    public int roadPos;
    public float speed;

    public void Update(){
        gameObject.transform.position -= transform.forward * Time.deltaTime * speed;
    }
    
    private void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
            Road1.transform.position = new Vector3(transform.position.x,transform.position.y,roadPos);
        }
    }

    
}
