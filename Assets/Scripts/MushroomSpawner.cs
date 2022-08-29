using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject objPrefab;

    public List<GameObject> pooledMushroom;
    public int PoolLimit;

    private bool _done = false;
    public GameObject pos;

    private void Start()
    {
        pooledMushroom = new List<GameObject>();
        GameObject mush;
        for(int i = 0 ; i < PoolLimit ; i++)
        {
            mush = Instantiate(objPrefab);
            mush.SetActive(false);
            pooledMushroom.Add(mush);
        }
    }

    public GameObject GetPooledMushroom()
    {
        for(int i = 0; i < PoolLimit; i++)
        {
            if(!pooledMushroom[i].activeInHierarchy)
            {
                return pooledMushroom[i];
            }
        }
        return null;
    }

    void FixedUpdate()
    {
        GameObject mushroom = GetPooledMushroom();
        
        if (mushroom != null && _done == false)
        {
            mushroom.SetActive(true);
        }

        if (mushroom.activeInHierarchy)
        {
            StartCoroutine("DespawnMushroom", mushroom);
        }
    }

    IEnumerator DespawnMushroom(GameObject mush)
    {
        yield return new WaitForSeconds(3.0f);
        mush.SetActive(false);
        _done = true;
    }
}
