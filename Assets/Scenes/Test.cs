using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] array = {1, 2, 3, 4, 5, };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i < array.Length; i--)
        {
            if (i >= 0)
            {
                Debug.Log(array[i]);
            }
        }
    }
}