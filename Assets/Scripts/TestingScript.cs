
using UnityEngine;

public class TestingScript : MonoBehaviour

{

  

    int number = 1;

    int[] numbers = new int[3];

    void Start()

    {
        numbers[0] = 5;
        numbers[1] = 8;
        numbers[2] = 11;

        for( int i = 0;  i < numbers.Length; i++ )
    {
        Debug.Log(numbers[i]); 
    }

}
}