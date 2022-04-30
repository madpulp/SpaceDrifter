using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySphereScript : MonoBehaviour
{

    [SerializeField] Vector3 _Rotation;
    [SerializeField] private float _Rspeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_Rotation * _Rspeed * Time.deltaTime);
    }
}
