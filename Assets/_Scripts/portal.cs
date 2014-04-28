using UnityEngine;
using System.Collections;

public class portal : MonoBehaviour {

    public string nomeLevel;

	void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(nomeLevel);
	}
}
