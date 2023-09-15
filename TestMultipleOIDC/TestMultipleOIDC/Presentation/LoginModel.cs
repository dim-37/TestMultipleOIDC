namespace TestMultipleOIDC.Presentation
{
    public partial record LoginModel(INavigator Navigator, IAuthenticationService Authentication)
    {
        public string Title { get; } = "Login";


        public async ValueTask Login(CancellationToken token)
        {
            var success = await Authentication.LoginAsync(provider : "EmptyAuthenticationEndpoint");
            if (success)
            {
                await Navigator.NavigateViewModelAsync<MainModel>(this, qualifier: Qualifiers.ClearBackStack);
            }
        }

    }
}
