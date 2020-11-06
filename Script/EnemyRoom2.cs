using UnityEngine;

public class EnemyRoom2 : MonoBehaviour
{
    public float min = 7.59f;
    public float max = 10.59f;

    public GameObject ExplosionVFX;
    public float Power = 10f;
    public float ExplosionSpeed = 3f;
    public float Radius = 5f;

    // Use this for initialization
    void Start()
    {

        min = transform.position.z;
        max = transform.position.z + 3;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 1.5f, max - min) + min);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Missile"))
        {
            //Rigidbody plRgb = collision.gameObject.GetComponent<Rigidbody>();
            Explode();
        }
    }

    public void Explode()
    {
        GameObject explosion = Instantiate(ExplosionVFX, transform.position, Quaternion.identity); 

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(Power, transform.position, Radius);

        Destroy(explosion, 2f);
        Destroy(this.gameObject);
        
    }
}
