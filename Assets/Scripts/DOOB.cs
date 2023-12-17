using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOOB : MonoBehaviour
{
    // Destroy all objects reaching out-of-bounds
    // Start is called before the first frame update
    private float topOfScene = 60.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
    }
}
