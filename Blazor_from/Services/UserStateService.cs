namespace Blazor_from.Services
{
    // 這個服務會儲存整個應用程式的使用者資訊
    public class UserStateService
    {
        public string? UserName { get; private set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);

        // 一個事件，其他元件可以訂閱這個事件來得知狀態已改變
        public event Action? OnStateChange;

        public void SetUser(string userName)
        {
            UserName = userName;
            NotifyStateChanged();
        }

        public void Logout()
        {
            UserName = null;
            NotifyStateChanged();
        }

        // 通知所有訂閱者，狀態已更新
        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}

