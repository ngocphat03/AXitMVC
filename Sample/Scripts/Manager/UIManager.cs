namespace AXitUnityTemplate.MVC.Sample.Scripts.Manager
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;
    using System.Threading.Tasks;

    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Text statusGame;

        public static UIManager Instance { get; private set; }

        private void Awake() { UIManager.Instance = this; }

        public async void ChangeTextWithTime(string text, float time = 2f)
        {
            this.statusGame.text = text;
            await Task.Delay(TimeSpan.FromSeconds(time));
            this.statusGame.text = string.Empty;
        }
    }
}