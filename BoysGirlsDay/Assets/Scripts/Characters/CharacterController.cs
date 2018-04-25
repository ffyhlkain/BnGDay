using DragonBones;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private UnityArmatureComponent character;

    private void OnGUI()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A pressed");
            if (character != null) character.animation.Play("idle");
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("S pressed");
            if (character != null) character.animation.Play("idle");
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D pressed");
            if (character != null) character.animation.Play("idle");
        }
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("W pressed");
            if (character != null) character.animation.Play("idle");
        }
    }
}