using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;

namespace CESBotDemo1.Dialogs
{
    [Serializable]
    public class EmployeeDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            var employeeDetailForm = FormDialog.FromForm(BuildEmployeeForm, FormOptions.PromptInStart);

            context.Call(employeeDetailForm, OnEmployeeFormCompletion);
        }

        private IForm<Forms.EmployeeDetails> BuildEmployeeForm ()
        {
            return new FormBuilder<Forms.EmployeeDetails>()
                .AddRemainingFields()
                .Build();
        }

        private async Task OnEmployeeFormCompletion(IDialogContext context, IAwaitable<object> result)
        {
            await context.PostAsync("Thanks for filling the details");

            context.Done<object>(null);
        }
        
    }
}