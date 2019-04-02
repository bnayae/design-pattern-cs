using System.Threading.Tasks;

namespace PaymentSAmple_Chain
{
    public interface IHandler
    {
        Task Handle(PaymentData data);
    }
}