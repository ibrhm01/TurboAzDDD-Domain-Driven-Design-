﻿using Domain.Repositories;

namespace Domain
{
	public interface IUnitOfWork : IDisposable
	{
		public IVehicleRepository VehicleRepository { get; }
        public IBrandRepository BrandRepository { get; }
        public IColorRepository ColorRepository { get; }
        public IFuelTypeRepository FuelTypeRepository { get; }
        public ITransmissionRepository TransmissionRepository { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}