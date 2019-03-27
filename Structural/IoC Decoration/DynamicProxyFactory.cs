using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bnaya.Samples
{
    public class DynamicProxyFactory<T> : DispatchProxy
    {
        private string _decoratedClassName;
        private T _decorated;
        private Action<(string ClassName, string ContractName, string MethodName)> _before;
        private Action<(string ClassName, string ContractName, string MethodName, TimeSpan Duration)> _after;
        private Action<(string ClassName, string ContractName, string MethodName, Exception Error)> _error;
        private readonly string _name;

        #region Create

        /// <summary>
        /// Creates the specified decorated (served by the base class).
        /// </summary>
        /// <param name="decorated">The decorated instance.</param>
        /// <param name="before">The before.</param>
        /// <param name="after">The after.</param>
        /// <param name="error">The error.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">decorated</exception>
        public static T Create(
            T decorated,
            Action<(string ImplementationName, string ContractName, string MethodName)> before = null,
            Action<(string ImplementationName, string ContractName, string MethodName, TimeSpan Duration)> after = null,
            Action<(string ImplementationName, string ContractName, string MethodName, Exception Error)> error = null)
        {
            #region Validation

            if (decorated == null)
            {
                throw new ArgumentNullException(nameof(decorated));
            }

            #endregion // Validation

            object proxy = Create<T, DynamicProxyFactory<T>>();

            var instance = (DynamicProxyFactory<T>)proxy;
            instance._decorated = decorated;
            instance._decoratedClassName = decorated.GetType().Name;
            instance._before = before;
            instance._after = after;
            instance._error = error;

            return (T)proxy;
        }

        #endregion // Create

        #region Ctor

        public DynamicProxyFactory()
        {
            _name = this.GetType().Name;
        }

        #endregion // Ctor

        #region Invoke [override]

        /// <summary>
        /// Override the invocation (do the AOP)
        /// </summary>
        /// <param name="targetMethod"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        protected override object Invoke(
            MethodInfo targetMethod,
            object[] args)
        {
            var sw = Stopwatch.StartNew();
            try
            {

                _before?.Invoke((_decoratedClassName, _name, targetMethod.Name));
                object result;
                if (targetMethod.IsStatic)
                    result = targetMethod.Invoke(null, args);
                else
                    result = targetMethod.Invoke(_decorated, args);

                if (result is Task t)
                {
                    Task _ = InvokeAsync(t);
                }
                else
                {
                    sw.Stop();
                    _after?.Invoke((_decoratedClassName, _name, targetMethod.Name, sw.Elapsed));
                }
                return result;
            }
            catch (Exception ex) when (ex is TargetInvocationException)
            {
                _error?.Invoke((_decoratedClassName, _name, targetMethod.Name, ex));
                throw ex.InnerException ?? ex;
            }

            async Task InvokeAsync(Task t)
            {
                try
                {
                    await t;
                    sw.Stop();
                    _after?.Invoke((_decoratedClassName, _name, targetMethod.Name, sw.Elapsed));
                }
                catch (Exception ex) when (ex is TargetInvocationException)
                {
                    _error?.Invoke((_decoratedClassName, _name, targetMethod.Name, ex));
                }
            }
        }


        #endregion // Invoke [override]

        public override string ToString() => $"Decorate: {_decorated}";
    }
}
