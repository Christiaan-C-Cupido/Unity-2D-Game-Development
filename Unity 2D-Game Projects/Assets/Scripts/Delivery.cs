using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1.0f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, 1f);
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject);
        }

    }
}

