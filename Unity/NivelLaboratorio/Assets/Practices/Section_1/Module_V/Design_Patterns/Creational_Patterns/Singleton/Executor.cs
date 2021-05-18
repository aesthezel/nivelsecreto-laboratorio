using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Singleton
{
    public class Executor : MonoBehaviour
    {
        public void CallSceneManager()
        {
            SceneManager.Instance.Init();
        }

        public void CallGameManager()
        {
            GameManager.Instance.Init();
        }
    }

}
