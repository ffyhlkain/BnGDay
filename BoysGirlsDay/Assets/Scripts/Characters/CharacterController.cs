using UnityEngine;

public class CharacterController : MonoBehaviour 
{


    private void OnGUI()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A pressed");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D pressed");
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W pressed");
        }
    }
}