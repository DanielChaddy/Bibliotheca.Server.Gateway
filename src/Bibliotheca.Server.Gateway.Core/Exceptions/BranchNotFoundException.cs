using Bibliotheca.Server.Mvc.Middleware.Diagnostics.Exceptions;

namespace Bibliotheca.Server.Gateway.Core.Exceptions
{
    public class BranchNotFoundException : NotFoundException
    {
        public BranchNotFoundException(string message) : base(message)
        {
        }
    }
}
