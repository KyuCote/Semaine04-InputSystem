using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesInterieurs : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]private GameObject _cubeDedans;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Sol")){
            _cubeDedans.SetActive(true);
        }
    }
}
