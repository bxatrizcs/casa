using System.Collections;
using System.Collections.Generic;
using UnityEngine; //inclui a biblioteca da unity

public class Movimento : MonoBehaviour
{
    float _velocidadeFrente; //cria variavel de velocidade
    float _velocidadeTras;
    float _velocidadeGirar;

    void Start()
    {
        _velocidadeFrente = 10; //define o valor de cada variavel
        _velocidadeTras = 5;
        _velocidadeGirar = 60;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("uparrow"))
        {
            transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
        }
        if (Input.GetKey("downarrow"))
        {
            transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
        }
        if (Input.GetKey("leftarrow"))
        {
            transform.Rotate(0, (-_velocidadeGirar * Time.deltaTime), 0);
        }
        if (Input.GetKey("rightarrow"))
        {
            transform.Rotate(0, (_velocidadeGirar * Time.deltaTime), 0);
        }
    }
}