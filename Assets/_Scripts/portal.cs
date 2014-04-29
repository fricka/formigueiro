using UnityEngine;
using System.Collections;

public class portal : MonoBehaviour {

    public string nomeLevel;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "portal")
            Application.LoadLevel(nomeLevel);

        if (other.tag == "portalVolta")
        {
            if (GetComponent<capturaAlimento>().pegouDoce)
            {
                Application.LoadLevel(nomeLevel+"2");
            }
            else if (GetComponent<capturaAlimento>().pegouBanana)
            {
                Application.LoadLevel(nomeLevel + "1");
            }
            else
            {
                Application.LoadLevel(nomeLevel + "0");
            }
        }
	}
}
