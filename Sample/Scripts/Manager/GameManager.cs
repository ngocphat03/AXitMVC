namespace AXitUnityTemplate.MVC.Sample.Scripts.Manager
{
    using System;
    using UnityEngine;
    using System.Collections.Generic;
    using AXitUnityTemplate.MVC.Sample.Scripts.Elements;

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public event Action OnResetGame;

        private void Awake() { GameManager.Instance = this; }

        public void PlayerTriggerWith(Type type)
        {
            if (new List<Type> { typeof(GoalView), }.Contains(type))
            {
                this.OnResetGame?.Invoke();
                UIManager.Instance.ChangeTextWithTime($"Game Win");

                return;
            }

            if (new List<Type> { typeof(ThornView), typeof(WallView), }.Contains(type))
            {
                this.OnResetGame?.Invoke();
                UIManager.Instance.ChangeTextWithTime($"Game Over");
                return;
            }
        }
    }
}