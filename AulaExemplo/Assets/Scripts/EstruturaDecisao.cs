using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaDecisao : MonoBehaviour
{

    public uint vidaJogador;
    public bool podeAtacar;
    // Start is called before the first frame update
    void Start()
    {
        vidaJogador = 100;
        podeAtacar = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (vidaJogador > 0)
        {
            podeAtacar = true;
        }
        else
        {
            podeAtacar = false;
        }
        print(podeAtacar);
    }
}
