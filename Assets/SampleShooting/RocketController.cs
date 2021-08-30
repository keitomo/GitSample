using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){

    }

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            transform.Translate(-0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            transform.Translate(0.02f,0,0);
        }
        if (Input.GetKeyDown (KeyCode.Space)){
            Instantiate(bulletPrefab,transform.position,Quaternion.identity);
        }

    }
}
