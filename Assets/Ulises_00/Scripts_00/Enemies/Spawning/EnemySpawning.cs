using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteSpawning
{
    public class EnemySpawning : MonoBehaviour
    {

        public GameObject Enemigo_1;
        public GameObject Enemigo_2;
        public GameObject Enemigo_3;
        public GameObject Enemigo_4;

       public Transform _spawnPoint1;
        public Transform _spawnPoint2;
        public Transform _spawnPoint3;
        public Transform _spawnPoint4;

        // Use this for initialization
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Spawning()
        {
            Instantiate(Enemigo_1, _spawnPoint1.position, _spawnPoint1.rotation);
        }

        public void SpawningTwo()
        {
            Instantiate(Enemigo_2, _spawnPoint2.position, _spawnPoint2.rotation);
        }

        public void SpawningThree()
        {
            Instantiate(Enemigo_3, _spawnPoint3.position, _spawnPoint3.rotation);
        }

        public void SpawningFour()
        {
            Instantiate(Enemigo_4, _spawnPoint4.position, _spawnPoint4.rotation);
        }
    }
}
