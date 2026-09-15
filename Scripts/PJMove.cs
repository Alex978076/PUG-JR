using UnityEngine;

public class PJMove : MonoBehaviour
{
    private float velocidade = 5.0f;

    public Rigidbody2D rb;

    Vector2 forçaPulo;

    int pulosUsados = 0;
    int maxPulos = 2;

    void Start()
    {
        forçaPulo = new Vector2(0.0f, 5.0f);
    }

    void Update()
    {
        float mX = Input.GetAxisRaw("Horizontal");

        rb.linearVelocityX = mX * velocidade;

        if (Input.GetKeyDown(KeyCode.Space) && pulosUsados < maxPulos)
        {
            rb.AddForce(forçaPulo, ForceMode2D.Impulse);

            pulosUsados++;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            pulosUsados = 0;
        }
    }
}