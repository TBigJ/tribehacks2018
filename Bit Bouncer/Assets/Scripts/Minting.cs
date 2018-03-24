using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minting : MonoBehaviour {

		public GameObject[] enemySpawn;
		public Transform enemyPrefab;
		public bool creating = true;

		void Update()
		{
		if (creating = true)
			{
				Debug.Log (creating);
				Instantiate(enemyPrefab, transform.position, transform.rotation);
				creating = false;
			}
		}
}
