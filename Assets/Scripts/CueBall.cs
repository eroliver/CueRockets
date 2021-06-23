using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour
{
    private float maxLifeSpan;

    // Start is called before the first frame update
    void Start()
    {
        maxLifeSpan = 5f;
        Destroy(gameObject, maxLifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
