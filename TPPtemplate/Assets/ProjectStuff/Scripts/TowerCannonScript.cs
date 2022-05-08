using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCannonScript : MonoBehaviour
{

    
    public Transform cannonTarget;
    public float cannonTrackSpeed;

    
    void Update()
    {
         Vector3 direction = cannonTarget.position - transform.position;
         Quaternion rotation = Quaternion.LookRotation(direction);
          transform.rotation = Quaternion.Lerp(transform.rotation,rotation,cannonTrackSpeed*Time.deltaTime) ;
    }
}
