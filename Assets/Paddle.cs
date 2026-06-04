using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour {
    public float speed = 10f;

    void Update() {
        float h = 0;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            h = -1;

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            h = 1;

        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }
}