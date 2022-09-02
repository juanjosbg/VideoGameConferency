using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFondo : MonoBehaviour
{

    [SerializeField] private Vector2 velMovimiento;

    private Vector2 offset;
    private Material material; 

private void Awake()
{
    material = GetComponent<SpriteRenderer>().material;
}

private void Update()
{
    offset = velMovimiento * Time.deltaTime;
    material.mainTextureOffset += offset;
}

  
}
