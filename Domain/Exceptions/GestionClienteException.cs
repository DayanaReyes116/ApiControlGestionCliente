using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class GestionClienteException : GCException
    {

        //
        // Resumen:
        //     Constructor.
        public GestionClienteException() : base() { }

        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   message:
        //     Exception message
        public GestionClienteException(string message) : base(message) { }
        //
        // Resumen:
        //     Constructor for serializing.
        public GestionClienteException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context) { }
        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   message:
        //     Exception message
        //
        //   severity:
        //     Exception severity
        public GestionClienteException(string message, LogSeverity severity) : base(message) { Severity = severity; }
        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   code:
        //     Error code
        //
        //   message:
        //     Exception message
        public GestionClienteException(int code, string message) : base(message) { Code = code; }
        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   message:
        //     Exception message
        //
        //   details:
        //     Additional information about the exception
        public GestionClienteException(string message, string details) : base(message) { Details = details; }
        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   message:
        //     Exception message
        //
        //   innerException:
        //     Inner exception
        public GestionClienteException(string message, Exception innerException) : base(message, innerException) { }
        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   code:
        //     Error code
        //
        //   message:
        //     Exception message
        //
        //   details:
        //     Additional information about the exception
        public GestionClienteException(int code, string message, string details) : base(message) { Code = code; Details = details; }
        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   message:
        //     Exception message
        //
        //   details:
        //     Additional information about the exception
        //
        //   innerException:
        //     Inner exception
        public GestionClienteException(string message, string details, Exception innerException) : base(message, innerException) { Details = details; }
        //
        // Resumen:
        //     An arbitrary error code.

    }
}
