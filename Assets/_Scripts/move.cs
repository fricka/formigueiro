using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float velocidade, velocidadeRotacao;
    public bool gravidade;
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * velocidadeRotacao * Time.deltaTime;        
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

	}

    void FixedUpdate()
    {
        //if (!gravidade)
            rigidbody.AddRelativeForce(0, -20, 0);

    }

    void OnCollisionEnter(Collision collision)
    {
        gravidade = false;
        rigidbody.useGravity = false;

    }

    void OnCollisionExit(Collision collision)
    {
        gravidade = true;
        rigidbody.useGravity = true;

    }
}
