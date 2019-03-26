using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vetores : MonoBehaviour
{

    [SerializeField]
    private string[] Inimigos1 = { "Dragão", "Tigre", "Leao", "Cobra" };
    // Start is called before the first frame update
    public uint indice = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indice >= Inimigos1.Length)
        {
            print("Nao existem tantos inimigos assim");
        }
        else
        {
            print(Inimigos1[indice]);
        }
    }
}
