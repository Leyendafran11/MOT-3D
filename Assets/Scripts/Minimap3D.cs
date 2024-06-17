using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEditor.Experimental.GraphView;

public class Minimap3D : MonoBehaviour
{
    //Seguimiento jugador
    [SerializeField] string tagFollow = "Player";
    Transform follow;
    [SerializeField] Vector3 offset;

   

    void Start()
    {
        //Seguimiento
        follow = GameObject.FindGameObjectWithTag(tagFollow).transform;
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(follow.position.x,transform.position.y,follow.position.z) + offset;
    }


   
}
