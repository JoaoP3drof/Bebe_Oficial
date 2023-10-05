using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUp : MonoBehaviour
{

    [SerializeField]

    private float _velocidade = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("O Objeto " + name + "colidiu com o objeto" + other.name);

        if (other.name == "Player")
        {

            Player player = other.GetComponent<Player>();

            player.possoDarDisparoTriplo = true;

            Destroy(this.gameObject);

        }
    }
}
