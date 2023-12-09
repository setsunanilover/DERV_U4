using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{

    [SerializeField]
    Color c;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = c;
    }
}
