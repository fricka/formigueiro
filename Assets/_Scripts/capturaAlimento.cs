using UnityEngine;
using System.Collections;

public class capturaAlimento : MonoBehaviour {

    public bool pegouFolha = false;
    public GameObject folha;

    void Update()
    {
        if (pegouFolha)
        {
            folha.renderer.enabled = true;
        }
        else
        {
            folha.renderer.enabled = false;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "folha")
        {
            pegouFolha = true;
            GetComponent<instru>().pegouComida();
        }

        if (other.tag == "ninho")
        {
            if (pegouFolha)
            {
                GetComponent<instru>().chegouComida();
            }
            
            pegouFolha = false;
            
        }
    }
}
