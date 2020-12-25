using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Assets
{
   public class Restart:MonoBehaviour
    {
        [SerializeField] Button restart;

         void Start()
        {
            restart.onClick.AddListener(() => Restart1());
        }

        void Restart1()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
