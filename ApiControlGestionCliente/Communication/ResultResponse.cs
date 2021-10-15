using System;

namespace Api.Communication
{
    /// <summary>
    /// Clase utilizada para contener la información que se enviará en un Response como resultado de una función AZURE FUNTION
    /// </summary>
    public class ResultResponse : BaseResponse
    {
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="resource">Saved user.</param>
        /// <returns>Response.</returns>
        public ResultResponse(object resource) : base(resource)
        { }

        /// <summary>
        /// Creates a fail response.
        /// </summary>
        /// <param name="ex">Exception.</param>
        /// <returns>Response.</returns>
        public ResultResponse(Exception ex) : base(ex)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ResultResponse(string message) : base(message)
        { }
    }
}
