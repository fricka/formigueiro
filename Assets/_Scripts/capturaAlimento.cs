using UnityEngine;
using System.Collections;

public class capturaAlimento : MonoBehaviour {

    public bool pegouFolha = false;
    public bool pegouBanana = false;
    public bool pegouDoce = false;

    public GameObject folha, banana, doce;

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

        if (pegouBanana)
        {
            banana.renderer.enabled = true;
        }
        else
        {
            banana.renderer.enabled = false;
        }

        if (pegouDoce)
        {
            doce.renderer.enabled = true;
        }
        else
        {
            doce.renderer.enabled = false;
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
            if (pegouFolha || pegouBanana || pegouDoce)
            {
                GetComponent<instru>().chegouComida();
            }
            
            pegouFolha = false;
            pegouBanana = false;
            pegouDoce = false;            
        }

        if (other.gameObject.tag == "doce")
        {
            Destroy(other.gameObject);
            pegouDoce = true;
            GetComponent<instru>().pegouComida();
        }

        if (other.gameObject.tag == "banana")
        {
            Destroy(other.gameObject);
            pegouBanana = true;
            GetComponent<instru>().pegouComida();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        

    }
}
