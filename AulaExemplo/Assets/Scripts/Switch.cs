using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    private string Inimigo;

    // Start is called before the first frame update
    void Start()
    {
        Inimigo = "Dragão";    
    }

    // Update is called once per frame
    void Update()
    {
        switch (Inimigo)
        {
            case "Dragão":
                print("Enfrente o Dragão");
                break;
            case "Tigre":
                print("Enfrente o Tigre");
                break;
            case "Leão":
                print("Enfrente o Leão");
                break;
            default:
                print("Inimigo inesperado");
                break;
        }
    }
}
