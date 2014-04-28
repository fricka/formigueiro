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

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "folha")
        {
            pegouFolha = true;
        }

        if (other.tag == "ninho")
        {
            if (pegouFolha)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            
            pegouFolha = false;
            
        }
    }
}
