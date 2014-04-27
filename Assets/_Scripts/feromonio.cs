using UnityEngine;
using System.Collections;

public class feromonio : MonoBehaviour {

    public GameObject fumacaFeromonio;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            Instantiate(fumacaFeromonio, transform.position, transform.rotation);
        }
	
	}
}
