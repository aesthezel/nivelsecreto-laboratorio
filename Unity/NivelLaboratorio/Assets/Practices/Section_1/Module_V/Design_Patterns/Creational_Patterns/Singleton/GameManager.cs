using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        public void Init()
        {
            Debug.Log("Soy el " + gameObject.name + " y esto en el area de DontDestroy...");
        }

    }
}

