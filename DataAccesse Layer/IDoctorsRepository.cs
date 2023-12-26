﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesse_Layer
{
    public interface  IDoctorsRepository
    {
        public void Insert(Doctors iN);
        public void Update(long No, Doctors Replace);
        public List<Doctors> GetAll();
        public void Delete(long no);
        public Doctors GetbyID(long No);
    }
}
