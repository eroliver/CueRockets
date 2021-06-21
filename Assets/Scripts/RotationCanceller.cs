using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCanceller : MonoBehaviour
{
    Transform parentTransform;
    // Start is called before the first frame update
    void Start()
    {
        parentTransform = this.GetComponentInParent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        this.transform.rotation = Quaternion.Euler(0f, 0f, gameObject.transform.rotation.z * -1f);
    }
}
