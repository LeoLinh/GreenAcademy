using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    [SerializeField] int[] num;

    void DaoGiaTri(ref int a,ref int b)
    {
        int c = a;
        a = b;
        b = c; 
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = i + 1; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                    DaoGiaTri(ref num[i], ref num[j]);
                }
            }
        }

        string numStr = "";
        for (int i = 0; i < num.Length; i++)
        {
            numStr += num[i] + " ";
        }
        Debug.Log(numStr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
