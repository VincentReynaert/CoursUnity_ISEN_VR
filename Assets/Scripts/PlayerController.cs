using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_speed);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalMove, 0, verticalMove).normalized * _speed * Time.deltaTime;
    }
}
