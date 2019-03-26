using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaOperadores : MonoBehaviour
{

    private     int     vidaMaximaJogador, vidaAtualJogador, dano, porcaoVida;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualJogador = 100 + 50;
        print(vidaAtualJogador);

        vidaMaximaJogador = 100;
        vidaAtualJogador = vidaMaximaJogador;
        print(vidaAtualJogador);
        dano = 15;
        vidaAtualJogador = vidaAtualJogador - dano;
        porcaoVida = 10;
        vidaAtualJogador += porcaoVida;
        print(vidaAtualJogador);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
