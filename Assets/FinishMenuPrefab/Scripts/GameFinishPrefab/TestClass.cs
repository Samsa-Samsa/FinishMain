using UnityEngine;

namespace FinishMenuPrefab.Scripts.GameFinishPrefab
{
    public class TestClass : MonoBehaviour
    {
        [SerializeField] private int myInt;
        private void Update()
        {
            if (myInt != 1) return;
            FinishGame.OnGameFinish.Invoke();
            myInt = 2;
            
        }
    }
}