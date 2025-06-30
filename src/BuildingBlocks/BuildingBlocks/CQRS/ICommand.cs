using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file defines your building blocks for working with commands in a CQRS-style architecture.

namespace BuildingBlocks.CQRS
{
    // This interface represents a "void" command — it performs an action but doesn't return any result.
    // It inherits from ICommand<Unit>, where Unit is like void in MediatR.
    public interface ICommand : ICommand<Unit>
    {
    }

    // This is a generic command interface that returns a value of type TResponse.
    // It extends MediatR's IRequest<TResponse>, which is the standard way to define a request with a result.
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
