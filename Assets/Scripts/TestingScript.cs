
using UnityEngine;
using System.Collections.Generic;

namespace OnurNamespace
{
    
{

  

    int number = 1;

    int[] numbers = new int[3];

    List<int> numbersList = new List <int>();

        

    void Start()

    {
    //     numbers[0] = 5;
    //     numbers[1] = 8;
    //     numbers[2] = 11;

    //     for( int i = 0;  i < numbers.Length; i++ )
    // {
    //     Debug.Log(numbers[i]); 
    // }

    numbersList.Add(10);
    numbersList.Add(15);
    numbersList.Add(20);
    Printlist();

    numbersList.Remove(20);
      Printlist();
    numbersList.Clear();
    for (int i=0; i < numbersList.Count; i++)
    {
        Debug.Log(numbersList[i]);
    }

    void Printlist  ()
    {
        // for (int i=0; i< numbersList.Count; i++)
        //         {   

        //     Debug.Log (numbersList[i]);
                    // }
    foreach (int myNumber in numbersList)
    {
        Debug.Log(myNumber);
    }
    
        
    
         Debug.Log ("--------------");
    }

}
}
}

public class TestingScript : MonoBehaviour
