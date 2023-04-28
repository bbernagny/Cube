using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    [SerializeField] private float speed;
    public static Cube1 Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
