using Elsa.Scripting.Liquid.Messages;
using elsa_blazor.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Fluid;

namespace elsa_blazor.Handlers
{
    /// <summary>
    /// Configure the Liquid template context to allow access to certain models. 
    /// </summary>
    public class LiquidConfigurationHandler : INotificationHandler<EvaluatingLiquidExpression>
    {
        public Task Handle(EvaluatingLiquidExpression notification, CancellationToken cancellationToken)
        {
            var context = notification.TemplateContext;
            context.MemberAccessStrategy.Register<User>();
            context.MemberAccessStrategy.Register<RegistrationModel>();

            return Task.CompletedTask;
        }
    }
}
