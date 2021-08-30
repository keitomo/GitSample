using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    void Start(){
        this.fallSpeed = 0.01f + 0.01F * Random.value;
        this.rotSpeed = 0.7f + 0.7f * Random.value;
    }

    void Update(){
        transform.Translate(0,-fallSpeed,0,Space.World);
        transform.Rotate(0,0,rotSpeed);

        if(transform.position.y<-5.5f){
            GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
            Destroy(gameObject);
        }
    }
}
