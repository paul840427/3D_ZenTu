using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    private Animator animator;
    float x = 1f;
    float y = 1f;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playAnimation(Vector3 movement)
    {
        Debug.Log(movement);
        animator.SetFloat("verX", x);
        animator.SetFloat("verY", y);
    }
}
