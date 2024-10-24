namespace AXitUnityTemplate.MVC.Interface
{
    public interface IView<TModel, TController>
    where TModel : IModel
    where TController : IController<TModel>
    {
        public TModel      Model      { get; set; }
        public TController Controller { get; set; }
    }
}