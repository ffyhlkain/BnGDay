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
            if (character != null) character.animation.Play("leftAttack", 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (character != null) character.animation.Play("idle");
            //Debug.Log("S pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D pressed");
            if (character != null) character.animation.Play("rightAttack", 1);
        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    //Debug.Log("W pressed");
        //    if (character != null) character.animation.Play("idle");
        //}
    }

    private void Update()
    {
        if (character != null && character.animation != null)
        {
            if (!character.animation.isPlaying)
            {
                character.animation.Play("idle");
            }
        }
    }
}