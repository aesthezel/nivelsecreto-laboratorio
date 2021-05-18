using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Singleton
{
    public class SceneManager : MonoBehaviour
    {
        public static SceneManager Instance;

        private void Awake() 
        {
            if(Instance == null)
                Instance = this;
            else if (Instance != null)
                Destroy(gameObject);
        }

        public void Init()
        {
            Debug.Log("Hola, soy el " + gameObject.name);
        }
    }

}
