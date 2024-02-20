using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private Vector3 _zoneSize;
    [SerializeField] private GameObject _cubePrefab;

    float _valeurAppelerMethode;
    float _valeurRepeterTemps;

    void Start()
    {
        _valeurAppelerMethode = Random.Range(1,3);
        _valeurRepeterTemps = Random.Range(2,4);

        InvokeRepeating("CreerCube",_valeurAppelerMethode,_valeurRepeterTemps);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnDrawGizmos(){

        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, _zoneSize);

    }

    void CreerCube(){

        GameObject nouveauCube;
        nouveauCube = Instantiate(_cubePrefab);

        float posAleatoireX = Random.Range(transform.position.x - _zoneSize.x/2 , transform.position.x + _zoneSize.x/2);
        float posAleatoireY = Random.Range(transform.position.y - _zoneSize.y/2 , transform.position.y + _zoneSize.y/2);
        float posAleatoireZ = Random.Range(transform.position.z - _zoneSize.z/2 , transform.position.z + _zoneSize.z/2);

        nouveauCube.transform.position = new Vector3(posAleatoireX, posAleatoireY, posAleatoireZ);

    }
}
