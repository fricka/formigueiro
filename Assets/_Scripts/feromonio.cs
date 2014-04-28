using UnityEngine;
using System.Collections;

public class feromonio : MonoBehaviour {

    public GameObject fumacaFeromonio;
    public Transform lancaFeromonio;
    public int qtdeFeromonio = 100;
    public GUIText GUIferomonio;
    
	void Update () {

        if (Input.GetButtonDown("Fire1") && qtdeFeromonio > 0)
        {
            Instantiate(fumacaFeromonio, lancaFeromonio.position, lancaFeromonio.rotation);
            qtdeFeromonio--;
            GUIferomonio.text = qtdeFeromonio.ToString();
        }
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "feromonio")
        {
            Destroy(other.gameObject);
            qtdeFeromonio++;
            GUIferomonio.text = qtdeFeromonio.ToString();
        }
    }
}
