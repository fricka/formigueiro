using UnityEngine;
using System.Collections;

public class instru : MonoBehaviour {

    public GUIText display;

	// Use this for initialization
	void Start () {
        StartCoroutine("Display");
	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "saida")
        {
            StartCoroutine("saida");
            Destroy(other.gameObject);
        }
	}

    IEnumerator saida()
    {
        display.text = "ants like to eat the leaves of trees";

        yield return new WaitForSeconds(5);

        display.text = "";
    }

    public void pegouComida()
    {
        StartCoroutine("comida");
    }

    public IEnumerator comida()
    {
        display.text = "bring the food back to the nest";

        yield return new WaitForSeconds(5);

        display.text = "";
    }

    public void chegouComida()
    {
        StartCoroutine("chegouFinal");
    }

    public IEnumerator chegouFinal()
    {
        display.text = "Congratulations!!!";

        yield return new WaitForSeconds(3);

        Application.LoadLevel(Application.loadedLevel);
    }

    IEnumerator Display()
    {

        yield return new WaitForSeconds(1);

        display.text = "follow the pheromone to find food";    
        
        yield return new WaitForSeconds(5);

        display.text = "bring the food back to the nest";

        yield return new WaitForSeconds(5);

        display.text = "you can release pheromones to mark their way";

        yield return new WaitForSeconds(5);

        display.text = "";

    }
}
