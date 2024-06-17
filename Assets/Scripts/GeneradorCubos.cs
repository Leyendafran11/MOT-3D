using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCubos : MonoBehaviour
{

    public GameObject Cubo;
    public int numeroCubos = 1;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < numeroCubos; i++)
        {
            Vector3 posicion = transform.position + new Vector3(Random.Range(-3,3), 0, Random.Range(-3, 3));

            Instantiate(Cubo,posicion,Quaternion.identity);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
