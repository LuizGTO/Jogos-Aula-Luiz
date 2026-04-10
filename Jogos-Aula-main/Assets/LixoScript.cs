using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixoScript : MonoBehaviour
{
    public float maximumX;
    public float fixedY;
    public float fixedZ;
    public float timer;
    public GameObject Lixo; 
    public float MaxPoints;
    public int points = 0;
    
    void Start(){
        StartCoroutine(SpawnRoutine());    
    }

    IEnumerator SpawnRoutine(){
        while (points<MaxPoints){
            instantiate(Lixo, new Vector3(Random.Range(-maximumX, maximumX+1), fixedY, fixedZ), Quatternion.identity);
            yield return new WaitForSeconds(timer);
        }
    }
    
    void Update(){
        
    }
}
