using SignIn.Client.Data;

namespace SignIn.Client.Pages
{
    public partial class Index
    {
        public Student? Model { get; set; } = null!;

        protected override void OnInitialized() => Model ??= new();

        private void Submit()
        {
            if (Model != null)
            {
                if (Model!.Firstname == "Patrick")
                {
                    if (Model!.Lastname == "Ferguson")
                    {
                        if (Model!.StudentId == "10203010")
                        {
                        }
                    }
                }
            }
        }
    }
}
