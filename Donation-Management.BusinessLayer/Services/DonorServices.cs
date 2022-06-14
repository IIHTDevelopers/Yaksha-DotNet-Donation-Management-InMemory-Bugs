﻿using Donation_Management.BusinessLayer.Interfaces;
using Donation_Management.BusinessLayer.Services.Repository;
using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.DataLayer;
using Donation_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management.BusinessLayer.Services
{
    public class DonorServices:IDonorServices
    {
        private readonly IDonorRepository _donorRepository;
        private readonly NgoDbContext _ngoContext;

        public DonorServices(IDonorRepository donorRepository, NgoDbContext ngoDbContext)
        {
            _donorRepository = donorRepository;
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<Donor> FindDonorById(long ngoId)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorDetails"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Donor> Register(Donor donorDetails, string password)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Donor> UpdateDonor(RegisterDonorViewModel model)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> ListAllDonors()
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> GetDonorByNgoId(long ngoId)
        {
            return null;
        }
    }
}

