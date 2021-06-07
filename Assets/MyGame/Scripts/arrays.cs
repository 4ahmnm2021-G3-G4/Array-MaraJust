using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // create arrays

        string[] array1 = { "bla", "passwort", "username", "lieblingstier" };
        float[] array2 = new float[4];
        int[] array3 = { 1, 2, 3, 4 };
        float[] array4 = new float[] { 1f, 2f, 3f, 4f };


        // values in Debug

        Debug.Log(" << array1 >> ");
        for (int j = 0; j < array1.Length; j++)
        {
            Debug.Log(array1[j].ToString());
        }
        Debug.Log("Length of array1 is " + array1.Length);

        Debug.Log(" << array2 >> ");
        for (int a = 0; a < array2.Length; a++)
        {
            Debug.Log(array2[a]);
        }
        Debug.Log("Length of array2 is " + array2.Length);

        Debug.Log(" << array3 >> ");
        for (int b = 0; b < array3.Length; b++)
        {
            Debug.Log(array3[b]);
        }
        Debug.Log("Length of array3 is " + array3.Length);

        Debug.Log(" << array4 >> ");
        for (int c = 0; c < array4.Length; c++)
        {
            Debug.Log(array4[c]);
        }
        Debug.Log("Length of array4 is " + array4.Length);



        // Change Values from array1 and array4

        array1.SetValue("bubu", 2);
        Debug.Log("New value of array1 is " + "(" + array1[0] + ", " + array1[1] + ", " + array1[2] + ", " + array1[3] + ")");

        array4.SetValue(0, 0);
        Debug.Log("New value of array4 is " + "(" + array4[0] + ", " + array4[1] + ", " + array4[2] + ", " + array4[3] + ")");


        GameObject[] arrayImages = GameObject.FindGameObjectsWithTag("RedImage");

        arrayImages[0].gameObject.GetComponent<Image>().color = Color.blue;
    }

}

 