using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameplay : MonoBehaviour
{

	public float waitTime = 1.0f;

    PlayerMouseLook playerLook;
    PlayerMovementController playerMove;

	// Start is called before the first frame update
	void Awake()
    {
     
        playerLook = GetComponent<PlayerMouseLook>();   
        playerMove = GetComponent<PlayerMovementController>();
        
    }

    // Update is called once per frame
    IEnumerator Start()
    {

       // playerLook.enabled = false;
        //playerMove.enabled = false;

        yield return new WaitForSecondsRealtime(waitTime);

       // playerLook.enabled = true;
        //playerMove.enabled = true;
        
    }
}
