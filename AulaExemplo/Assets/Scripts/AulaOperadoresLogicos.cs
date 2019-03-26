using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaOperadoresLogicos : MonoBehaviour
{

    private int A, B, C, D;

    // Start is called before the first frame update
    void Start()
    {

        A = 5;
        B = 10;
        C = 10;
        D = 25;

        print(A <= B && C > D);

        print(A <= B || C > D);

        print(!(A <= B));


        //OPERADOR && (and - e)
        print(A < B && C <= D);
        print(A < B && C >= D);
        print(A > B && C <= D);
        print(A > B && C >= D);

        //OPERADOR || (or - ou)
        print(A < B || C <= D);
        print(A < B || C >= D);
        print(A > B || C <= D);
        print(A > B || C >= D);

        //OPERADOR ! (not - não)
        print(!(A < B));
        print(!(C > D));
        print(!(A <= D));
        print(!(A > B));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
