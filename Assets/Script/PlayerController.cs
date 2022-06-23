using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public KeyCode keyRight;
    public KeyCode keyLeft;
    public Animator _animation;
    void Start()
    {
        _animation.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }
    private void Move(int x)
    {
        Vector2 vector2 = new Vector2(1, 0);
        transform.Translate(x*vector2 * Speed * Time.deltaTime);
    }

    private void Controller()
    {
        if (Input.GetKey(keyRight))
        {
            Move(1);
            _animation.Play("Run");
        }
        else if(Input.GetKeyUp(keyRight))
        {
            _animation.Play("Idle");
        }
        if (Input.GetKey(keyLeft))
        {
            Move(-1);
            _animation.Play("Run");
        }
        else if (Input.GetKeyUp(keyLeft))
        {
            _animation.Play("Idle");
        }
    }
}
