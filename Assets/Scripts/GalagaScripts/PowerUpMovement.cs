using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    public float speed = 4;

    public float powerUpTimer = 0, powerUpWait = 3;

    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        powerUpTimer += Time.deltaTime;
        if (powerUpTimer > powerUpWait)
        {
            powerUpTimer = 0;
            Instantiate(gameObject, transform.position - new Vector3(0, .5f, 0), Quaternion.identity);
        }
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GalagaPlayer"))
            Destroy(gameObject);
    }
}
