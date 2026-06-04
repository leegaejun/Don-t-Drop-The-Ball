using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 4f;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();

        // 랜덤 방향 (위쪽 기준)
        float x = Random.Range(-1f, 1f);
        float y = 1f;

        Vector2 dir = new Vector2(x, y).normalized;

        rb.linearVelocity = dir * speed;
    }
}