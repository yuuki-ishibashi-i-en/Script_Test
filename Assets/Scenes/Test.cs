using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int MP = 53;

    public void Magic()
    {
        if (this.MP >= 5)
        {
            this.MP -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.MP);
        }

        else if (this.MP < 5)
        {
            Debug.Log("MPが足りない!");
        }
    }

}

public class Test : MonoBehaviour
{
    Boss boss=new Boss();


    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5, };

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

        Debug.Log("ここから発展課題");

        for (int i = 0; i <= 11; i++)
        {
            boss.Magic();
        }
    }
}