using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;
    public GameObject particlePrefab;

    public PickerUpper player;

    public Transform Spawnpoint;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Pickup"))
        {
            GameObject.Instantiate(particlePrefab, collision.collider.gameObject.transform.position, Quaternion.identity); // Makes a copy of the gmaeObject. Quaeternion.identiy means rotation that does not do anything.

            GameObject.Destroy(collision.collider.gameObject); // Destroy cube

            count = count + 1;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("Pickup Count: " + count);
        }
    }
}
