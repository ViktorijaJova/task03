using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] Button start;
    public GameObject block;
    public GameObject sphere;
    public float radius = 50;

    void Start()
    {
        start.onClick.AddListener(() => OnClick());
        start.onClick.AddListener(() => OnClick2());
    }


    void OnClick()
    {
        for (int x = 0; x < Random.Range(1, 10); x++)
        {
            for (int y = 0; y < Random.Range(1, 10); y++)
            {
                for (int z = 0; z < Random.Range(1, 10); z++)
                {

                    GameObject go = Instantiate(block, new Vector3(x, y, z), Quaternion.identity) as GameObject;
                    go.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                    //   Instantiate(block, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }     
        }



    void OnClick2()
    {

        for (int x = 0; x < Random.Range(1, 10); x++)
        {
            for (int y = 0; y < Random.Range(1, 10); y++)
            {
                for (int z = 0; z < Random.Range(1, 10); z++)
                {
                    GameObject go = Instantiate(sphere, new Vector3(x, y, z), Quaternion.identity) as GameObject;
                    go.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                   // Instantiate(sphere, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }
    }



}

