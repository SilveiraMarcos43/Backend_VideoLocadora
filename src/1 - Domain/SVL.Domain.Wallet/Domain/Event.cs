using System;

namespace SVL.Location.Domain.Domain
{
    public class Event
    {
        private bool _isGeneratesAFine;
        private bool _isGeneratesPoint;

        /// <summary>
        /// Gerou Multa
        /// </summary>
        public Boolean IsGeneratesAFine { get => _isGeneratesAFine; set => _isGeneratesAFine = value; }

        /// <summary>
        /// Gerou Creditos Extras
        /// </summary>
        public Boolean GeneratedPoint { get => _isGeneratesPoint; set => _isGeneratesPoint = value; }

    }
}
