using SignIn.Client.Data;

namespace SignIn.Client.Pages
{
    public partial class Index
    {
        public Student? Model { get; set; } = null!;

        protected override void OnInitialized() => Model ??= new();

        private void Submit()
        {
            Logger.LogInformation("Model.Username = {Username}", Model?.Username);
        }
    }
}
