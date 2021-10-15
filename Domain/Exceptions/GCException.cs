using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public enum LogSeverity
    {
        //
        // Resumen:
        //     Debug.
        Debug = 0,
        //
        // Resumen:
        //     Info.
        Info = 1,
        //
        // Resumen:
        //     Warn.
        Warn = 2,
        //
        // Resumen:
        //     Error.
        Error = 3,
        //
        // Resumen:
        //     Fatal.
        Fatal = 4
    }

    public class GCException : Exception
    {

        //
        // Resumen:
        //     Constructor.
        public GCException() : base() { }

        //
        // Resumen:
        //     Constructor.
        //
        // Parámetros:
        //   message:
        //     Exception message
        public GCException(string message) : base(message) { }
        //
        // Resumen:
        //     Constructor for serializing.
        public GCException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context) { }
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
        public GCException(string message, LogSeverity severity) : base(message) { Severity = severity; }
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
        public GCException(int code, string message) : base(message) { Code = code; }
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
        public GCException(string message, string details) : base(message) { Details = details; }
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
        public GCException(string message, Exception innerException) : base(message, innerException) { }
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
        public GCException(int code, string message, string details) : base(message) { Code = code; Details = details; }
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
        public GCException(string message, string details, Exception innerException) : base(message, innerException) { Details = details; }
        //
        // Resumen:
        //     An arbitrary error code.

        #region Sección de atributos adicionales al manejo de error

        public int Code { get; set; }
        //
        // Resumen:
        //     Additional information about the exception.
        public string Details { get; set; }
        //
        // Resumen:
        //     Severity of the exception. Default: Warn.
        public LogSeverity Severity { get; set; }

        #endregion
    }
}
