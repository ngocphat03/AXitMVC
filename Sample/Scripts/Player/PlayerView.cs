namespace AXitUnityTemplate.MVC.Sample.Scripts.Player
{
    using UnityEngine;
    using AXitUnityTemplate.MVC.Base;
    using AXitUnityTemplate.MVC.Sample.Scripts.Manager;
    using AXitUnityTemplate.MVC.Sample.Scripts.Elements;

    public class PlayerView : BaseView<PlayerModel, PlayerController>
    {
        protected override void Init()
        {
            this.Model.DefaultPosition = this.transform.position;
            GameManager.Instance.OnResetGame += () =>
            {
                if (this.Model.MoveForwardCoroutine != null) this.StopCoroutine(this.Model.MoveForwardCoroutine);
                this.Controller.OnResetPositionView(this.transform);
                this.Model.IsMoving = false;
            };
        }

        private void Update()
        {
            // Rotate the player
            if (!this.Model.IsMoving) this.Controller.Rotate(this.transform);

            // Move the player
            if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
            {
                if (this.Model.MoveForwardCoroutine != null) this.StopCoroutine(this.Model.MoveForwardCoroutine);

                this.Model.MoveForwardCoroutine = this.StartCoroutine(this.Controller.MoveForwardCoroutine(this.transform));
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.TryGetComponent<BaseElements>(out var element))
            {
                this.Controller.PlayerTriggerWith(element.GetType());
            }
        }
    }
}