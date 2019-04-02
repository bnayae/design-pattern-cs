using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSAmple_Chain
{
    public abstract class ChainBase : IHandler
    {
        private readonly IImmutableList<(Predicate<PaymentData> Cond, IHandler Handler)> _handlers;
        private readonly IImmutableList<IValidation> _validations;

        public ChainBase(
            IImmutableList<(Predicate<PaymentData> Cond, IHandler Handler)> handlers,
            IImmutableList<IValidation> validations)
        {
            _handlers = handlers;
            _validations = validations;
        }

        public async Task Handle(PaymentData data)
        {
            if (!Validate(data))
                return;

            await Task.Run(() => OnHandle(data));
            var tasks = _handlers.Select((h) =>
            {
                if (h.Cond(data))
                    return Task.Run(() => h.Handler.Handle(data));
                return Task.CompletedTask;
            });
            await Task.WhenAll(tasks);
            //foreach (var (cond, handler) in _handlers)
            //{
            //    if (cond(data))
            //        handler.Handle(data);
            //}
        }
        protected virtual void OnHandle(PaymentData data) {}

        private bool Validate(PaymentData data)
        {
            if (!OnValidate(data))
                return false;
            return _validations.All(v => v.Validate(data));
        }

        protected virtual bool OnValidate(PaymentData data) => true;
    }
}
