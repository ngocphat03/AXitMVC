namespace AXitUnityTemplate.MVC.Base
{
    using System;
    using UnityEngine;
    using AXitUnityTemplate.MVC.Interface;

    public abstract class BaseView<TModel, TController> : MonoBehaviour, IView<TModel, TController>
    where TModel : IModel
    where TController : class, IController<TModel>
    {
        public virtual TModel      Model      { get; set; }
        public virtual TController Controller { get; set; }

        private void Awake()
        {
            this.Controller       = Activator.CreateInstance<TController>();
            this.Controller.Model = this.Model = Activator.CreateInstance<TModel>();
            this.Init();
        }

        /// <summary>
        /// Alternative to Awake
        /// </summary>
        protected abstract void Init();
    }
}