using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rb;
    private Vector2 _valeurRecue;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Bouger();
    }

    void Bouger(){
        
        float _valeurX = _valeurRecue.x;
        float _valeurY = _valeurRecue.y;
        _rb.velocity = new Vector3(_valeurX,_valeurY,0);
    }

    public void OnMove(InputValue value){
        _valeurRecue = value.Get<Vector2>();
    }
}
