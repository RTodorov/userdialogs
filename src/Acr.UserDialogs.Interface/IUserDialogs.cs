using System;
using System.Threading.Tasks;


namespace Acr.UserDialogs {

    public interface IUserDialogs {

        void Alert(string message, string title = null, string okText = null);
        void Alert(AlertConfig config);
        void ActionSheet(ActionSheetConfig config);
        void Confirm(ConfirmConfig config);
        void Prompt(PromptConfig config);
        void Login(LoginConfig config);
        IProgressDialog Progress(ProgressDialogConfig config);
		IProgressDialog Loading(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = null);
		IProgressDialog Progress(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = null);

		void ShowLoading(string title = null, MaskType? maskType = null);
        void HideLoading();
		void Toast(string message, int timeoutSeconds = 3, Action onClick = null, MaskType maskType = MaskType.None);

        Task AlertAsync(string message, string title = null, string okText = null);
        Task AlertAsync(AlertConfig config);
        Task<bool> ConfirmAsync(string message, string title = null, string okText = null, string cancelText = null);
        Task<bool> ConfirmAsync(ConfirmConfig config);
        Task<LoginResult> LoginAsync(string title = null, string message = null);
        Task<LoginResult> LoginAsync(LoginConfig config);
        Task<PromptResult> PromptAsync(string message, string title = null, string okText = null, string cancelText = null, string placeholder = "", InputType inputType = InputType.Default);
        Task<PromptResult> PromptAsync(PromptConfig config);

        void ShowSuccess(string message, int timeout = 3);
        void ShowError(string message, int timeout = 3);
    }
}