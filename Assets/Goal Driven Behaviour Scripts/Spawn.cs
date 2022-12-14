using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPatients;

    public GameObject janitorPrefab;
    public int numJanitors;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numPatients; i++)
        {
            Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        }

        for (int i = 0; i < numJanitors; i++)
        {
            Instantiate(janitorPrefab, this.transform.position, Quaternion.identity);
        }

        Invoke("SpawnPatient", 1);
        Invoke("SpawnJanitors", 1);
    }

    void SpawnPatient()
    {
        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        Invoke("SpawnPatient", Random.Range(20, 30));
    }

    void SpawnJanitors()
    {
        Instantiate(janitorPrefab, this.transform.position, Quaternion.identity);
        Invoke("SpawnJanitors", Random.Range(60, 70));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
