using AkilliPrompt.Domain.Common;
using FluentValidation;

namespace AkilliPrompt.WebApi.Common
{
    public abstract class EntityExistsValidator<TEntity, TCommand> : AbstractValidator<TCommand>
     where TEntity : EntityBase
    {
        private readonly IExistenceService<TEntity> _existenceService;

        public EntityExistsValidator(IExistenceService<TEntity> existenceService)
        {
            _existenceService = existenceService;

            RuleFor(e => GetEntityId(e))
                .NotEmpty()
                .WithMessage($"Lütfen geçerli bir {typeof(TEntity).Name} kimliği sağlayın.")
                .MustAsync(EntityExists)
                .WithMessage($"Belirtilen {typeof(TEntity).Name} mevcut değil.");
        }

        /// <summary>
        /// Extracts the entity ID from the command.
        /// </summary>
        /// <param name="command">The command containing the ID.</param>
        /// <returns>The entity ID.</returns>
        protected abstract Guid GetEntityId(TCommand command);

        /// <summary>
        /// Checks if the entity exists using the ExistenceService.
        /// </summary>
        /// <param name="id">Entity ID.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if exists; otherwise, false.</returns>
        private async Task<bool> EntityExists(Guid id, CancellationToken cancellationToken)
        {
            return await _existenceService.ExistsAsync(id, cancellationToken);
        }

    }
}
