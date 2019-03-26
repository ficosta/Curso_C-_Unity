using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaExemplo : MonoBehaviour
{
    //Variaveis
    private int vidaJogador, coracoes;
    private string nomeJogador;
    private float dano;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        coracoes = 5;
        print(coracoes);

        vidaJogador = 10;
        print(vidaJogador);

        nomeJogador = "FelipeIasi";
        print(nomeJogador);

        dano = 1.5f;
        print(dano);

        isGameOver = false;
        print(isGameOver);

        print(String.Format("O nome do jogador: {0}", nomeJogador));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
