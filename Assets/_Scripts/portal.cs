using UnityEngine;
using System.Collections;

public class portal : MonoBehaviour {

    public string nomeLevel;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "portal")
            Application.LoadLevel(nomeLevel);
	}
}
