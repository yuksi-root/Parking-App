﻿using Parking_App.Entities;
using Parking_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking_App.Repositories
{
    public class CarParkingRepository : GenericRepository<CarParking> , ICarParkingRepository
    {
       
    }
}
